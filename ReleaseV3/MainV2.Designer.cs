namespace ReleaseMonitorV4
{
    partial class MainV2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbDJS = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Model = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tb_pokayoke = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_program = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_route = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_revision = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txt_message = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.t_message = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.b_start = new System.Windows.Forms.Button();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDJS)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDJS
            // 
            this.cmbDJS.DropDownWidth = 121;
            this.cmbDJS.Location = new System.Drawing.Point(21, 20);
            this.cmbDJS.Name = "cmbDJS";
            this.cmbDJS.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.cmbDJS.Size = new System.Drawing.Size(121, 21);
            this.cmbDJS.TabIndex = 0;
            this.cmbDJS.Text = "Select a Dj...";
            this.cmbDJS.SelectedIndexChanged += new System.EventHandler(this.cmbDJS_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tb_Model);
            this.panel1.Controls.Add(this.tb_pokayoke);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_program);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_route);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_qty);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_revision);
            this.panel1.Location = new System.Drawing.Point(217, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 322);
            this.panel1.TabIndex = 14;
            // 
            // tb_Model
            // 
            this.tb_Model.Location = new System.Drawing.Point(121, 15);
            this.tb_Model.Name = "tb_Model";
            this.tb_Model.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.tb_Model.ReadOnly = true;
            this.tb_Model.Size = new System.Drawing.Size(237, 23);
            this.tb_Model.TabIndex = 15;
            // 
            // tb_pokayoke
            // 
            this.tb_pokayoke.Font = new System.Drawing.Font("Humnst777 Cn BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pokayoke.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tb_pokayoke.Location = new System.Drawing.Point(120, 115);
            this.tb_pokayoke.MaxLength = 8;
            this.tb_pokayoke.Multiline = true;
            this.tb_pokayoke.Name = "tb_pokayoke";
            this.tb_pokayoke.ReadOnly = true;
            this.tb_pokayoke.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_pokayoke.Size = new System.Drawing.Size(308, 69);
            this.tb_pokayoke.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Humnst777 Cn BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(47, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Pokayoke:";
            // 
            // tb_program
            // 
            this.tb_program.Font = new System.Drawing.Font("Humnst777 Cn BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_program.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tb_program.Location = new System.Drawing.Point(121, 201);
            this.tb_program.MaxLength = 8;
            this.tb_program.Name = "tb_program";
            this.tb_program.ReadOnly = true;
            this.tb_program.Size = new System.Drawing.Size(237, 22);
            this.tb_program.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Humnst777 Cn BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(53, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Program:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Humnst777 Cn BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Humnst777 Cn BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(67, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Route:";
            // 
            // tb_route
            // 
            this.tb_route.Font = new System.Drawing.Font("Humnst777 Cn BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_route.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tb_route.Location = new System.Drawing.Point(121, 49);
            this.tb_route.Name = "tb_route";
            this.tb_route.ReadOnly = true;
            this.tb_route.Size = new System.Drawing.Size(307, 22);
            this.tb_route.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Humnst777 Cn BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(80, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qty:";
            // 
            // tb_qty
            // 
            this.tb_qty.Font = new System.Drawing.Font("Humnst777 Cn BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qty.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tb_qty.Location = new System.Drawing.Point(121, 240);
            this.tb_qty.MaxLength = 5;
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.ReadOnly = true;
            this.tb_qty.Size = new System.Drawing.Size(61, 22);
            this.tb_qty.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Humnst777 Cn BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(60, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Review:";
            // 
            // tb_revision
            // 
            this.tb_revision.Font = new System.Drawing.Font("Humnst777 Cn BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_revision.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tb_revision.Location = new System.Drawing.Point(121, 82);
            this.tb_revision.Name = "tb_revision";
            this.tb_revision.ReadOnly = true;
            this.tb_revision.Size = new System.Drawing.Size(42, 22);
            this.tb_revision.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_message,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txt_message
            // 
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.Visible = false;
            // 
            // t_message
            // 
            this.t_message.Interval = 3000;
            this.t_message.Tick += new System.EventHandler(this.t_message_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(13, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Log path";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(86, 20);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(239, 23);
            this.metroTextBox1.TabIndex = 18;
            this.metroTextBox1.UseSelectable = true;
            // 
            // b_start
            // 
            this.b_start.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_start.ForeColor = System.Drawing.Color.DarkGreen;
            this.b_start.Location = new System.Drawing.Point(331, 15);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(131, 33);
            this.b_start.TabIndex = 17;
            this.b_start.Text = "START";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cmbDJS);
            this.kryptonPanel1.Location = new System.Drawing.Point(33, 39);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonAlternate;
            this.kryptonPanel1.Size = new System.Drawing.Size(162, 57);
            this.kryptonPanel1.TabIndex = 20;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.metroLabel1);
            this.kryptonPanel2.Controls.Add(this.metroTextBox1);
            this.kryptonPanel2.Controls.Add(this.b_start);
            this.kryptonPanel2.Location = new System.Drawing.Point(217, 367);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonAlternate;
            this.kryptonPanel2.Size = new System.Drawing.Size(473, 65);
            this.kryptonPanel2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ReleaseMonitorV4.Properties.Resources.miticon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // MainV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::ReleaseMonitorV4.Properties.Resources.back1;
            this.BackMaxSize = 800;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MainV2";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainV2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDJS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbDJS;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_Model;
        private System.Windows.Forms.TextBox tb_pokayoke;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_program;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_route;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_qty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_revision;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txt_message;
        private System.Windows.Forms.Timer t_message;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Button b_start;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}