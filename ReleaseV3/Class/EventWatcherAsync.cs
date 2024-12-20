using MetroFramework.Controls;
using ReleaseMonitorV4.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReleaseMonitorV4.Class
{
    class EventWatcherAsync
    {

        string ComputerName = "localhost";
        string WmiQuery;
        ManagementEventWatcher Watcher;
        ManagementScope Scope;
        COperations m_operations;
        RichTextBox m_console;
        RichTextBox m_processFiles;
        delegate void addLineDelegate(string texto);
        delegate void addLine_PFDelegate(string texto);
        String m_path;

        private void addLine_PF(string texto)
        {
            try
            {
                if (m_processFiles.InvokeRequired)
                {
                    addLine_PFDelegate delegado = new addLine_PFDelegate(addLine_PF);
                    object[] parametros = new object[] { texto };
                    m_processFiles.Invoke(delegado, parametros);
                }
                else
                {
                    try
                    {
                        m_processFiles.AppendText(texto + "\n");
                    }
                    catch (Exception ex) { }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void addLine(string texto)
        {
            try
            {
                if (m_console.InvokeRequired)
                {
                    addLineDelegate delegado = new addLineDelegate(addLine);
                    object[] parametros = new object[] { texto };
                    m_console.Invoke(delegado, parametros);
                }
                else
                {
                    try
                    {
                        m_console.AppendText(texto + "\n");
                    }
                    catch (Exception ex) { }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void WmiEventHandler(object sender, EventArrivedEventArgs e)
        {
            // e.NewEvent
            string wclass = ((ManagementBaseObject)e.NewEvent).SystemProperties["__Class"].Value.ToString();
            string wop = string.Empty;
            
            string wfilename = ((ManagementBaseObject)e.NewEvent.Properties["TargetInstance"].Value)["FileName"].ToString();

            if (!string.IsNullOrEmpty(((ManagementBaseObject)e.NewEvent.Properties["TargetInstance"].Value)["Extension"].ToString()))
            {
                wfilename += "." + ((ManagementBaseObject)e.NewEvent.Properties["TargetInstance"].Value)["Extension"].ToString();
            }

            string wFullpath = ((ManagementBaseObject)e.NewEvent.Properties["TargetInstance"].Value)["Name"].ToString();

            switch (wclass)
            {
                case "__InstanceModificationEvent":
                    wop = "Modified";
                    addLine_PF(String.Format("The File {0} was {1}", wfilename, wop));
                    m_operations.procesFile(wFullpath, wfilename, m_path);
                    break;
                case "__InstanceCreationEvent":
                    wop = "Created";
                    addLine_PF(String.Format("The File {0} was {1}", wfilename, wop));
                    m_operations.procesFile(wFullpath, wfilename,m_path);
                    break;
                case "__InstanceDeletionEvent":
                    wop = "Moved";
                    addLine_PF(String.Format("The File {0} was {1}", wfilename, wop));
                    break;
            }
            //string wfilename = ((ManagementBaseObject)e.NewEvent.Properties["TargetInstance"].Value)["FileName"].ToString();

            //if (!string.IsNullOrEmpty(((ManagementBaseObject)e.NewEvent.Properties["TargetInstance"].Value)["Extension"].ToString()))
            //{
            //    wfilename += "." + ((ManagementBaseObject)e.NewEvent.Properties["TargetInstance"].Value)["Extension"].ToString();
            //}
            Console.WriteLine(String.Format("The File {0} was {1}", wfilename, wop));
            


        }

        public EventWatcherAsync(ref MetroTextBox mText1, ref RichTextBox console, ref RichTextBox prFiles, String program, CDJ dJ, String pok, String tgDrive, String tgPath,String haspanel)
        {
            try
            {
                m_console = console;
                m_processFiles = prFiles;
                m_path = tgDrive + tgPath;

                addLine("Setting monitor in " + tgDrive+tgPath);
                if (!ComputerName.Equals("localhost", StringComparison.OrdinalIgnoreCase))
                {
                    ConnectionOptions Conn = new ConnectionOptions();
                    Conn.Username = "";
                    Conn.Password = "";
                    Conn.Authority = "ntlmdomain:DOMAIN";
                    Scope = new ManagementScope(String.Format("\\\\{0}\\root\\CIMV2", ComputerName), Conn);
                }
                else
                    Scope = new ManagementScope(String.Format("\\\\{0}\\root\\CIMV2", ComputerName), null);
                Scope.Connect();
                WmiQuery = @"Select * From __InstanceOperationEvent Within 1 
                Where TargetInstance ISA 'CIM_DataFile' and TargetInstance.Drive = '" + tgDrive + "' AND TargetInstance.Path='" + tgPath + "'";

                Watcher = new ManagementEventWatcher(Scope, new EventQuery(WmiQuery));
                Watcher.EventArrived += new EventArrivedEventHandler(this.WmiEventHandler);

                m_operations = new COperations(ref mText1,ref console, ref prFiles,program,dJ,pok, haspanel);
                addLine("Setting monitor in " + tgDrive + tgPath + " successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception {0} Trace {1}", e.Message, e.StackTrace);
            }

        }
        public bool startWatch()
        {
            bool result = false;

            if (Watcher != null)
            {
                Watcher.Start();
                result = true;
            }
            return result;
        }
        public bool stopWatch()
        {
            bool result = false;

            if (Watcher != null)
            {
                Watcher.Stop();
                result = true;
            }
            return result;
        }
    }
}
