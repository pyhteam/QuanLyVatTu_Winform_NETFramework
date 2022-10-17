using HMZ.App.Services;
using PYHDATA.NETFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMZ.App.Views
{
    public partial class ItemViewForm : UserControl
    {
        private ItemService itemService = new ItemService();
        private bool status = false;
        public ItemViewForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var item = new Item()
            {
                Name = txtName.Text,
                Desciption = rtbDescription.Text,
                ImageUrl = txtImageUrl.Text,
                CateogryName = cbbCategory.SelectedItem.ToString(),
                Location = txtLocation.Text,
            };
            int result = itemService.Add(item);
            if (result > 0)
            {
                MessageBox.Show("Add item successfully");
                Reset();
                LoadData();
            }
            else
            {
                MessageBox.Show("Add item failed");
            }

        }

        private void ItemViewForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void Reset()
        {
            txtName.Text = "";
            rtbDescription.Text = "";
            txtImageUrl.Text = "";
            cbbCategory.SelectedIndex = 0;
        }
        private void LoadData()
        {
            gvListItem.DataSource = null;
            var items = itemService.GetAll();
            gvListItem.DataSource = items;
        }

        private void gvListItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // handle data to textbox 
            var row = gvListItem.CurrentRow;
            txtName.Text = row.Cells[0].Value.ToString();
            rtbDescription.Text = row.Cells[1].Value.ToString();
            txtLocation.Text = row.Cells[2].Value.ToString() ?? "";
            txtImageUrl.Text = row.Cells[4].Value.ToString() ?? "";
            cbbCategory.SelectedItem = row.Cells[2].Value.ToString();
            txtId.Text = row.Cells[5].Value.ToString();
            status = bool.Parse(row.Cells[6].Value.ToString());
            // button update
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            var item = new Item()
            {
                Name = txtName.Text,
                Desciption = rtbDescription.Text,
                ImageUrl = txtImageUrl.Text,
                CateogryName = cbbCategory.SelectedItem.ToString(),
                Location = txtLocation.Text,
                Status = status

            };
            int result = itemService.Update(item, id);
            if (result > 0)
            {
                MessageBox.Show("Update item successfully");
                Reset();
                LoadData();
                // button update
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Enabled = true;
            }
            else
            {
                MessageBox.Show("Update item failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            int result = itemService.Delete(id);
            if (result > 0)
            {
                MessageBox.Show("Delete item successfully");
                Reset();
                LoadData();
                // button update
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Enabled = true;
            }
            else
            {
                MessageBox.Show("Delete item failed");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtTimKiem.Text;
            List<Item> items = itemService.GetItemByName(name);
            if (items.Count > 0)
            {
                gvListItem.DataSource = null;
                gvListItem.DataSource = items;
            }
            else
            {
                MessageBox.Show("Not data");
            }


        }
    }
}
