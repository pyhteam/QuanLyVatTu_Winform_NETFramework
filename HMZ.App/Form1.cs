using HMZ.App.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMZ.App
{
    public partial class HMZ_AppMain : Form
    {
        public HMZ_AppMain()
        {
            InitializeComponent();
        }

        private void HMZ_AppMain_Load(object sender, EventArgs e)
        {

        }

        private void btnQuanLyVatTu_Click(object sender, EventArgs e)
        {
            ItemViewForm itemViewForm = new ItemViewForm();
            itemViewForm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(itemViewForm);
        }
    }
}