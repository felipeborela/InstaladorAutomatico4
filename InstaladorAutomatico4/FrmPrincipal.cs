﻿using System;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.IO.Compression;


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
        string avastInstaller_path = @"C:\\TI\\Avast\\avast_free_antivirus_setup_online.exe";

        string netagentInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\NetAgent\InstalarNetAgent.bat";
        string netagentDestPath = @"C:\TI\NetAgent\";
        string netagentInstaller_DestPath = @"C:\TI\NetAgent\InstalarNetAgent.bat";
        
        string aspiahostInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\AspiaHost\InstalarAspiaHost.bat";
        string aspiahostDestPath = @"C:\TI\AspiaHost\";
        string aspiahostInstaller_DestPath = @"C:\TI\AspiaHost\InstalarAspiaHost.bat";

        string officeInstaller_SourcePath = @"\\192.168.0.13\InstaladorAutomatico\Office\InstalarOffice.bat";
        string officeDestPath = @"C:\TI\Office\";
        string officeInstaller_DestPath = @"C:\TI\Office\InstalarOffice.bat";



        private void button1_Click(object sender, EventArgs e)
        {



            if (cb_update.Checked)
            {
                if (cb_avast.Checked)
                {
                /*    
                InstalarAvast:
                    if (File.Exists(avastInstaller_path))
                    {
                        System.Net.WebClient client = new System.Net.WebClient();
                        client.DownloadFile("http://www.vparaty.com.br/instalador/avast/avast_free_antivirus_setup_online.exe", avastInstaller_path);
                        client.DownloadFile("http://www.vparaty.com.br/instalador/avast/InstalarAvastOnline.bat", @"C:\\TI\\Avast\\InstalarAvastOnline.bat");
                        System.Diagnostics.Process.Start(@"C:\\TI\\Avast\\InstalarAvastOnline.bat");
                    }
                    else
                    {
                        Directory.CreateDirectory(avastDestPath);
                        goto InstalarAvast;
                    }*/
                }
                //MessageBox.Show("Desenvolver...");
            }
            else
            {
                if (cb_radmin.Checked)
                {
                    if (File.Exists(radminInstaller_DestPath))
                    {
                        System.Diagnostics.Process.Start(radminInstaller_DestPath);
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
                    }
                    else
                    {
                        Directory.CreateDirectory(netagentDestPath);
                        System.IO.File.Copy(netagentInstaller_SourcePath, netagentInstaller_DestPath, true);
                        System.Diagnostics.Process.Start(netagentInstaller_DestPath);
                    }
                }

                if (cb_aspiahost.Checked)
                {
                    if (File.Exists(aspiahostInstaller_DestPath))
                    {
                        System.Diagnostics.Process.Start(aspiahostInstaller_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(aspiahostDestPath);
                        System.IO.File.Copy(aspiahostInstaller_SourcePath, aspiahostInstaller_DestPath, true);
                        System.Diagnostics.Process.Start(aspiahostInstaller_DestPath);
                    }
                }

                if (cb_office.Checked)
                {
                    if (File.Exists(officeInstaller_DestPath))
                    {
                        System.Diagnostics.Process.Start(officeInstaller_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(officeDestPath);
                        System.IO.File.Copy(officeInstaller_SourcePath, officeInstaller_DestPath, true);
                        System.Diagnostics.Process.Start(officeInstaller_DestPath);
                    }
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {


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
            cb_aspiahost.Checked = true;

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
            cb_aspiahost.Checked = false;

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

        }



        private void button4_Click(object sender, EventArgs e)
        {

        }



        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            //MessageBox.Show("Clique");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm:ss tt");

            if ((File.Exists("C:\\Windows\\SysWOW64\\rserver30\\rserver3.exe")) || (File.Exists("C:\\Windows\\System32\\rserver30\\rserver3.exe")))
            {
                pb_Radmin.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Radmin.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\uvnc bvba\\UltraVNC\\winvnc.exe")) || (File.Exists("C:\\Program Files (x86)\\uvnc bvba\\UltraVNC\\winvnc.exe")))
            {
                pb_UltraVNC.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_UltraVNC.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files (x86)\\TeamViewer\\TeamViewer.exe")) || (File.Exists("C:\\Program Files\\TeamViewer\\TeamViewer.exe")))
            {
                pb_TeamViewer.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_TeamViewer.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\TI\\Ammyy\\AA_v3.exe")) || (File.Exists("C:\\TI\\Ammyy\\Ammyy.exe")))
            {
                pb_Ammyy.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Ammyy.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files (x86)\\AnyDesk\\AnyDesk.exe")) || (File.Exists("C:\\Program Files\\AnyDesk\\AnyDesk.exe")))
            {
                pb_AnyDesk.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_AnyDesk.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\LibreOffice\\program\\soffice.exe")) || (File.Exists("C:\\Program Files\\LibreOffice (x86)\\program\\soffice.exe")))
            {
                pb_LibreOffice.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_LibreOffice.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\CCleaner\\CCleaner.exe")) || (File.Exists("C:\\Program Files (x86)\\CCleaner\\CCleaner.exe")))
            {
                pb_CCleaner.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_CCleaner.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe")) || (File.Exists("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe")))
            {
                pb_Chrome.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Chrome.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files (x86)\\Acro Software\\CutePDF Writer\\CPWSave.exe")) || (File.Exists("C:\\Program Files\\Acro Software\\CutePDF Writer\\CPWSave.exe")))
            {
                pb_CutePDF.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_CutePDF.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\FusionInventory-Agent\\perl\\bin\\fusioninventory-agent.exe")) || (File.Exists("C:\\Program Files (x86)\\FusionInventory-Agent\\perl\\bin\\fusioninventory-agent.exe")))
            {
                pb_FusionInventory.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_FusionInventory.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\Spark\\Spark.exe")) || (File.Exists("C:\\Program Files (x86)\\Spark\\Spark.exe")))
            {
                pb_Spark.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Spark.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\Mozilla Thunderbird\\Thunderbird.exe")) || (File.Exists("C:\\Program Files (x86)\\Mozilla Thunderbird\\Thunderbird.exe")))
            {
                pb_Thunderbird.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Thunderbird.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\Winrar\\Winrar.exe")) || (File.Exists("C:\\Program Files (x86)\\Winrar\\Winrar.exe")))
            {
                pb_Winrar.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Winrar.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files (x86)\\K-Lite Codec Pack\\Tools\\mediainfo.exe")) || (File.Exists("C:\\Program Files\\K-Lite Codec Pack\\Tools\\mediainfo.exe")))
            {
                pb_KLite.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_KLite.Image = Properties.Resources.check_error;
            }

            if (((File.Exists("C:\\ambglobus\\BDEADMIN.EXE")) && (File.Exists("C:\\app\\product\\11.2.0\\client_1\\network\\admin\\tnsnames.ora")) || ((File.Exists("C:\\ambglobus\\BDEADMIN.EXE")) && (File.Exists("C:\\oracle\\product\\11.2.0\\client_1\\network\\admin\\tnsnames.ora")))))
            {
                pb_Globus.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Globus.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files (x86)\\Kaspersky Lab\\NetworkAgent\\klnagent.exe")) || (File.Exists("C:\\Program Files\\Kaspersky Lab\\NetworkAgent\\klnagent.exe")))
            {
                pb_NetAgent.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_NetAgent.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\Avast Software\\Avast\\AvastUI.exe")) || (File.Exists("C:\\Program Files (x86)\\Avast Software\\Avast\\AvastUI.exe")))
            {
                pb_Avast.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Avast.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\Microsoft Office\\root\\Office16\\winword.exe")) || (File.Exists("C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\winword.exe")))
            {
                pb_Office.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Office.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files (x86)\\Aspia\\Host\\aspia_host_config.exe") || (File.Exists("C:\\Program Files\\Aspia\\Host\\aspia_host_config.exe"))))
            {
                pb_aspiahost.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_aspiahost.Image = Properties.Resources.check_error;
            }

        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Ping myPing = new Ping();


            try
            {
                PingReply reply = myPing.Send("192.168.0.13", 10);
                if (reply.Status == IPStatus.Success)
                {
                    label_online.Text = "Servidor local encontrado";
                    label_online.ForeColor = Color.Blue;
                    cb_update.Checked = false;

                }
                else
                {
                    label_online.Text = "Online";
                    label_online.ForeColor = Color.Green;
                    cb_update.Checked = true;
                }
            }

            catch
            {
                label_online.Text = "Nenhum servidor encontrado";
                label_online.ForeColor = Color.Red;
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label_online_Click(object sender, EventArgs e)
        {

        }

        private void cb_ammyy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
//ok