namespace ReleaseMonitorV4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.m_console = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timerWatch = new System.Windows.Forms.Timer(this.components);
            this.advancedFileSystemWatcher1 = new SoftMade.IO.AdvancedFileSystemWatcher();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.m_processFiles = new System.Windows.Forms.RichTextBox();
            this.lsInfo = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.advancedFileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsInfo.Panel)).BeginInit();
            this.lsInfo.Panel.SuspendLayout();
            this.lsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.DisplayIcon = false;
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBox1.ForeColor = System.Drawing.Color.White;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(389, 459);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(606, 29);
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseCustomBackColor = true;
            this.metroTextBox1.UseCustomForeColor = true;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(362, 46);
            this.metroProgressBar1.MarqueeAnimationSpeed = 200;
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(303, 10);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroProgressBar1.TabIndex = 8;
            // 
            // m_console
            // 
            this.m_console.BackColor = System.Drawing.Color.Black;
            this.m_console.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_console.ForeColor = System.Drawing.Color.White;
            this.m_console.Location = new System.Drawing.Point(26, 73);
            this.m_console.Name = "m_console";
            this.m_console.Size = new System.Drawing.Size(969, 180);
            this.m_console.TabIndex = 7;
            this.m_console.Text = "";
            this.m_console.TextChanged += new System.EventHandler(this.m_console_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(381, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Analizando Logs XML...";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(100, 465);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.Size = new System.Drawing.Size(274, 23);
            this.metroTextBox2.TabIndex = 10;
            this.metroTextBox2.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(26, 466);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Log path";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // timerWatch
            // 
            this.timerWatch.Interval = 60000;
            this.timerWatch.Tick += new System.EventHandler(this.timerWatch_Tick);
            // 
            // advancedFileSystemWatcher1
            // 
            this.advancedFileSystemWatcher1.EnableRaisingEvents = true;
            this.advancedFileSystemWatcher1.Filter = "*.xml";
            this.advancedFileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.advancedFileSystemWatcher1.SynchronizingObject = this;
            this.advancedFileSystemWatcher1.Changed += new System.EventHandler<SoftMade.IO.FileSystemEventArgs>(this.OnChanged);
            this.advancedFileSystemWatcher1.Created += new System.EventHandler<SoftMade.IO.FileSystemEventArgs>(this.OnChanged);
            this.advancedFileSystemWatcher1.Renamed += new System.EventHandler<SoftMade.IO.FileSystemEventArgs>(this.OnChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(117, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 15);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "metroLabel2";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(117, 43);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 15);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "metroLabel3";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // m_processFiles
            // 
            this.m_processFiles.BackColor = System.Drawing.Color.Black;
            this.m_processFiles.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_processFiles.ForeColor = System.Drawing.Color.White;
            this.m_processFiles.Location = new System.Drawing.Point(23, 494);
            this.m_processFiles.Name = "m_processFiles";
            this.m_processFiles.Size = new System.Drawing.Size(972, 54);
            this.m_processFiles.TabIndex = 20;
            this.m_processFiles.Text = "";
            this.m_processFiles.TextChanged += new System.EventHandler(this.m_processFiles_TextChanged);
            // 
            // lsInfo
            // 
            this.lsInfo.CaptionEdge = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left;
            this.lsInfo.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lsInfo.Location = new System.Drawing.Point(23, 270);
            this.lsInfo.Name = "lsInfo";
            this.lsInfo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            // 
            // lsInfo.Panel
            // 
            this.lsInfo.Panel.Controls.Add(this.kryptonLabel2);
            this.lsInfo.Panel.Controls.Add(this.kryptonLabel1);
            this.lsInfo.Panel.Controls.Add(this.metroLabel7);
            this.lsInfo.Panel.Controls.Add(this.metroLabel6);
            this.lsInfo.Panel.Controls.Add(this.metroLabel5);
            this.lsInfo.Panel.Controls.Add(this.metroLabel4);
            this.lsInfo.Panel.Controls.Add(this.metroLabel2);
            this.lsInfo.Panel.Controls.Add(this.metroLabel3);
            this.lsInfo.Size = new System.Drawing.Size(972, 172);
            this.lsInfo.TabIndex = 21;
            this.lsInfo.Values.Heading = "";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(41, 50);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Orientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left;
            this.kryptonLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kryptonLabel2.Size = new System.Drawing.Size(21, 164);
            this.kryptonLabel2.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 25;
            this.kryptonLabel2.Values.Text = "MODEL TO MARK IN";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(16, 16);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Orientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left;
            this.kryptonLabel1.Size = new System.Drawing.Size(20, 131);
            this.kryptonLabel1.TabIndex = 24;
            this.kryptonLabel1.Values.Text = "MODEL TO MARK IN";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.Black;
            this.metroLabel7.Location = new System.Drawing.Point(117, 135);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(78, 15);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel7.TabIndex = 23;
            this.metroLabel7.Text = "metroLabel7";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.Black;
            this.metroLabel6.Location = new System.Drawing.Point(117, 112);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(78, 15);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "metroLabel6";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.Black;
            this.metroLabel5.Location = new System.Drawing.Point(117, 89);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 15);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "metroLabel5";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(117, 66);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 15);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "metroLabel4";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::ReleaseMonitorV4.Properties.Resources.back1;
            this.BackMaxSize = 1100;
            this.ClientSize = new System.Drawing.Size(1021, 571);
            this.Controls.Add(this.lsInfo);
            this.Controls.Add(this.m_processFiles);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.m_console);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedFileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsInfo.Panel)).EndInit();
            this.lsInfo.Panel.ResumeLayout(false);
            this.lsInfo.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsInfo)).EndInit();
            this.lsInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.RichTextBox m_console;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer timerWatch;
        private SoftMade.IO.AdvancedFileSystemWatcher advancedFileSystemWatcher1;
        private System.Windows.Forms.RichTextBox m_processFiles;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox lsInfo;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}