using ComponentFactory.Krypton.Toolkit;
using MetroFramework.Forms;
using ReleaseMonitorV4.Class;
//using ReleaseMonitorV4.Classes;
using ReleaseMonitorV4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReleaseMonitorV4
{
    public partial class MainV2 : MetroForm
    {
        Thread splashthread;
        private siixsem_sys_lblPrint_dbEntities m_db;
        private siixsem_main_dbEntities m_dbMain;
        private siixsem_laser_traceability_dbEntities m_dbTraceability;
        private static siixsem_mits_projectEntities m_dbMitsubishi;
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        bool m_isMit = false;
        String pair_fg_name = "";
        CDJ m_dj;
        String haspanel;
        String numBoards = "";

        String datIni = "";
        String datFin = "";
        CCogiscanCGS m_db2;
        
        public MainV2()
        {
            InitializeComponent();
            m_db = new siixsem_sys_lblPrint_dbEntities();
            m_db2 = new CCogiscanCGS();
            m_dbMain = new siixsem_main_dbEntities();
            m_dbTraceability = new siixsem_laser_traceability_dbEntities();
            m_dbMitsubishi = new siixsem_mits_projectEntities();
        }

        private void MainV2_Load(object sender, EventArgs e)
        {
            splashthread = new Thread(new ThreadStart(SplashScreen.ShowSplashScreen));
            splashthread.IsBackground = true;
            splashthread.Start();
            DateTime date = DateTime.Now;
            int month;
            int year = date.Year;
            //if (date.Month > 1)
            //    month = date.Month - 1;
            if (date.Month > 2)
                month = date.Month - 2;
            else
            {
                month = 12;
                year = date.Year - 1;
            }
            datIni = month.ToString() + "/01/" + year.ToString();
            datFin = date.Month.ToString() + "/" + date.Day.ToString() + "/" + date.Year.ToString();

            try
            {
                //var AllModels = m_db.ge|(datIni, datFin);
                var allmodels = m_db.getLaserDjs(datIni, datFin);
                cmbDJS.DataSource = allmodels.ToList();
                cmbDJS.DisplayMember = "DJ_GROUP";
                cmbDJS.ValueMember = "PAIR_FG_NAME";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.InnerException.Message);
                    }
            //metroTextBox1.Text = "D:\\SysLogs\\ToRelease\\";
            metroTextBox1.Text = m_dbMitsubishi.getReleasePath().First().PATHPROD;
            SplashScreen.CloseSplashScreen();
            //this.TopMost = true;

        }

        private void cmbDJS_SelectedIndexChanged(object sender, EventArgs e)
        {
            CModelInfo model = new CModelInfo();
            
            //toolStripProgressBar1.Visible = true;
            //this.TopMost = false;
            splashthread = new Thread(new ThreadStart(SplashScreen.ShowSplashScreen));
            splashthread.IsBackground = true;
            splashthread.Start();
            try
            {
                KryptonComboBox cmb = (KryptonComboBox)sender;
                int selectedIndex = cmb.SelectedIndex;
                tb_Model.Text = (String)cmb.SelectedValue;

                model = m_db2.getInfoModel(tb_Model.Text);

                tb_qty.Text = numBoards = model.NUMBER_BOARDS.ToString();
                tb_pokayoke.Text = model.POKAYOKE;
                tb_route.Text = model.ROUTE;
                tb_revision.Text = model.REV;
                tb_program.Text = model.FG_NAME;
                haspanel = model.HAS_PANEL;

                m_isMit = model.FG_NAME.Contains("N925") == true ? true : false;

                getIdmodelByDJGroup_Result modelDetail = m_db.getIdmodelByDJGroup(cmbDJS.Text).First();

                if(modelDetail != null)
                {
                    m_db.getQtyDjGrp(Convert.ToInt32(modelDetail.DJ_GROUP), Convert.ToInt32(modelDetail.DJ_NO), modelDetail.ID_MODEL);
                    int START_QUANTITY = Convert.ToInt32(m_db.getQtyMitByDJGroup(modelDetail.DJ_GROUP).First().START_QUANTITY);
                    int plusPanel = haspanel == "Y" ? START_QUANTITY : 0;
                    tb_qty.Text = (START_QUANTITY * Convert.ToInt32(tb_qty.Text) + plusPanel).ToString();
                    //tb_qty.Text = "160";
                }

            }
            catch (Exception ex)
            {
                statusStrip1.BackColor = Color.Red;
                statusStrip1.ForeColor = Color.White;
                txt_message.Text = ex.Message;
                t_message.Start();
                //id_value = Convert.ToInt32(cmbDJS.SelectedValue);
            }
            //toolStripProgressBar1.Visible = false;
            SplashScreen.CloseSplashScreen();
            //this.TopMost = true;

            //tb_Model.Text = Convert.ToString(row1["ASSEMBLY_DESC"]);

        }

        private void t_message_Tick(object sender, EventArgs e)
        {
            statusStrip1.BackColor = Color.LightGray;
            txt_message.Text = "";
            t_message.Stop();
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbDJS.Text))
            {
                MessageBox.Show("Captura la DJ.");
                cmbDJS.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tb_qty.Text))
            {
                MessageBox.Show("Captura la cantidad.");
                tb_qty.Focus();
                return;
            }

            m_dj = new CDJ(tb_revision.Text, tb_route.Text, cmbDJS.Text, Convert.ToInt32(tb_qty.Text), m_isMit);

            existDJGroupOr_Result res = m_db.existDJGroupOr(cmbDJS.Text, pair_fg_name).First();

            if (res == null || res.COUNT < 0)
            {
                MessageBox.Show("El número de grupo no existe.");
                return;
            }

            int existDjSQL = m_db.existDjGroup(cmbDJS.Text).First().RESULT;

            if (existDjSQL == -1)
            {
                m_db.insertSpec3(1, 1, 123, 1, 1, Convert.ToInt32(tb_qty.Text), 0, 0, 0, cmbDJS.Text, pair_fg_name, DateTime.Now, 0, cmbDJS.Text);
                logger.Info("Se inserto el numero de grupo: " + cmbDJS.Text);
            }

            Form2 analize_frm = new Form2(tb_pokayoke.Text, tb_program.Text, m_dj, haspanel, numBoards);
            this.Hide();
            analize_frm.ShowDialog();

            this.Show();
        }
    }
}
