namespace HMZ.App.Views
{
    partial class ItemViewForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvListItem = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvListItem)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListItem
            // 
            this.gvListItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvListItem.Location = new System.Drawing.Point(0, 226);
            this.gvListItem.Name = "gvListItem";
            this.gvListItem.Size = new System.Drawing.Size(902, 338);
            this.gvListItem.TabIndex = 0;
            this.gvListItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListItem_CellDoubleClick);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(330, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 25);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh mục";
            // 
            // cbbCategory
            // 
            this.cbbCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Items.AddRange(new object[] {
            "Quan Ao",
            "Do ky niem",
            "Tien bac",
            "Giay to"});
            this.cbbCategory.Location = new System.Drawing.Point(614, 2);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(277, 25);
            this.cbbCategory.TabIndex = 3;
            // 
            // rtbDescription
            // 
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescription.Location = new System.Drawing.Point(62, 46);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(198, 114);
            this.rtbDescription.TabIndex = 4;
            this.rtbDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Link ảnh";
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImageUrl.Location = new System.Drawing.Point(330, 46);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(198, 25);
            this.txtImageUrl.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(62, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 33);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(162, 187);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 33);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(262, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 33);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(3, 3);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(272, 25);
            this.txtId.TabIndex = 1;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(614, 43);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(277, 25);
            this.txtLocation.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(547, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Vị trí để";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(330, 105);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(434, 25);
            this.txtTimKiem.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(770, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 33);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Serach";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ItemViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtImageUrl);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gvListItem);
            this.Name = "ItemViewForm";
            this.Size = new System.Drawing.Size(902, 564);
            this.Load += new System.EventHandler(this.ItemViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListItem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
    }
}
