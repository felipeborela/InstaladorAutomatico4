using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;


namespace InstaladorAutomatico4
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        string radminInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\Radmin\InstalarRadmin.bat";
        string radminDestPath = @"C:\TI\Radmin\";
        string radminInstaller_DestPath = @"C:\TI\Radmin\InstalarRadmin.bat";

        string ultravncInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\UltraVNC\InstalarUltraVNC.bat";
        string ultravncDestPath = @"C:\TI\UltraVNC\";
        string ultravncInstaller_DestPath = @"C:\TI\UltraVNC\InstalarUltraVNC.bat";

        string teamviewerInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\TeamViewer\InstalarTeamViewer.bat";
        string teamviewerDestPath = @"C:\TI\TeamViewer\";
        string teamviewerInstaller_DestPath = @"C:\TI\TeamViewer\InstalarTeamViewer.bat";

        string ammyyInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\Ammyy\InstalarAmmyy.bat";
        string ammyyDestPath = @"C:\TI\Ammyy\";
        string ammyyInstaller_DestPath = @"C:\TI\ammyy\InstalarAmmyy.bat";

        string anydeskInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\Anydesk\InstalarAnydesk.bat";
        string anydeskDestPath = @"C:\TI\Anydesk\";
        string anydeskInstaller_DestPath = @"C:\TI\Anydesk\InstalarAnydesk.bat";

        string libreofficeInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\LibreOffice\InstalarLibreOffice.bat";
        string libreofficeDestPath = @"C:\TI\LibreOffice\";
        string libreofficeInstaller_DestPath = @"C:\TI\Libreoffice\InstalarLibreOffice.bat";

        string ccleanerInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\CCleaner\InstalarCCleaner.bat";
        string ccleanerDestPath = @"C:\TI\CCleaner\";
        string ccleanerInstaller_DestPath = @"C:\TI\CCleaner\InstalarCCleaner.bat";

        string chromeInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\Chrome\InstalarChrome.bat";
        string chromeDestPath = @"C:\TI\Chrome\";
        string chromeInstaller_DestPath = @"C:\TI\Chrome\InstalarChrome.bat";

        string cutepdfInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\CutePDF\InstalarCutePDF.bat";
        string cutepdfDestPath = @"C:\TI\CutePDF\";
        string cutepdfInstaller_DestPath = @"C:\TI\CutePDF\InstalarCutePDF.bat";

        string fusioninventoryInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\FusionInventory\InstalarFusionInventory.bat";
        string fusioninventoryDestPath = @"C:\TI\FusionInventory\";
        string fusioninventoryInstaller_DestPath = @"C:\TI\FusionInventory\InstalarFusionInventory.bat";

        string sparkInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\Spark\InstalarSpark.bat";
        string sparkDestPath = @"C:\TI\Spark\";
        string sparkInstaller_DestPath = @"C:\TI\Spark\InstalarSpark.bat";

        string thunderbirdInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\Thunderbird\InstalarThunderbird.bat";
        string thunderbirdDestPath = @"C:\TI\Thunderbird\";
        string thunderbirdInstaller_DestPath = @"C:\TI\Thunderbird\InstalarThunderbird.bat";

        string winrarInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\Winrar\InstalarWinrar.bat";
        string winrarDestPath = @"C:\TI\Winrar\";
        string winrarInstaller_DestPath = @"C:\TI\Winrar\InstalarWinrar.bat";

        string kliteInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\KLite\InstalarKLite.bat";
        string kliteDestPath = @"C:\TI\KLite\";
        string kliteInstaller_DestPath = @"C:\TI\KLite\InstalarKLite.bat";

        string globusInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\Globus\InstalarGlobus.bat";
        string globusDestPath = @"C:\TI\Globus\";
        string globusInstaller_DestPath = @"C:\TI\Globus\InstalarGlobus.bat";

        string avastInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\Avast\InstalarAvast.bat";
        string avastDestPath = @"C:\TI\Avast\";
        string avastInstaller_DestPath = @"C:\TI\Avast\InstalarAvast.bat";

        string netagentInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\NetAgent\InstalarNetAgent.bat";
        string netagentDestPath = @"C:\TI\NetAgent\";
        string netagentInstaller_DestPath = @"C:\TI\NetAgent\InstalarNetAgent.bat";

        int cbCounter = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int progressCounter = 0;
            string progressCounterString = progressCounter.ToString();

            
            if (cb_radmin.Checked)
            {
                if (File.Exists(radminInstaller_DestPath))
                {
                    System.Diagnostics.Process.Start(radminInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                    progressBar1.Value = progressBar1.Value + 10;
                }
                else
                {
                    Directory.CreateDirectory(radminDestPath);
                    System.IO.File.Copy(radminInstaller_SourcePath, radminInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(radminInstaller_DestPath);
                }
            }

            if (cb_ultravnc.Checked)
            {
                if (File.Exists(ultravncInstaller_DestPath))
                {
                    System.Diagnostics.Process.Start(ultravncInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                    progressBar1.Value = progressBar1.Value + 10;
                }
            else
                {
                    Directory.CreateDirectory(ultravncDestPath);
                    System.IO.File.Copy(ultravncInstaller_SourcePath, ultravncInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(ultravncInstaller_DestPath);
                }
            }

            if (cb_teamviewer.Checked)
            {
                if (File.Exists(teamviewerInstaller_DestPath))
                { 
                    System.Diagnostics.Process.Start(teamviewerInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(teamviewerDestPath);
                    System.IO.File.Copy(teamviewerInstaller_SourcePath, teamviewerInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(teamviewerInstaller_DestPath);
                }
            }
           
            if (cb_ammyy.Checked)
            {
                if (File.Exists(ammyyInstaller_DestPath))
                { 
                    System.Diagnostics.Process.Start(ammyyInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(ammyyDestPath);
                    System.IO.File.Copy(ammyyInstaller_SourcePath, ammyyInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(ammyyInstaller_DestPath);
                }
            }

            if (cb_anydesk.Checked)
            {
                if (File.Exists(anydeskInstaller_DestPath))
                { 
                    System.Diagnostics.Process.Start(anydeskInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(anydeskDestPath);
                    System.IO.File.Copy(anydeskInstaller_SourcePath, anydeskInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(anydeskInstaller_DestPath);
                }
            }

            if (cb_libreoffice.Checked)
            {
                if (File.Exists(libreofficeInstaller_DestPath))
                { 
                    System.Diagnostics.Process.Start(libreofficeInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(libreofficeDestPath);
                    System.IO.File.Copy(libreofficeInstaller_SourcePath, libreofficeInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(libreofficeInstaller_DestPath);
                }
            }

            if (cb_ccleaner.Checked)
            {
                if (File.Exists(ccleanerInstaller_DestPath))
                {
                    System.Diagnostics.Process.Start(ccleanerInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(ccleanerDestPath);
                    System.IO.File.Copy(ccleanerInstaller_SourcePath, ccleanerInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(ccleanerInstaller_DestPath);
                }
            }

            if (cb_chrome.Checked)
            {
                if (File.Exists(chromeInstaller_DestPath))
                {
                    System.Diagnostics.Process.Start(chromeInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(chromeDestPath);
                    System.IO.File.Copy(chromeInstaller_SourcePath, chromeInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(chromeInstaller_DestPath);
                }
            }

            if (cb_cutepdf.Checked)
            {
                if (File.Exists(cutepdfInstaller_DestPath))
                {
                    System.Diagnostics.Process.Start(cutepdfInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(cutepdfDestPath);
                    System.IO.File.Copy(cutepdfInstaller_SourcePath, cutepdfInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(cutepdfInstaller_DestPath);
                }
            }

            if (cb_fusioninventory.Checked)
            {
                if (File.Exists(fusioninventoryInstaller_DestPath))
                {
                    System.Diagnostics.Process.Start(fusioninventoryInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(fusioninventoryDestPath);
                    System.IO.File.Copy(fusioninventoryInstaller_SourcePath, fusioninventoryInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(fusioninventoryInstaller_DestPath);
                }
            }

            if (cb_spark.Checked)
            {
                if (File.Exists(sparkInstaller_DestPath))
                {
                    System.Diagnostics.Process.Start(sparkInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(sparkDestPath);
                    System.IO.File.Copy(sparkInstaller_SourcePath, sparkInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(sparkInstaller_DestPath);
                }
            }

            if (cb_thunderbird.Checked)
            {
                if (File.Exists(thunderbirdInstaller_DestPath))
                {
                    System.Diagnostics.Process.Start(thunderbirdInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(thunderbirdDestPath);
                    System.IO.File.Copy(thunderbirdInstaller_SourcePath, thunderbirdInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(thunderbirdInstaller_DestPath);
                }
            }

            if (cb_winrar.Checked)
            {
                if (File.Exists(winrarInstaller_DestPath))
                {
                    System.Diagnostics.Process.Start(winrarInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(winrarDestPath);
                    System.IO.File.Copy(winrarInstaller_SourcePath, winrarInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(winrarInstaller_DestPath);
                }
            }

            if (cb_klite.Checked)
            {
                if (File.Exists(kliteInstaller_DestPath))
                {
                    System.Diagnostics.Process.Start(kliteInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(kliteDestPath);
                    System.IO.File.Copy(kliteInstaller_SourcePath, kliteInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(kliteInstaller_DestPath);
                }
            }

            if (cb_globus.Checked)
            {
                if (File.Exists(globusInstaller_DestPath))
                {
                    System.Diagnostics.Process.Start(globusInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(globusDestPath);
                    System.IO.File.Copy(globusInstaller_SourcePath, globusInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(globusInstaller_DestPath);
                }
            }

            if (cb_avast.Checked)
            {
                if (File.Exists(avastInstaller_DestPath))
                {
                    System.Diagnostics.Process.Start(avastInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(avastDestPath);
                    System.IO.File.Copy(avastInstaller_SourcePath, avastInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(avastInstaller_DestPath);
                }
            }

            if (cb_netgent.Checked)
            {
                if (File.Exists(netagentInstaller_DestPath))
                {
                    System.Diagnostics.Process.Start(netagentInstaller_DestPath);
                    cbCounter = cbCounter + 1;
                }
                else
                {
                    Directory.CreateDirectory(netagentDestPath);
                    System.IO.File.Copy(netagentInstaller_SourcePath, netagentInstaller_DestPath, true);
                    System.Diagnostics.Process.Start(netagentInstaller_DestPath);
                }
            }
            string cbCounterString = cbCounter.ToString();
            MessageBox.Show(cbCounterString);

            cbCounter = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_radmin.Checked = true;
            cb_ultravnc.Checked = true;
            cb_teamviewer.Checked = true;
            cb_ammyy.Checked = true;
            cb_anydesk.Checked = true;
            cb_libreoffice.Checked = true;
            cb_ccleaner.Checked = true;
            cb_chrome.Checked = true;
            cb_cutepdf.Checked = true;
            cb_fusioninventory.Checked = true;
            cb_spark.Checked = true;
            cb_thunderbird.Checked = true;
            cb_winrar.Checked = true;
            cb_klite.Checked = true;
            cb_globus.Checked = true;
            cb_netgent.Checked = true;
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cb_radmin.Checked = false;
            cb_ultravnc.Checked = false;
            cb_teamviewer.Checked = false;
            cb_ammyy.Checked = false;
            cb_anydesk.Checked = false;
            cb_libreoffice.Checked = false;
            cb_ccleaner.Checked = false;
            cb_chrome.Checked = false;
            cb_cutepdf.Checked = false;
            cb_fusioninventory.Checked = false;
            cb_spark.Checked = false;
            cb_thunderbird.Checked = false;
            cb_winrar.Checked = false;
            cb_klite.Checked = false;
            cb_globus.Checked = false;
            cb_netgent.Checked = false;
            cb_avast.Checked = false;

        }

        private void rd_netagent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_avast_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
            if (progressBar1.Value == 100)
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                progressBar.Stop();       // para o relógio
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            string cbCounterString = cbCounter.ToString();
            MessageBox.Show(cbCounterString);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cbCounter = 0;
        }



        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            MessageBox.Show("Clique");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Ping myPing = new Ping();
            PingReply reply = myPing.Send("192.168.0.150", 10);
            if (reply.Status == IPStatus.Success)
            {
                label_online.Text = "Servidor local encontrado.";
                label_online.ForeColor = Color.Blue;
                    
            }
            else
            {
                label_online.Text = "Online";
                //label_online.TextAlign = CenterToParent;
                label_online.ForeColor = Color.Green;
            }
        }
    }
}