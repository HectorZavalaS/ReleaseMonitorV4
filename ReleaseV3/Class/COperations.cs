using MetroFramework.Controls;
using ReleaseMonitorV4.cgsOpenInterface;
using ReleaseMonitorV4.Class;
using ReleaseMonitorV4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ReleaseMonitorV4.Class
{
    class COperations
    {
        MetroTextBox metroTextBox1;
        RichTextBox m_console;
        RichTextBox m_processFiles;
        private static siixsem_mits_projectEntities m_dbMitsubishi;
        private siixsem_laser_mark_cfgEntities m_laserM;
        private getLMParameters_Result m_ReleaseParams;

        Regex pokayoke;
        String m_program;
        CDJ m_dj;
        DataSet m_log;
        bool has_panel;
        String m_machine = ""; 

        delegate void addLineDelegate(string texto);
        delegate void addLine_PFDelegate(string texto);
        delegate void setErrorDelegate(string texto);
        delegate void setSuccessDelegate(string texto);
        delegate void setWarningDelegate(string texto);
        delegate void setInfoDelegate(string texto);
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public COperations(ref MetroTextBox mText1, ref RichTextBox console, ref RichTextBox prFiles, String program, CDJ dJ, String pok, String hasPanel)
        {
            metroTextBox1 = mText1;
            m_console = console;
            m_processFiles = prFiles;
            m_dbMitsubishi = new siixsem_mits_projectEntities();
            m_laserM = new siixsem_laser_mark_cfgEntities();
            m_program = program;
            m_dj = dJ;
            pokayoke = new Regex(pok);
            m_log = new DataSet();
            has_panel = hasPanel == "Y" ? true : false;
            m_machine = Environment.MachineName;
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
            catch (Exception ex)
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
            catch (Exception ex)
            {

            }
        }
        void moveFile(String path, String FileName)
        {
            try
            {
                String pathDir = path.Replace("\\\\", "\\") + "processedFiles\\" + FileName;
                if (!Directory.Exists(path.Replace("\\\\", "\\") + "processedFiles"))
                    Directory.CreateDirectory(path.Replace("\\\\", "\\") + "processedFiles");
                if (!File.Exists(pathDir))
                {
                    File.Move(path.Replace("\\\\", "\\") + FileName, pathDir);
                    addLine_PF("Se movio " + path.Replace("\\\\", "\\") + FileName + " a " + pathDir + "\n");
                    logger.Info("Se movio " + path.Replace("\\\\", "\\") + FileName + " a " + pathDir);
                }
            }
            catch (Exception ex)
            {
                addLine(ex.Message);
            }
        }
        void moveFileError(String path, String FileName)
        {
            try
            {
                String pathDir = path.Replace("\\\\","\\") + "errorFiles\\" + FileName;
                if (!Directory.Exists(path.Replace("\\\\", "\\") + "errorFiles"))
                    Directory.CreateDirectory(path.Replace("\\\\", "\\") + "errorFiles");
                if (!File.Exists(pathDir))
                {
                    File.Move(path.Replace("\\\\", "\\") + FileName, pathDir);
                    addLine_PF("Se movio " + path.Replace("\\\\", "\\") + FileName + " a " + pathDir + "\n");
                    logger.Info("Se movio " + path.Replace("\\\\", "\\") + FileName + " a " + pathDir);
                }
            }
            catch (Exception ex)
            {
                addLine(ex.Message);
            }
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
                        String strC = c[i.ToString()];
                        String strS = s[(i + c.Count).ToString()];

                        if (m_dbMitsubishi.InsertDoubleSerials(m_program, strC, strS, panel, i, m_dj.BatchId).First().PanelId > 0)
                            addLine("<----- Se inserto el serial. -------->");
                        else addLine("++++++++++ El serial ya existe en la base de datos +++++++++++");
                    }
                }
            }
            catch (Exception ex)
            {
                addLine("Ocurrió el siguiente error: " + ex.Message);
            }
        }
        private void InsertSerialsXB(Dictionary<string, string> barcodes, int panel, Dictionary<string, string> c, Dictionary<string, string> s)
        {
            //int numPanel = Convert.ToInt32(m_dbMitsubishi.mitsPorcedure("getMaxPanel", null, null, null, null, null).First().PanelId);
            try
            {
                foreach (KeyValuePair<string, string> barcode in barcodes)
                {
                    if (barcode.Value.Contains("S"))
                        s.Add(barcode.Key, barcode.Value);
                    else
                        if (barcode.Value.Contains("C"))
                        c.Add(barcode.Key, barcode.Value);

                }
                if (c.Count == s.Count)
                {

                    for (int i = 1; i <= s.Count; i++)
                    {
                        String strS = s[i.ToString()];
                        String strC = c[(i + s.Count).ToString()];

                        if (m_dbMitsubishi.InsertDoubleSerials(m_program, strC, strS, panel, i, m_dj.BatchId).First().PanelId > 0)
                            addLine("<----- Se inserto el serial. -------->");
                        else addLine("++++++++++ El serial ya existe en la base de datos +++++++++++");
                    }
                }
            }
            catch (Exception ex)
            {
                addLine("Ocurrió el siguiente error: " + ex.Message);
            }
        }
        private bool insertaPCB(String C, String S, int panel, int i, String batch_id)
        {
            bool result = false;

            if (m_dbMitsubishi.InsertDoubleSerials(m_program, C, S, panel, i, batch_id).First().PanelId > 0)
                result = true;
            else insertaPCB(C, S, panel, i, batch_id);

            return result;
        }
        private bool ReleaseCgs(string program, string revision, string route, string batchId, int batchQty, string panelId, Dictionary<string, string> barcode_dict)
        {
            string rel;
            string result;
            RPCServicesClient client = new RPCServicesClient();
            int dummie_qty = barcode_dict.Count();
            string serial = "";
            String pcbs = "";
            bool isMit = false;

            bool response = false;
            try
            {
                if (panelId.Contains("XA") || panelId.Contains("XB")) isMit = true;
                else isMit = false;

                rel = "<Parameters><Parameter name=\"assembly\">" + program + "</Parameter>";
                rel += "<Parameter name=\"revision\">" + revision + "</Parameter>";
                rel += "<Parameter name=\"route\">" + route + "</Parameter>";
                rel += "<Parameter name=\"batchId\">" + batchId + "</Parameter>";
                rel += "<Parameter name=\"maxReleaseQty\">" + batchQty + "</Parameter>";
                
                if (has_panel) rel += "<Extensions><ProductGroup barcode=\"" + panelId + "\">"; 
                else rel += "<Extensions><ProductGroup>";
                
                if(!has_panel)
                    foreach (KeyValuePair<string, string> barcode in barcode_dict)
                    {
                           rel += "<Product location=\"" + barcode.Key + "\">" + barcode.Value + "</Product>";
                           serial += barcode.Value + " - ";
                    }
                else
                    foreach (KeyValuePair<string, string> barcode in barcode_dict)
                    {

                        if (!barcode.Value.Contains(panelId))
                        {
                            rel += "<Product location=\"" + (Convert.ToInt32(barcode.Key)-1).ToString() + "\">" + barcode.Value + "</Product>";
                            serial += barcode.Value + " - ";
                        }
                    }
                rel += "</ProductGroup></Extensions></Parameters>";

                result = client.executeCommand("releaseProduct", rel);

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(result);


                if (result.Contains("Exception"))
                {
                    XmlNode exc = xml.SelectSingleNode("Exception");
                    if (result.Contains("There was no endpoint listening") || result.Contains("The request channel timed out"))
                    {
                        addLine(result);
                        setError(exc.Attributes["message"].Value);
                        logger.Error("Ocurrio el siguiente error al intenter dar Release: " + result + " .... Se reintentara dar Relese");
                        addLine("Se reintentara hacer Release a la pieza....");
                        response = ReleaseCgs(program, revision, route, batchId, batchQty, panelId, barcode_dict);
                    }
                    else
                        if (result.Contains("Item already exists"))
                        {
                            addLine("\n" + result);
                            logger.Error("Ya se le dio release a las piezas. " + serial);
                            setError("El serial ya existe en COGISCAN.");
                            response = false;
                        }
                        else
                        {
                            addLine(result);
                            setError(exc.Attributes["message"].Value);
                            logger.Error(exc.Attributes["message"].Value);
                        }
                }
                else response = true;

            }
            catch (Exception ex)
            {
                addLine("Ocurrió el siguiente error: " + ex.Message);
                if (ex.Message.Contains("There was no endpoint listening") || ex.Message.Contains("The request channel timed out"))
                {
                    addLine("No se pudo hacer Release a la pieza... Se reintentara el proceso...");
                    setWarning("No se pudo hacer Release a la pieza... Se reintentara el proceso...");
                    logger.Error("No se pudo hacer Release a la pieza... Se reintentara el proceso... " + pcbs);
                    response = ReleaseCgs(program, revision, route, batchId, batchQty, panelId, barcode_dict);

                }
            }

            return response;
        }
        public void procesFile(String FullPath, String fileName, String path)
        {
            Thread.Sleep(500);
            getLaserMarkByDesc_Result LM = m_laserM.getLaserMarkByDesc(m_machine).First();
            m_laserM.setTaskToLM(LM.se_id, "RELEASE_PCB","IN_PROGRESS");
            m_ReleaseParams = m_laserM.getLMParameters(m_machine).First();
            if (File.Exists(FullPath))
            {
                string modelName = "";
                string panelId = "";
                string date = "";
                Dictionary<string, string> barcodes = new Dictionary<string, string>();
                Boolean isvalidPok = true;
                int panel = -1;
                Dictionary<string, string> c = new Dictionary<string, string>();
                Dictionary<string, string> s = new Dictionary<string, string>();
                string serial = "";
                XmlDocument doc = null;
                XmlNodeList parameters, seriales;
                XmlNode panelS;
                String xml;
                bool isXA = false;

                addLine("... LOADING FILE ...\n");
                addLine_PF("La marcadora genero el archivo " + FullPath);
                logger.Info("La marcadora genero el archivo " + FullPath);
                //m_listProcessFiles.Add(log.Name);

                setInfo("+++++++++++++++ Se procesara log... " + fileName + " ++++++++++++++\n");

                try
                {
                    m_log.ReadXml(FullPath);

                    var fileStream = new FileStream(FullPath, FileMode.Open, FileAccess.Read);
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                    {
                        xml = streamReader.ReadToEnd();
                    }
                    doc = new XmlDocument();
                    doc.LoadXml(xml);

                    parameters = doc.SelectNodes("Parameters/Parameter");


                    foreach (XmlNode node in parameters)
                    {
                        if (!String.IsNullOrEmpty(node.Attributes["name"].Value) && node.Attributes["name"].Value == "modelName")
                            modelName = node.InnerText;
                        else date = node.InnerText;
                    }
                }
                catch (Exception e)
                {
                    //addLine("--- Warning: Este log ya se proceso o esta en procesamiento: " + log.Name + "... ---\n\n" + e.Message);
                    //setWarning("warning: Este log ya se proceso o esta en procesamiento: " + log.Name + "..." + e.Message);
                    return;
                }

                //addLine("Model: " + modelName);
                //addLine("Date: " + date);

                try
                {
                    panelS = doc.SelectSingleNode("Parameters/Extensions/ProductGroup");
                    panelId = panelS.Attributes["barcode"].Value;

                    if (panelId.Contains("XA")) isXA = true;
                    else isXA = false;

                    //addLine("PanelID: " + panelId + "\n");
                    seriales = doc.SelectNodes("Parameters/Extensions/ProductGroup/Product");
                    foreach (XmlNode node in seriales)
                    {
                        if (!pokayoke.IsMatch(node.InnerText))
                        {
                            addLine("*** El serial " + node.InnerText + " no corresponde al pokayoke configurado. No se procesará el log. ***");
                            setError("El serial " + node.InnerText + " no corresponde al pokayoke configurado. No se procesará el log.");
                            logger.Error("El serial " + node.InnerText + " no corresponde al pokayoke configurado. No se procesará el log.");
                            isvalidPok = false;
                            moveFileError(path, fileName);
                            break;
                        }

                        barcodes.Add(node.Attributes["location"].Value, node.InnerText);
                        addLine(">>>>>> Serial: " + node.InnerText + " <<<<<<<<");
                    }
                    if (!isvalidPok)
                    {
                        //m_listProcessFiles.Add(log.Name);
                        m_laserM.setTaskToLM(LM.se_id, "MARKING_COMPLETE", "ERROR EN POKAYOKE NO SE LIBERO LA PCB.");
                        return;
                    }
                    else m_laserM.setTaskToLM(LM.se_id, "MARKING_COMPLETE", "TASKS COMPLETE.");
                }
                catch (Exception ex)
                {
                    addLine("Ocurrió el siguiente error: " + ex.Message);
                    return;
                }
                try
                {
                    addLine_PF("Release");
                    if (ReleaseCgs(m_program, m_dj.Review, m_dj.Route, m_dj.BatchId, m_dj.BatchQty, panelId, barcodes))
                    {
                        try
                        {
                            panel = Convert.ToInt32(m_dbMitsubishi.getMaxPanel().First().PanelId);
                        }
                        catch (Exception ex)
                        {
                            addLine("Ocurrió el siguiente error: " + ex.Message);
                        }
                        try
                        {
                            if (m_dj.IsMit)
                                if(isXA)
                                    InsertSerials(barcodes, panel, c, s);
                            else
                                    InsertSerialsXB(barcodes, panel, c, s);
                        }
                        catch (Exception ex)
                        {
                            addLine("Ocurrió el siguiente error: " + ex.Message);
                        }

                        addLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>> >>>>>>>>>>> <<<<<<<<<<<< <<<<<<<<<<<<<<<<<<<<<<<<<<");
                        addLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>> Pieza liberada con éxito <<<<<<<<<<<<<<<<<<<<<<<<<<<");
                        addLine(">>>>>>>>>>>>>>>>>>>>>>>>>> >>>>>>>>>>> <<<<<<<<<<<< <<<<<<<<<<<<<<<<<<<<<<<<<<\n");
                        setSuccess("Pieza liberada con éxito");
                        moveFile(path, fileName);
                        //m_listProcessFiles.Add(log.Name);
                        addLine_PF("Se proceso archivo " + fileName);
                        logger.Info("Se proceso archivo " + fileName);
                    }
                    else
                    {
                        moveFileError(path, fileName);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    addLine("Ocurrió el siguiente error: " + ex.Message);
                    return;
                }

                //addLine_PF("Se proceso archivo " + fileName);
                
            }
        }
    }
}
