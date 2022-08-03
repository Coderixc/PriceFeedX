using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceFeedX.Import_Bhav_Copy_NSE.ShowImportStatusToConsole_UserControl
{
    public partial class MessageBox_Show_UserControl : UserControl
    {
        public MessageBox_Show_UserControl()
        {
            InitializeComponent();
        }

        private void eventLog1_progressbar_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
