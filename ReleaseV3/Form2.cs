
using MetroFramework.Forms;
using ReleaseMonitorV4.cgsOpenInterface;
using ReleaseMonitorV4.Class;
using ReleaseMonitorV4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using SoftMade.IO;
using System.Threading;
using System.Diagnostics;

namespace ReleaseMonitorV4
{
    public partial class Form2 : MetroForm
    {
        EventWatcherAsync m_watcher;
        private static siixsem_mits_projectEntities m_dbMitsubishi;
        List<String> m_listProcessFiles;
        getReleasePath_Result m_paths;
        //CMySQL m_mySQL;

        delegate void addLineDelegate(string texto);
        delegate void addLine_PFDelegate(string texto);
        delegate void setErrorDelegate(string texto);
        delegate void setSuccessDelegate(string texto);
        delegate void setWarningDelegate(string texto);
        delegate void setInfoDelegate(string texto);
        Regex pokayoke;
        String m_program;
        CDJ m_dj;
        DataSet m_log;
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        String m_tgDrive = "";
        String m_tgPath = "";
        String m_numBoards = "";
        String m_machine = "";
        private siixsem_laser_mark_cfgEntities m_laserM;
        private getLMParameters_Result m_ReleaseParams;
        CModelInfo model;
        CCogiscanCGS m_db2;
        String m_qty;
        String m_pokayoke;
        String m_review;
        String haspanel;


        //tb_qty.Text = numBoards = model.NUMBER_BOARDS.ToString();
        //    tb_pokayoke.Text = model.POKAYOKE;
        //    tb_route.Text = model.ROUTE;
        //    tb_revision.Text = model.REV;
        //    tb_program.Text = model.FG_NAME;
        //    haspanel = model.HAS_PANEL;

        public Form2()
        {
            InitializeComponent();

            model = new CModelInfo();
            m_machine = Environment.MachineName;
            m_laserM = new siixsem_laser_mark_cfgEntities();
            m_ReleaseParams = m_laserM.getLMParameters(m_machine).First();
            m_db2 = new CCogiscanCGS();
            //m_dbMitsubishi = new siixsem_mits_projectEntities();
            //m_paths = m_dbMitsubishi.getReleasePath().First();
            //pokayoke = new Regex(pok);
            //m_program = program;
            //m_dj = dJ;
            //metroTextBox2.Text = m_paths.PATHDEV;
            //m_tgDrive = m_paths.tgDriveDev;
            //m_tgPath = m_paths.tgPathDev;
            //m_numBoards = numBoards;
            //m_log = new DataSet();
            //m_listProcessFiles = new List<String>();
            //m_watcher = new EventWatcherAsync(ref metroTextBox1, ref m_console, ref m_processFiles, m_program, m_dj, pok, m_tgDrive, m_tgPath, haspanel);

        }
        public Form2(String pok, String program, CDJ dJ,String haspanel,String numBoards)
        {
            InitializeComponent();

            m_dbMitsubishi = new siixsem_mits_projectEntities();
            m_paths = m_dbMitsubishi.getReleasePath().First();
            pokayoke = new Regex(pok);
            m_program = program;
            m_dj = dJ;
            metroTextBox2.Text = m_paths.PATHDEV;
            m_tgDrive = m_paths.tgDriveDev;
            m_tgPath = m_paths.tgPathDev;
            m_numBoards = numBoards;
            m_log = new DataSet();
            m_listProcessFiles = new List<String>();
            //m_watcher = new EventWatcherAsync(ref metroTextBox1,ref m_console,ref m_processFiles,m_program,m_dj,pok,m_tgDrive,m_tgPath,haspanel);

        }

        private void initWacher()
        {
            advancedFileSystemWatcher1.Path = metroTextBox2.Text;
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
            catch(Exception ex)
            {

            }
        }

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
        private void setError(string texto)
        {
            try
            {
                if (metroTextBox1.InvokeRequired)
                {
                    setErrorDelegate delegado = new setErrorDelegate(setError);
                    object[] parametros = new object[] { texto };
                    metroTextBox1.Invoke(delegado, parametros);
                }
                else
                {
                    try
                    {
                        metroTextBox1.Text = texto;
                        metroTextBox1.BackColor = Color.Red;
                        metroTextBox1.ForeColor = Color.White;
                        metroTextBox1.Update();
                    }
                    catch (Exception ex) { }
                }
            }
            catch(Exception ex)
            {

            }
        }
        private void setWarning(string texto)
        {
            try
            {
                if (metroTextBox1.InvokeRequired)
                {
                    setWarningDelegate delegado = new setWarningDelegate(setWarning);
                    object[] parametros = new object[] { texto };
                    metroTextBox1.Invoke(delegado, parametros);
                }
                else
                {
                    try
                    {
                        metroTextBox1.Text = texto;
                        metroTextBox1.BackColor = Color.Orange;
                        metroTextBox1.ForeColor = Color.White;
                        metroTextBox1.Update();
                    }
                    catch (Exception ex) { }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void setInfo(string texto)
        {
            try
            {
                if (metroTextBox1.InvokeRequired)
                {
                    setInfoDelegate delegado = new setInfoDelegate(setInfo);
                    object[] parametros = new object[] { texto };
                    metroTextBox1.Invoke(delegado, parametros);
                }
                else
                {
                    try
                    {
                        metroTextBox1.Text = texto;
                        metroTextBox1.BackColor = Color.Blue;
                        metroTextBox1.ForeColor = Color.White;
                        metroTextBox1.Update();
                    }
                    catch (Exception ex) { }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void setSuccess(string texto)
        {
            try
            {
                if (metroTextBox1.InvokeRequired)
                {
                    setSuccessDelegate delegado = new setSuccessDelegate(setSuccess);
                    object[] parametros = new object[] { texto };
                    metroTextBox1.Invoke(delegado, parametros);
                }
                else
                {
                    try
                    {
                        metroTextBox1.Text = texto;
                        metroTextBox1.BackColor = Color.Green;
                        metroTextBox1.ForeColor = Color.White;
                        metroTextBox1.Update();
                    }
                    catch (Exception ex) { }
                }
            }
            catch(Exception ex)
            {

            }
        }
        void moveFile(String path, String FileName)
        {
            try
            {
                String pathDir = metroTextBox2.Text + "\\processedFiles\\" + FileName;
                if (!Directory.Exists(metroTextBox2.Text + "\\processedFiles"))
                    Directory.CreateDirectory(metroTextBox2.Text + "\\processedFiles");
                if (!File.Exists(pathDir))
                {
                    File.Move(path, pathDir);
                    addLine_PF("Se movio " + path + " a " + pathDir + "\n");
                    logger.Info("Se movio " + path + " a " + pathDir);
                }
            }catch(Exception ex)
            {
                addLine(ex.Message);
            }
        }
        void moveFileError(String path, String FileName)
        {
            try
            {
                String pathDir = metroTextBox2.Text + "\\errorFiles\\" + FileName;
                if (!Directory.Exists(metroTextBox2.Text + "\\errorFiles"))
                    Directory.CreateDirectory(metroTextBox2.Text + "\\errorFiles");
                if (!File.Exists(pathDir))
                {
                    File.Move(path, pathDir);
                    addLine_PF("Se movio " + path + " a " + pathDir + "\n");
                    logger.Info("Se movio " + path + " a " + pathDir);
                }
            }
            catch(Exception ex) {
                addLine(ex.Message);
            }
        }
        void OnRenamed(object source, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }
        void OnError(object source, ErrorEventArgs e)
        {
            int iMaxAttempts = 120;
            int iTimeOut = 30000;
            int i = 0;
            
            while ((!Directory.Exists(advancedFileSystemWatcher1.Path) || advancedFileSystemWatcher1.EnableRaisingEvents == false) && i < iMaxAttempts)
            {
                i += 1;
                try
                {
                    advancedFileSystemWatcher1.EnableRaisingEvents = false;
                    if (!Directory.Exists(advancedFileSystemWatcher1.Path))
                    {
                        addLine("Directory Inaccessible " + advancedFileSystemWatcher1.Path + " at " + DateTime.Now.ToString("HH:mm:ss"));
                        System.Threading.Thread.Sleep(iTimeOut);
                    }
                    else
                    {
                        initWacher();
                        addLine("Try to Restart RaisingEvents Watcher at " + DateTime.Now.ToString("HH:mm:ss"));
                    }
                }
                catch (Exception error)
                {
                    addLine("Error trying Restart Service " + error.StackTrace + " at " + DateTime.Now.ToString("HH:mm:ss"));
                    advancedFileSystemWatcher1.EnableRaisingEvents = false;
                    System.Threading.Thread.Sleep(iTimeOut);
                }
            }
        }
        private void OnCreated(object source, SoftMade.IO.FileSystemEventArgs log)
        {
            addLine(log.ChangeType.ToString()); 
            if (log.ChangeType == SoftMade.IO.WatcherChangeTypes.Created && File.Exists(log.FullPath))
            {
            }
        }

        private void OnChanged(object source, SoftMade.IO.FileSystemEventArgs log)
        {

        }

        private void InsertSerials(Dictionary<string, string> barcodes, int panel, Dictionary<string, string> c, Dictionary<string, string> s)
        {
            //int numPanel = Convert.ToInt32(m_dbMitsubishi.mitsPorcedure("getMaxPanel", null, null, null, null, null).First().PanelId);
            try
            {
                foreach (KeyValuePair<string, string> barcode in barcodes)
                {
                    if (barcode.Value.Contains("C"))
                        c.Add(barcode.Key, barcode.Value);
                    else
                        if (barcode.Value.Contains("S"))
                        s.Add(barcode.Key, barcode.Value);

                }
                if (c.Count == s.Count)
                {
                    for (int i = 1; i <= c.Count; i++)
                    {
                        if (m_dbMitsubishi.InsertDoubleSerials(m_program, c[i.ToString()], s[(i + c.Count).ToString()], panel, i, m_dj.BatchId).First().PanelId > 0)
                        {
                            while (m_dbMitsubishi.existSerialC(c[i.ToString()]).First().RESULT == -1)
                            {
                                Thread.Sleep(500);
                                m_dbMitsubishi.InsertDoubleSerials(m_program, c[i.ToString()], s[(i + c.Count).ToString()], panel, i, m_dj.BatchId);
                            }

                            addLine("<----- Se inserto el serial. -------->");
                        }
                        else
                        {
                            while (m_dbMitsubishi.existSerialC(c[i.ToString()]).First().RESULT == -1)
                            {
                                Thread.Sleep(500);
                                m_dbMitsubishi.InsertDoubleSerials(m_program, c[i.ToString()], s[(i + c.Count).ToString()], panel, i, m_dj.BatchId);
                            }
                            addLine("++++++++++ El serial ya existe en la base de datos +++++++++++");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                addLine("Ocurrió el siguiente error: " + ex.Message);
            }
        }
        private bool ReleaseCgs(string program, string revision, string route, string batchId, int batchQty, string panelId, Dictionary<string, string> barcode_dict, String strEvent)
        {
            string rel;
            string result;
            RPCServicesClient client = new RPCServicesClient();
            int dummie_qty = barcode_dict.Count();
            string serial = "";
            String pcbs = "";
            bool response = false;
            try
            {

                rel = "<Parameters><Parameter name=\"assembly\">" + program + "</Parameter>";
                rel += "<Parameter name=\"revision\">" + revision + "</Parameter>";
                rel += "<Parameter name=\"route\">" + route + "</Parameter>";
                rel += "<Parameter name=\"batchId\">" + batchId + "</Parameter>";
                rel += "<Parameter name=\"maxReleaseQty\">" + batchQty + "</Parameter>";
                rel += "<Extensions><ProductGroup>";

                foreach (KeyValuePair<string, string> barcode in barcode_dict)
                {
                    rel += "<Product location=\"A" + barcode.Key + "\">" + barcode.Value + "</Product>";
                    serial += barcode.Value + " - ";
                }

                rel += "</ProductGroup></Extensions></Parameters>";

                result = client.executeCommand("releaseProduct", rel);

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(result);


                if (result.Contains("Exception")) {
                    XmlNode exc = xml.SelectSingleNode("Exception");
                    if (result.Contains("There was no endpoint listening")|| result.Contains(" The request channel timed out"))
                    {
                        m_dbMitsubishi.InsertError(serial, "Release", result);
                        addLine(result);
                        setError(exc.Attributes["message"].Value);
                        logger.Error("Ocurrio el siguiente error al intenter dar Release: " + result + " .... Se reintentara dar Relese");
                        addLine("Se reintentara hacer Release a la pieza....");
                        response = ReleaseCgs(program, revision, route, batchId, batchQty, panelId, barcode_dict, strEvent);
                    }
                    else
                        if (result.Contains("Item already exists"))
                        {
                            m_dbMitsubishi.InsertError(serial, "Release", result);
                            addLine("\n" + result);
                            logger.Error("Ya se le dio release a las piezas. " + serial + " " + strEvent);
                            setError("El serial ya existe en COGISCAN.");
                            response = false;
                        }
                        else {
                            addLine(result);
                            setError(exc.Attributes["message"].Value);
                            logger.Error(exc.Attributes["message"].Value); 
                            m_dbMitsubishi.InsertError(serial, "Release", exc.Attributes["message"].Value);
                        }
                }
                else response = true;

            }
            catch(Exception ex)
            {
                addLine("Ocurrió el siguiente error: " + ex.Message);
                if (ex.Message.Contains("There was no endpoint listening") || ex.Message.Contains(" The request channel timed out"))
                {
                    m_dbMitsubishi.InsertError(serial, "Release", ex.Message);
                    addLine("No se pudo hacer Release a la pieza... Se reintentara el proceso...");
                    setWarning("No se pudo hacer Release a la pieza... Se reintentara el proceso...");
                    logger.Error("No se pudo hacer Release a la pieza... Se reintentara el proceso... " + pcbs);
                    response = ReleaseCgs(program, revision, route, batchId, batchQty, panelId, barcode_dict, strEvent + " Exception");

                }
            }

            return response;
            
        }

        private void m_console_TextChanged(object sender, EventArgs e)
        {
            m_console.SelectionStart = m_console.Text.Length;
            m_console.ScrollToCaret();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                setConfig();
                //m_watcher.startWatch();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se encontro la configuración del modelo a marcar en: " + m_machine + ". No se a iniciado el monitoreo","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void m_console_TextChanged_1(object sender, EventArgs e)
        {
            m_console.SelectAll();
            m_console.SelectionAlignment = HorizontalAlignment.Center;
            m_console.DeselectAll();

            m_console.SelectionStart = m_console.Text.Length;
            m_console.ScrollToCaret();
        }

        private void timerWatch_Tick(object sender, EventArgs e)
        {
            //initWacher();
        }

        private void b_stop_Click(object sender, EventArgs e)
        {

        }

        private void m_processFiles_TextChanged(object sender, EventArgs e)
        {
            m_processFiles.SelectAll();
            m_processFiles.SelectionAlignment = HorizontalAlignment.Center;
            m_processFiles.DeselectAll();

            m_processFiles.SelectionStart = m_console.Text.Length;
            m_processFiles.ScrollToCaret();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(m_watcher!=null)
                m_watcher.stopWatch();
        }
        private bool setConfig()
        {
            bool result = false;
            m_paths = m_laserM.getReleasePath().First();
            metroTextBox2.Text = m_paths.PATHPROD;
            m_tgDrive = m_paths.tgDrive;
            m_tgPath = m_paths.tgPath;

            kryptonLabel2.Text = m_machine;

            model = m_db2.getInfoModel(m_ReleaseParams.PROGRAM);
            m_dj = new CDJ(model.REV,model.ROUTE,m_ReleaseParams.BATCHID,Convert.ToInt32(m_ReleaseParams.QTYPCBPANEL),false);
            metroLabel2.Text = "Group: " + m_dj.BatchId;
            metroLabel3.Text = "Qty:   " + m_ReleaseParams.QTYPCBPANEL.ToString() + "  PCB's   -   " + m_ReleaseParams.QTYPANELS + "  Panels.";
            metroLabel4.Text = "Pokayoke: " + model.POKAYOKE;
            metroLabel5.Text = "Route: " + model.ROUTE;
            metroLabel6.Text = "Review: " + model.REV;
            metroLabel7.Text = "Program" + model.FG_NAME;
            haspanel = model.HAS_PANEL;
            m_watcher = new EventWatcherAsync(ref metroTextBox1, ref m_console, ref m_processFiles, model.FG_NAME, m_dj, model.POKAYOKE, m_tgDrive, m_tgPath, haspanel);
            return result;
        }
    }
}
