using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanamAja.App.View
{
    public partial class DashboardCustomer : Form
    {

        public DashboardCustomer()
        {
            InitializeComponent();
        }

        private void DashboardCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {

        }

        private void btnRiwayat_Click_1(object sender, EventArgs e)
        {
            RiwayatCustomer riwayatCustomer = new RiwayatCustomer();
            riwayatCustomer.Show();
            this.Hide();
        }
    }
}
