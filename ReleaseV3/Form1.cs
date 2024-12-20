using MetroFramework.Forms;
using ReleaseMonitorV4.Class;
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
    public partial class Form1 : MetroForm
    {
        Thread splashthread;
        private siixsem_main_dbEntities m_dbMain;
        private siixsem_laser_traceability_dbEntities m_dbTraceability;
        private siixsem_sys_lblPrint_dbEntities m_db;
        private static siixsem_mits_projectEntities m_dbMitsubishi;
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        String haspanel;
        bool m_isMit = false;
        String pair_fg_name = "";
        CDJ m_dj;
        public Form1()
        {
            InitializeComponent();
            m_dbMain = new siixsem_main_dbEntities();
            m_dbTraceability = new siixsem_laser_traceability_dbEntities();
            m_db = new siixsem_sys_lblPrint_dbEntities();
            m_dbMitsubishi = new siixsem_mits_projectEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splashthread = new Thread(new ThreadStart(SplashScreen.ShowSplashScreen));
            splashthread.IsBackground = true;
            splashthread.Start();

            var allmodels = m_dbMain.getLaserModels();
            cmb_model.DataSource = allmodels;
            cmb_model.DisplayMember = "se_description";
            cmb_model.ValueMember = "se_id_model";
            tb_route.Enabled = false;
            tb_revision.Enabled = false;
            tb_program.Enabled = false;
            cmb_model.SelectedIndex = 0;

            metroTextBox1.Text = m_dbMitsubishi.getReleasePath().First().PATHPROD;

            SplashScreen.CloseSplashScreen();
            this.TopMost = true;
            

        }

        private void cmb_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_route.Text = "";
            tb_revision.Text = "";
            int id_value = 0;

            try
            {
                id_value = Convert.ToInt32(((getLaserModels_Result)cmb_model.SelectedValue).se_id_model);
            }
            catch (Exception ex)
            {
                id_value = Convert.ToInt32(cmb_model.SelectedValue);
            }

            try
            {
                var cgsdetails = m_dbTraceability.getCgsDetails(id_value).First();
                string cgs_route = cgsdetails.cgs_route;
                string cgs_revision = cgsdetails.cgs_revision;
                string cgs_pn = cgsdetails.cgs_pn;
                int cgsdetail_id = cgsdetails.id;
                tb_program.Text = cgsdetails.cgs_pn;
                tb_pokayoke.Text = cgsdetails.pokayoke;
                tb_route.Text = cgs_route;
                tb_revision.Text = cgs_revision;
                pair_fg_name = cgsdetails.pair_fg_name;
                m_isMit = cgsdetails.isMit == 0 ? false : true;
                
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }   
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_djno.Text))
            {
                MessageBox.Show("Captura la DJ.");
                tb_djno.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tb_qty.Text))
            {
                MessageBox.Show("Captura la cantidad.");
                tb_qty.Focus();
                return;
            }

            m_dj = new CDJ(tb_revision.Text, tb_route.Text, tb_djno.Text, Convert.ToInt32(tb_qty.Text), m_isMit);

            existDJGroupOr_Result res = m_db.existDJGroupOr(tb_djno.Text, pair_fg_name).First();

            if (res == null || res.COUNT < 0)
            {
                MessageBox.Show("El número de grupo no existe.");
                return;
            }

            if (res.pair_fg_name != pair_fg_name)
            {
                MessageBox.Show("La dj no corresponde con el modelo selecionado.");
                return;
            }
            //this.Hide();

            int existDjSQL = m_db.existDjGroup(tb_djno.Text).First().RESULT;

            if (existDjSQL == -1)
            {
                m_db.insertSpec3(1, 1, 123, 1, 1, Convert.ToInt32(tb_qty.Text), 0, 0, 0, tb_djno.Text, pair_fg_name, DateTime.Now, 0, tb_djno.Text);
                logger.Info("Se inserto el numero de grupo: " + tb_djno.Text);
            }

            Form2 analize_frm = new Form2(tb_pokayoke.Text, tb_program.Text, m_dj,haspanel,"");
            this.Hide();
            analize_frm.ShowDialog();

            this.Show();
        }
    }
}
