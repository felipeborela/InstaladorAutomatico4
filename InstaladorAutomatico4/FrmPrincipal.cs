using System;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;


namespace InstaladorAutomatico4
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        string capicomInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\Capicom\InstalarCapicom.bat";
        string capicomDestPath = @"C:\TI\Capicom\";
        string capicomInstaller_DestPath = @"C:\TI\Capicom\InstalarCapicom.bat";

        string ultravncInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\UltraVNC\InstalarUltraVNC.bat";
        string ultravncDestPath = @"C:\TI\UltraVNC\";
        string ultravncInstaller_DestPath = @"C:\TI\UltraVNC\InstalarUltraVNC.bat";

        string teamviewerInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\TeamViewer\InstalarTeamViewer.bat";
        string teamviewerDestPath = @"C:\TI\TeamViewer\";
        string teamviewerInstaller_DestPath = @"C:\TI\TeamViewer\InstalarTeamViewer.bat";

        string firebirdInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\Firebird\InstalarFirebird.bat";
        string firebirdDestPath = @"C:\TI\Firebird\";
        string firebirdInstaller_DestPath = @"C:\TI\Firebird\InstalarFirebird.bat";

        string alphasisInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\AlphaSis\InstalarAlphaSis.bat";
        string alphasisDestPath = @"C:\TI\AlphaSis\";
        string alphasisInstaller_DestPath = @"C:\TI\AlphaSis\InstalarAlphaSis.bat";

        string anydeskInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\Anydesk\InstalarAnydesk.bat";
        string anydeskDestPath = @"C:\TI\Anydesk\";
        string anydeskInstaller_DestPath = @"C:\TI\Anydesk\InstalarAnydesk.bat";

        string librefirewall_3050Installer_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\LibreFirewall_3050\InstalarLibreFirewall_3050.bat";
        string librefirewall_3050DestPath = @"C:\TI\LibreFirewall_3050\";
        string librefirewall_3050Installer_DestPath = @"C:\TI\Librefirewall_3050\InstalarLibreFirewall_3050.bat";

        string javaInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\Java\InstalarJava.bat";
        string javaDestPath = @"C:\TI\Java\";
        string javaInstaller_DestPath = @"C:\TI\Java\InstalarJava.bat";

        string chromeInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\Chrome\InstalarChrome.bat";
        string chromeDestPath = @"C:\TI\Chrome\";
        string chromeInstaller_DestPath = @"C:\TI\Chrome\InstalarChrome.bat";

        string lightshotInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\Lightshot\InstalarLightshot.bat";
        string lightshotDestPath = @"C:\TI\Lightshot\";
        string lightshotInstaller_DestPath = @"C:\TI\Lightshot\InstalarLightshot.bat";

        string fusioninventoryInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\FusionInventory\InstalarFusionInventory.bat";
        string fusioninventoryDestPath = @"C:\TI\FusionInventory\";
        string fusioninventoryInstaller_DestPath = @"C:\TI\FusionInventory\InstalarFusionInventory.bat";

        string onedriveInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\Registros\InstalarOneDrive.bat";
        string onedriveDestPath = @"C:\TI\OneDrive\";
        string onedriveInstaller_DestPath = @"C:\TI\OneDrive\InstalarOneDrive.bat";

        string tempdirDestPath = @"C:\TEMP\";

        string winrarInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\Winrar\InstalarWinrar.bat";
        string winrarDestPath = @"C:\TI\Winrar\";
        string winrarInstaller_DestPath = @"C:\TI\Winrar\InstalarWinrar.bat";

        string code39Installer_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\Registros\Code39.ttf";
        string code39DestPath = @"C:\TI\Registros";
        string code39DestPathSys = @"C:\Windows\Fonts";
        string code39Installer_DestPath = @"C:\TI\Registros\Code39.ttf";
        string registros_DestPath = @"C:\TI\Registros";

        string nfeInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\NFE\InstalarNFE.bat";
        string nfeDestPath = @"C:\TI\NFE\";
        string nfeInstaller_DestPath = @"C:\TI\NFE\InstalarNFE.bat";
        
        string desativaruacInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\DesativarUAC\InstalarDesativarUAC.bat";
        string desativaruacDestPath = @"C:\TI\DesativarUAC\";
        string desativaruacInstaller_DestPath = @"C:\TI\DesativarUAC\InstalarDesativarUAC.bat";
        
        string aspiahostInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\AspiaHost\InstalarAspiaHost.bat";
        string aspiahostDestPath = @"C:\TI\AspiaHost\";
        string aspiahostInstaller_DestPath = @"C:\TI\AspiaHost\InstalarAspiaHost.bat";

        string firewall_3050Installer_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\Firewall_3050\InstalarFirewall_3050.bat";
        string firewall_3050DestPath = @"C:\TI\Firewall_3050\";
        string firewall_3050Installer_DestPath = @"C:\TI\Firewall_3050\InstalarFirewall_3050.bat";

        string AltoDesempenhoEnergiaInstaller_SourcePath = @"\\SERVIDOR\InstaladorAutomatico\Registros\AltoDesempenhoEnergia.bat";
        string AltoDesempenhoEnergiaDestPath = @"C:\TI\Registros\";
        string AltoDesempenhoEnergiaInstaller_DestPath = @"C:\TI\Registros\AltoDesempenhoEnergia.bat";



        private void button1_Click(object sender, EventArgs e)
        {



            if (cb_update.Checked)
            {
                if (cb_teamviewer.Checked)
                {
                    InstalarTeamViewerOnline:
                        if (File.Exists(teamviewerDestPath))
                        {
                            System.Net.WebClient client = new System.Net.WebClient();
                            client.DownloadFile("https://download.teamviewer.com/download/TeamViewer_Setup_x64.exe", @"C:\\TI\\TeamViewer\\TeamViewer_Setup_x64.exe");
                            //client.DownloadFile("http://www.vparaty.com.br/instalador/nfe/InstalarNFEOnline.bat", @"C:\\TI\\NFE\\InstalarNFEOnline.bat");
                            System.Diagnostics.Process.Start(teamviewerInstaller_DestPath);
                        }
                        else
                        {
                            Directory.CreateDirectory(teamviewerDestPath);
                            goto InstalarTeamViewerOnline;
                        }
                }
                //MessageBox.Show("Desenvolver...");
            }
            else
            {
                if (cb_capicom.Checked)
                {
                    if (File.Exists(capicomInstaller_DestPath))
                    {
                        System.Diagnostics.Process.Start(capicomInstaller_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(capicomDestPath);
                        System.IO.File.Copy(capicomInstaller_SourcePath, capicomInstaller_DestPath, true);
                        System.Diagnostics.Process.Start(capicomInstaller_DestPath);
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

                if (cb_alphasis.Checked)
                {
                    if (File.Exists(alphasisInstaller_DestPath))
                    {
                        System.Diagnostics.Process.Start(alphasisInstaller_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(alphasisDestPath);
                        System.IO.File.Copy(alphasisInstaller_SourcePath, alphasisInstaller_DestPath, true);
                        System.Diagnostics.Process.Start(alphasisInstaller_DestPath);
                    }
                }

                if (cb_altodesempenhoenergia.Checked)
                {
                    if (File.Exists(AltoDesempenhoEnergiaInstaller_DestPath))
                    {
                        System.Diagnostics.Process.Start(AltoDesempenhoEnergiaInstaller_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(AltoDesempenhoEnergiaDestPath);
                        System.IO.File.Copy(AltoDesempenhoEnergiaInstaller_SourcePath, AltoDesempenhoEnergiaInstaller_DestPath, true);
                        System.Diagnostics.Process.Start(AltoDesempenhoEnergiaInstaller_DestPath);
                    }
                }

                if (cb_firebird.Checked)
                {
                    if (File.Exists(firebirdInstaller_DestPath))
                    {
                        System.Diagnostics.Process.Start(firebirdInstaller_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(firebirdDestPath);
                        System.IO.File.Copy(firebirdInstaller_SourcePath, firebirdInstaller_DestPath, true);
                        System.Diagnostics.Process.Start(firebirdInstaller_DestPath);
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

                if (cb_librefirewall_3050.Checked)
                {
                    if (File.Exists(librefirewall_3050Installer_DestPath))
                    {
                        System.Diagnostics.Process.Start(librefirewall_3050Installer_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(librefirewall_3050DestPath);
                        System.IO.File.Copy(librefirewall_3050Installer_SourcePath, librefirewall_3050Installer_DestPath, true);
                        System.Diagnostics.Process.Start(librefirewall_3050Installer_DestPath);
                    }
                }

                if (cb_java.Checked)
                {
                    if (File.Exists(javaInstaller_DestPath))
                    {
                        System.Diagnostics.Process.Start(javaInstaller_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(javaDestPath);
                        System.IO.File.Copy(javaInstaller_SourcePath, javaInstaller_DestPath, true);
                        System.Diagnostics.Process.Start(javaInstaller_DestPath);
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

                if (cb_lightshot.Checked)
                {
                    if (File.Exists(lightshotInstaller_DestPath))
                    {
                        System.Diagnostics.Process.Start(lightshotInstaller_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(lightshotDestPath);
                        System.IO.File.Copy(lightshotInstaller_SourcePath, lightshotInstaller_DestPath, true);
                        System.Diagnostics.Process.Start(lightshotInstaller_DestPath);
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

                if (cb_onedrive.Checked)
                {
                    if (File.Exists(onedriveInstaller_DestPath))
                    {
                        System.Diagnostics.Process.Start(onedriveInstaller_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(onedriveDestPath);
                        System.IO.File.Copy(onedriveInstaller_SourcePath, onedriveInstaller_DestPath, true);
                        System.Diagnostics.Process.Start(onedriveInstaller_DestPath);
                    }
                }

                if (cb_tempdir.Checked)
                {
                    if (File.Exists(tempdirDestPath))
                    {
                        //System.Diagnostics.Process.Start(tempdirInstaller_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(tempdirDestPath);
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

                if (cb_code39.Checked)
                {
                    Code39:
                    if (Directory.Exists(registros_DestPath))
                    {
                        if (File.Exists(code39Installer_DestPath))
                        {
                            System.IO.File.Copy(code39Installer_DestPath, code39DestPathSys, true);
                        }
                        else
                        {
                            Directory.CreateDirectory(code39DestPath);
                            System.IO.File.Copy(code39Installer_SourcePath, code39Installer_DestPath, true);
                         }
                    }
                    else
                    {
                        Directory.CreateDirectory(registros_DestPath);
                        goto Code39;
                    }
                   
                }

                if (cb_alphasis.Checked)
                {
                    if (File.Exists(alphasisInstaller_DestPath))
                    {
                        System.Diagnostics.Process.Start(alphasisInstaller_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(alphasisDestPath);
                        System.IO.File.Copy(alphasisInstaller_SourcePath, alphasisInstaller_DestPath, true);
                        System.Diagnostics.Process.Start(alphasisInstaller_DestPath);
                    }
                }

                if (cb_nfe.Checked)
                {
                    if (File.Exists(nfeInstaller_DestPath))
                    {
                        System.Diagnostics.Process.Start(nfeInstaller_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(nfeDestPath);
                        System.IO.File.Copy(nfeInstaller_SourcePath, nfeInstaller_DestPath, true);
                        System.Diagnostics.Process.Start(nfeInstaller_DestPath);
                    }
                }

                if (cb_netgent.Checked)
                {
                    if (File.Exists(desativaruacInstaller_DestPath))
                    {
                        System.Diagnostics.Process.Start(desativaruacInstaller_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(desativaruacDestPath);
                        System.IO.File.Copy(desativaruacInstaller_SourcePath, desativaruacInstaller_DestPath, true);
                        System.Diagnostics.Process.Start(desativaruacInstaller_DestPath);
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

                if (cb_firewall_3050.Checked)
                {
                    if (File.Exists(firewall_3050Installer_DestPath))
                    {
                        System.Diagnostics.Process.Start(firewall_3050Installer_DestPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(firewall_3050DestPath);
                        System.IO.File.Copy(firewall_3050Installer_SourcePath, firewall_3050Installer_DestPath, true);
                        System.Diagnostics.Process.Start(firewall_3050Installer_DestPath);
                    }
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_capicom.Checked = true;
            cb_ultravnc.Checked = true;
            cb_teamviewer.Checked = true;
            cb_firebird.Checked = true;
            cb_anydesk.Checked = true;
            cb_librefirewall_3050.Checked = true;
            cb_java.Checked = true;
            cb_chrome.Checked = true;
            cb_lightshot.Checked = true;
            cb_fusioninventory.Checked = true;
            cb_onedrive.Checked = true;
            cb_tempdir.Checked = true;
            cb_winrar.Checked = true;
            cb_code39.Checked = true;
            cb_alphasis.Checked = true;
            cb_netgent.Checked = true;
            cb_aspiahost.Checked = true;
            cb_firewall_3050.Checked = true;
            cb_nfe.Checked = true;
            cb_altodesempenhoenergia.Checked = true;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cb_capicom.Checked = false;
            cb_ultravnc.Checked = false;
            cb_teamviewer.Checked = false;
            cb_firebird.Checked = false;
            cb_anydesk.Checked = false;
            cb_librefirewall_3050.Checked = false;
            cb_java.Checked = false;
            cb_chrome.Checked = false;
            cb_lightshot.Checked = false;
            cb_fusioninventory.Checked = false;
            cb_onedrive.Checked = false;
            cb_tempdir.Checked = false;
            cb_winrar.Checked = false;
            cb_code39.Checked = false;
            cb_alphasis.Checked = false;
            cb_netgent.Checked = false;
            cb_nfe.Checked = false;
            cb_aspiahost.Checked = false;
            cb_firewall_3050.Checked = false;
            cb_altodesempenhoenergia.Checked = false;

        }

        private void rd_desativaruac_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_nfe_CheckedChanged(object sender, EventArgs e)
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
                pb_Capicom.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Capicom.Image = Properties.Resources.check_error;
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

            if ((File.Exists("C:\\Program Files\\Firebird\\Firebird_3_0\\firebird.exe")) || (File.Exists("C:\\Program Files (x86)\\Firebird\\Firebird_3_0\\firebird.exe")))
            {
                pb_Firebird.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Firebird.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files (x86)\\AnyDesk\\AnyDesk.exe")) || (File.Exists("C:\\Program Files\\AnyDesk\\AnyDesk.exe")))
            {
                pb_AnyDesk.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_AnyDesk.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\LibreFirewall_3050\\program\\sfirewall_3050.exe")) || (File.Exists("C:\\Program Files\\LibreFirewall_3050 (x86)\\program\\sfirewall_3050.exe")))
            {
                pb_BI.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_BI.Image = Properties.Resources.check_error;
            }


            if ((File.Exists("C:\\Program Files\\Java\\jre1.8.0_351\\bin\\javaw.exe")) || (File.Exists("C:\\Program Files (x86)\\Java\\jre1.8.0_351\\bin\\javaw.exe")))
            {
                pb_Java.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Java.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe")) || (File.Exists("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe")))
            {
                pb_Chrome.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Chrome.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files (x86)\\Skillbrains\\lightshot\\Lightshot.exe")) || (File.Exists("C:\\Program Files\\Skillbrains\\lightshot\\Lightshot.exe")))
            {
                pb_Lightshot.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Lightshot.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\FusionInventory-Agent\\perl\\bin\\fusioninventory-agent.exe")) || (File.Exists("C:\\Program Files (x86)\\FusionInventory-Agent\\perl\\bin\\fusioninventory-agent.exe")))
            {
                pb_FusionInventory.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_FusionInventory.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\OneDrive\\OneDrive.exe")) || (File.Exists("C:\\Program Files (x86)\\OneDrive\\OneDrive.exe")))
            {
                pb_OneDrive.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_OneDrive.Image = Properties.Resources.check_error;
            }

            if (Directory.Exists("C:\\TEMP"))
            {
                pb_TempDir.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_TempDir.Image = Properties.Resources.check_error;
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
                pb_Code39.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Code39.Image = Properties.Resources.check_error;
            }

            if (((File.Exists("C:\\ambalphasis\\BDEADMIN.EXE")) && (File.Exists("C:\\app\\product\\11.2.0\\client_1\\network\\admin\\tnsnames.ora")) || ((File.Exists("C:\\ambalphasis\\BDEADMIN.EXE")) && (File.Exists("C:\\oracle\\product\\11.2.0\\client_1\\network\\admin\\tnsnames.ora")))))
            {
                pb_AlphaSis.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_AlphaSis.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\TI\\Registros\\DesabilitarUAC_OK.txt")))
            {
                pb_DesativarUAC.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_DesativarUAC.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files\\NFE Software\\NFE\\NFEUI.exe")) || (File.Exists("C:\\Program Files (x86)\\NFE Software\\NFE\\NFEUI.exe")))
            {
                pb_NFE.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_NFE.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\TI\\Registros\\Firebird_3050.txt")))
            {
                pb_Firewall_3050.Image = Properties.Resources.check_ok;
            }
            else
            {
                pb_Firewall_3050.Image = Properties.Resources.check_error;
            }

            if ((File.Exists("C:\\Program Files (x86)\\Aspia\\Host\\aspia_host.exe") || (File.Exists("C:\\Program Files\\Aspia\\Host\\aspia_host.exe"))))
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
                PingReply reply = myPing.Send("192.168.50.100", 10);
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

        private void cb_firebird_CheckedChanged(object sender, EventArgs e)
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

        private void pb_firebird_Click(object sender, EventArgs e)
        {

        }

        private void cb_capicom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_tempdir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_java_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_lightshot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_onedrive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_code39_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void softwares_Click(object sender, EventArgs e)
        {

        }

        private void cb_nfe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_AltoDesempenhoEnergia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pb_Firewall_3050_Click(object sender, EventArgs e)
        {

        }
    }
}
//ok