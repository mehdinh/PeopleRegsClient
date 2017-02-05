using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleRegsClient
{
    public partial class FPrint : Form
    {
        public FPrint()
        {
            InitializeComponent();
        }

        private void FPrint_Load(object sender, EventArgs e)
        {

            this.ReportViewer.RefreshReport();
        }
    }
}
