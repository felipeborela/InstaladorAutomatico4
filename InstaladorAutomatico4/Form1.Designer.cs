namespace InstaladorAutomatico4
{
    partial class principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cb_ccleaner = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_markall = new System.Windows.Forms.Button();
            this.rd_netagent = new System.Windows.Forms.RadioButton();
            this.rd_avast = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_klite = new System.Windows.Forms.CheckBox();
            this.cb_winrar = new System.Windows.Forms.CheckBox();
            this.cb_thunderbird = new System.Windows.Forms.CheckBox();
            this.cb_spark = new System.Windows.Forms.CheckBox();
            this.cb_libreoffice = new System.Windows.Forms.CheckBox();
            this.cb_fusioninventory = new System.Windows.Forms.CheckBox();
            this.cb_cutepdf = new System.Windows.Forms.CheckBox();
            this.cb_chrome = new System.Windows.Forms.CheckBox();
            this.cb_anydesk = new System.Windows.Forms.CheckBox();
            this.cb_ammyy = new System.Windows.Forms.CheckBox();
            this.cb_teamviewer = new System.Windows.Forms.CheckBox();
            this.cb_ultravnc = new System.Windows.Forms.CheckBox();
            this.cb_radmin = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cb_globus = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(413, 272);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.cb_globus);
            this.tabPage1.Controls.Add(this.cb_ccleaner);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.bt_markall);
            this.tabPage1.Controls.Add(this.rd_netagent);
            this.tabPage1.Controls.Add(this.rd_avast);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cb_klite);
            this.tabPage1.Controls.Add(this.cb_winrar);
            this.tabPage1.Controls.Add(this.cb_thunderbird);
            this.tabPage1.Controls.Add(this.cb_spark);
            this.tabPage1.Controls.Add(this.cb_libreoffice);
            this.tabPage1.Controls.Add(this.cb_fusioninventory);
            this.tabPage1.Controls.Add(this.cb_cutepdf);
            this.tabPage1.Controls.Add(this.cb_chrome);
            this.tabPage1.Controls.Add(this.cb_anydesk);
            this.tabPage1.Controls.Add(this.cb_ammyy);
            this.tabPage1.Controls.Add(this.cb_teamviewer);
            this.tabPage1.Controls.Add(this.cb_ultravnc);
            this.tabPage1.Controls.Add(this.cb_radmin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(405, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Softwares";
            // 
            // cb_ccleaner
            // 
            this.cb_ccleaner.AutoSize = true;
            this.cb_ccleaner.Checked = true;
            this.cb_ccleaner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ccleaner.Location = new System.Drawing.Point(124, 22);
            this.cb_ccleaner.Name = "cb_ccleaner";
            this.cb_ccleaner.Size = new System.Drawing.Size(69, 17);
            this.cb_ccleaner.TabIndex = 21;
            this.cb_ccleaner.Text = "CCleaner";
            this.cb_ccleaner.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Desmarcar todos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bt_markall
            // 
            this.bt_markall.Location = new System.Drawing.Point(18, 176);
            this.bt_markall.Name = "bt_markall";
            this.bt_markall.Size = new System.Drawing.Size(110, 23);
            this.bt_markall.TabIndex = 19;
            this.bt_markall.Text = "Marcar todos";
            this.bt_markall.UseVisualStyleBackColor = true;
            this.bt_markall.Click += new System.EventHandler(this.button2_Click);
            // 
            // rd_netagent
            // 
            this.rd_netagent.AutoSize = true;
            this.rd_netagent.Checked = true;
            this.rd_netagent.Location = new System.Drawing.Point(244, 91);
            this.rd_netagent.Name = "rd_netagent";
            this.rd_netagent.Size = new System.Drawing.Size(125, 17);
            this.rd_netagent.TabIndex = 18;
            this.rd_netagent.TabStop = true;
            this.rd_netagent.Text = "Kaspersky Net Agent";
            this.rd_netagent.UseVisualStyleBackColor = true;
            this.rd_netagent.CheckedChanged += new System.EventHandler(this.rd_netagent_CheckedChanged);
            // 
            // rd_avast
            // 
            this.rd_avast.AutoSize = true;
            this.rd_avast.Location = new System.Drawing.Point(244, 113);
            this.rd_avast.Name = "rd_avast";
            this.rd_avast.Size = new System.Drawing.Size(52, 17);
            this.rd_avast.TabIndex = 17;
            this.rd_avast.Text = "Avast";
            this.rd_avast.UseVisualStyleBackColor = true;
            this.rd_avast.CheckedChanged += new System.EventHandler(this.rd_avast_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "INSTALAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_klite
            // 
            this.cb_klite.AutoSize = true;
            this.cb_klite.Checked = true;
            this.cb_klite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_klite.Location = new System.Drawing.Point(244, 45);
            this.cb_klite.Name = "cb_klite";
            this.cb_klite.Size = new System.Drawing.Size(112, 17);
            this.cb_klite.TabIndex = 15;
            this.cb_klite.Text = "KLite Codec Pack";
            this.cb_klite.UseVisualStyleBackColor = true;
            // 
            // cb_winrar
            // 
            this.cb_winrar.AutoSize = true;
            this.cb_winrar.Checked = true;
            this.cb_winrar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_winrar.Location = new System.Drawing.Point(244, 22);
            this.cb_winrar.Name = "cb_winrar";
            this.cb_winrar.Size = new System.Drawing.Size(68, 17);
            this.cb_winrar.TabIndex = 14;
            this.cb_winrar.Text = "WinRAR";
            this.cb_winrar.UseVisualStyleBackColor = true;
            // 
            // cb_thunderbird
            // 
            this.cb_thunderbird.AutoSize = true;
            this.cb_thunderbird.Checked = true;
            this.cb_thunderbird.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_thunderbird.Location = new System.Drawing.Point(124, 138);
            this.cb_thunderbird.Name = "cb_thunderbird";
            this.cb_thunderbird.Size = new System.Drawing.Size(83, 17);
            this.cb_thunderbird.TabIndex = 13;
            this.cb_thunderbird.Text = "Thunderbird";
            this.cb_thunderbird.UseVisualStyleBackColor = true;
            // 
            // cb_spark
            // 
            this.cb_spark.AutoSize = true;
            this.cb_spark.Checked = true;
            this.cb_spark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_spark.Location = new System.Drawing.Point(124, 115);
            this.cb_spark.Name = "cb_spark";
            this.cb_spark.Size = new System.Drawing.Size(54, 17);
            this.cb_spark.TabIndex = 12;
            this.cb_spark.Text = "Spark";
            this.cb_spark.UseVisualStyleBackColor = true;
            // 
            // cb_libreoffice
            // 
            this.cb_libreoffice.AutoSize = true;
            this.cb_libreoffice.Checked = true;
            this.cb_libreoffice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_libreoffice.Location = new System.Drawing.Point(18, 138);
            this.cb_libreoffice.Name = "cb_libreoffice";
            this.cb_libreoffice.Size = new System.Drawing.Size(77, 17);
            this.cb_libreoffice.TabIndex = 11;
            this.cb_libreoffice.Text = "LibreOffice";
            this.cb_libreoffice.UseVisualStyleBackColor = true;
            // 
            // cb_fusioninventory
            // 
            this.cb_fusioninventory.AutoSize = true;
            this.cb_fusioninventory.Checked = true;
            this.cb_fusioninventory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_fusioninventory.Location = new System.Drawing.Point(124, 92);
            this.cb_fusioninventory.Name = "cb_fusioninventory";
            this.cb_fusioninventory.Size = new System.Drawing.Size(104, 17);
            this.cb_fusioninventory.TabIndex = 10;
            this.cb_fusioninventory.Text = "Fusion Inventory";
            this.cb_fusioninventory.UseVisualStyleBackColor = true;
            // 
            // cb_cutepdf
            // 
            this.cb_cutepdf.AutoSize = true;
            this.cb_cutepdf.Checked = true;
            this.cb_cutepdf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_cutepdf.Location = new System.Drawing.Point(124, 69);
            this.cb_cutepdf.Name = "cb_cutepdf";
            this.cb_cutepdf.Size = new System.Drawing.Size(69, 17);
            this.cb_cutepdf.TabIndex = 9;
            this.cb_cutepdf.Text = "CutePDF";
            this.cb_cutepdf.UseVisualStyleBackColor = true;
            // 
            // cb_chrome
            // 
            this.cb_chrome.AutoSize = true;
            this.cb_chrome.Checked = true;
            this.cb_chrome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_chrome.Location = new System.Drawing.Point(124, 45);
            this.cb_chrome.Name = "cb_chrome";
            this.cb_chrome.Size = new System.Drawing.Size(99, 17);
            this.cb_chrome.TabIndex = 8;
            this.cb_chrome.Text = "Google Chrome";
            this.cb_chrome.UseVisualStyleBackColor = true;
            // 
            // cb_anydesk
            // 
            this.cb_anydesk.AutoSize = true;
            this.cb_anydesk.Checked = true;
            this.cb_anydesk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_anydesk.Location = new System.Drawing.Point(18, 115);
            this.cb_anydesk.Name = "cb_anydesk";
            this.cb_anydesk.Size = new System.Drawing.Size(69, 17);
            this.cb_anydesk.TabIndex = 4;
            this.cb_anydesk.Text = "AnyDesk";
            this.cb_anydesk.UseVisualStyleBackColor = true;
            // 
            // cb_ammyy
            // 
            this.cb_ammyy.AutoSize = true;
            this.cb_ammyy.Checked = true;
            this.cb_ammyy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ammyy.Location = new System.Drawing.Point(18, 92);
            this.cb_ammyy.Name = "cb_ammyy";
            this.cb_ammyy.Size = new System.Drawing.Size(59, 17);
            this.cb_ammyy.TabIndex = 3;
            this.cb_ammyy.Text = "Ammyy";
            this.cb_ammyy.UseVisualStyleBackColor = true;
            // 
            // cb_teamviewer
            // 
            this.cb_teamviewer.AutoSize = true;
            this.cb_teamviewer.Checked = true;
            this.cb_teamviewer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_teamviewer.Location = new System.Drawing.Point(18, 68);
            this.cb_teamviewer.Name = "cb_teamviewer";
            this.cb_teamviewer.Size = new System.Drawing.Size(85, 17);
            this.cb_teamviewer.TabIndex = 2;
            this.cb_teamviewer.Text = "TeamViewer";
            this.cb_teamviewer.UseVisualStyleBackColor = true;
            // 
            // cb_ultravnc
            // 
            this.cb_ultravnc.AutoSize = true;
            this.cb_ultravnc.Checked = true;
            this.cb_ultravnc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ultravnc.Location = new System.Drawing.Point(18, 45);
            this.cb_ultravnc.Name = "cb_ultravnc";
            this.cb_ultravnc.Size = new System.Drawing.Size(70, 17);
            this.cb_ultravnc.TabIndex = 1;
            this.cb_ultravnc.Text = "UltraVNC";
            this.cb_ultravnc.UseVisualStyleBackColor = true;
            // 
            // cb_radmin
            // 
            this.cb_radmin.AutoSize = true;
            this.cb_radmin.Checked = true;
            this.cb_radmin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_radmin.Location = new System.Drawing.Point(18, 22);
            this.cb_radmin.Name = "cb_radmin";
            this.cb_radmin.Size = new System.Drawing.Size(62, 17);
            this.cb_radmin.TabIndex = 0;
            this.cb_radmin.Text = "Radmin";
            this.cb_radmin.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(405, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registros";
            // 
            // cb_globus
            // 
            this.cb_globus.AutoSize = true;
            this.cb_globus.Checked = true;
            this.cb_globus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_globus.Location = new System.Drawing.Point(244, 68);
            this.cb_globus.Name = "cb_globus";
            this.cb_globus.Size = new System.Drawing.Size(59, 17);
            this.cb_globus.TabIndex = 22;
            this.cb_globus.Text = "Globus";
            this.cb_globus.UseVisualStyleBackColor = true;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 272);
            this.Controls.Add(this.tabControl1);
            this.Name = "principal";
            this.Text = "Instalador Automático v4.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cb_radmin;
        private System.Windows.Forms.CheckBox cb_anydesk;
        private System.Windows.Forms.CheckBox cb_ammyy;
        private System.Windows.Forms.CheckBox cb_teamviewer;
        private System.Windows.Forms.CheckBox cb_ultravnc;
        private System.Windows.Forms.CheckBox cb_chrome;
        private System.Windows.Forms.CheckBox cb_libreoffice;
        private System.Windows.Forms.CheckBox cb_fusioninventory;
        private System.Windows.Forms.CheckBox cb_cutepdf;
        private System.Windows.Forms.CheckBox cb_spark;
        private System.Windows.Forms.CheckBox cb_klite;
        private System.Windows.Forms.CheckBox cb_winrar;
        private System.Windows.Forms.CheckBox cb_thunderbird;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rd_netagent;
        private System.Windows.Forms.RadioButton rd_avast;
        private System.Windows.Forms.Button bt_markall;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cb_ccleaner;
        private System.Windows.Forms.CheckBox cb_globus;
    }
}

