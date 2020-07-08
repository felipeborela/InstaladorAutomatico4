using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaladorAutomatico4
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_radmin.Checked)
            {
                System.Diagnostics.Process.Start(@"C:/TI/Radmin/InstalarRadmin.bat");
            }
            if (cb_ultravnc.Checked)
            {
                System.Diagnostics.Process.Start(@"C:/TI/UltraVNC/InstalarUltraVNC.bat");
            }
            if (cb_teamviewer.Checked)
            {
                System.Diagnostics.Process.Start(@"C:/TI/UltraVNC/InstalarTeamViewer.bat");
            }
            if (cb_ammyy.Checked)
            {
                System.Diagnostics.Process.Start(@"C:/TI/Ammyy/InstalarAmmyy.bat");
            }
            if (cb_anydesk.Checked)
            {
                System.Diagnostics.Process.Start(@"C:/TI/UltraVNC/InstalarAnyDesk.bat");
            }
            if (cb_libreoffice.Checked)
            {
                System.Diagnostics.Process.Start(@"C:/TI/LibreOffice/InstalarLibreOffice.bat");
            }
            if (cb_ccleaner.Checked)
            {
                System.Diagnostics.Process.Start(@"C:/TI/CCleaner/InstalarCCleaner.bat");
            }
            if (cb_cutepdf.Checked)
            {
                System.Diagnostics.Process.Start(@"C:/TI/CutePDF/InstalarCutePDF.bat");
            }
            if (cb_fusioninventory.Checked)
            {
                System.Diagnostics.Process.Start(@"C:/TI/FusionInventory/InstalarFusionInventory.bat");
            }
            if (cb_spark.Checked)
            {
                System.Diagnostics.Process.Start(@"C:/TI/Spark/InstalarSpark.bat");
            }
            if (cb_thunderbird.Checked)
            {
                System.Diagnostics.Process.Start(@"C:/TI/Thunderbird/InstalarThunderbird.bat");
            }
            if (cb_winrar.Checked)
            {
                System.Diagnostics.Process.Start(@"C:/TI/Winrar/InstalarWinrar.bat");
            }
            if (cb_klite.Checked)
            {
                System.Diagnostics.Process.Start(@"C:/TI/KLite/InstalarThunderbird.bat");
            }
            if (cb_globus.Checked)
            {
                System.Diagnostics.Process.Start(@"C:/TI/Globus/InstalarGlobus.bat");
            }
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

        }

        private void rd_netagent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_avast_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
