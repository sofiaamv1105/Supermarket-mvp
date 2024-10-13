namespace Supermarket_mvp.Views
{
    partial class ProductView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnProductClose = new Button();
            BtnProductDelete = new Button();
            BtnProductEdit = new Button();
            BtnProductNew = new Button();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProducts = new DataGridView();
            BtnProductSearch = new Button();
            TxtProductSearch = new TextBox();
            label3 = new Label();
            tabPageProductDetail = new TabPage();
            TxtCategoryId = new TextBox();
            label8 = new Label();
            TxtProductStock = new TextBox();
            label7 = new Label();
            BtnProductCancel = new Button();
            BtnProductSave = new Button();
            TxtProductName = new TextBox();
            TxtProductPrice = new TextBox();
            TxtProductId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            tabPageProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 6);
            label1.Name = "label1";
            label1.Size = new Size(300, 71);
            label1.TabIndex = 2;
            label1.Text = "Pay Mode";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 99);
            panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cerrar_sesion_de_usuario;
            pictureBox2.Location = new Point(36, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(209, 9);
            label2.Name = "label2";
            label2.Size = new Size(300, 71);
            label2.TabIndex = 0;
            label2.Text = "Products";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 99);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 351);
            tabControl1.TabIndex = 5;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnProductClose);
            tabPagePayModeList.Controls.Add(BtnProductDelete);
            tabPagePayModeList.Controls.Add(BtnProductEdit);
            tabPagePayModeList.Controls.Add(BtnProductNew);
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgProducts);
            tabPagePayModeList.Controls.Add(BtnProductSearch);
            tabPagePayModeList.Controls.Add(TxtProductSearch);
            tabPagePayModeList.Controls.Add(label3);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(792, 323);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Product List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnProductClose
            // 
            BtnProductClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnProductClose.Image = Properties.Resources.cerrar;
            BtnProductClose.Location = new Point(602, 253);
            BtnProductClose.Name = "BtnProductClose";
            BtnProductClose.Size = new Size(182, 55);
            BtnProductClose.TabIndex = 11;
            BtnProductClose.UseVisualStyleBackColor = true;
            // 
            // BtnProductDelete
            // 
            BtnProductDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnProductDelete.Image = Properties.Resources.delete;
            BtnProductDelete.Location = new Point(602, 192);
            BtnProductDelete.Name = "BtnProductDelete";
            BtnProductDelete.Size = new Size(182, 55);
            BtnProductDelete.TabIndex = 10;
            BtnProductDelete.UseVisualStyleBackColor = true;
            // 
            // BtnProductEdit
            // 
            BtnProductEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnProductEdit.Image = Properties.Resources.edit;
            BtnProductEdit.Location = new Point(602, 131);
            BtnProductEdit.Name = "BtnProductEdit";
            BtnProductEdit.Size = new Size(182, 55);
            BtnProductEdit.TabIndex = 9;
            BtnProductEdit.UseVisualStyleBackColor = true;
            // 
            // BtnProductNew
            // 
            BtnProductNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnProductNew.Image = Properties.Resources._new;
            BtnProductNew.Location = new Point(602, 70);
            BtnProductNew.Name = "BtnProductNew";
            BtnProductNew.Size = new Size(182, 55);
            BtnProductNew.TabIndex = 8;
            BtnProductNew.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(1175, 250);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(182, 55);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(1175, 189);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(182, 55);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(1175, 128);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(182, 55);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(1175, 67);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(182, 55);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(32, 70);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.Size = new Size(564, 233);
            DgProducts.TabIndex = 3;
            // 
            // BtnProductSearch
            // 
            BtnProductSearch.Image = Properties.Resources.search_small;
            BtnProductSearch.Location = new Point(358, 23);
            BtnProductSearch.Name = "BtnProductSearch";
            BtnProductSearch.Size = new Size(49, 41);
            BtnProductSearch.TabIndex = 2;
            BtnProductSearch.UseVisualStyleBackColor = true;
            // 
            // TxtProductSearch
            // 
            TxtProductSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtProductSearch.Location = new Point(35, 38);
            TxtProductSearch.Name = "TxtProductSearch";
            TxtProductSearch.PlaceholderText = "Data to search";
            TxtProductSearch.Size = new Size(317, 23);
            TxtProductSearch.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 20);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 0;
            label3.Text = "Search Products";
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(TxtCategoryId);
            tabPageProductDetail.Controls.Add(label8);
            tabPageProductDetail.Controls.Add(TxtProductStock);
            tabPageProductDetail.Controls.Add(label7);
            tabPageProductDetail.Controls.Add(BtnProductCancel);
            tabPageProductDetail.Controls.Add(BtnProductSave);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(label5);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Controls.Add(label6);
            tabPageProductDetail.Location = new Point(4, 24);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(792, 323);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Location = new Point(473, 34);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.ReadOnly = true;
            TxtCategoryId.Size = new Size(198, 23);
            TxtCategoryId.TabIndex = 11;
            TxtCategoryId.Text = "0";
            TxtCategoryId.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(473, 16);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 10;
            label8.Text = "Category Id";
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(47, 223);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.PlaceholderText = "Product Stock";
            TxtProductStock.ReadOnly = true;
            TxtProductStock.Size = new Size(307, 23);
            TxtProductStock.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 205);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 8;
            label7.Text = "Products Stock";
            // 
            // BtnProductCancel
            // 
            BtnProductCancel.Image = Properties.Resources.cancel;
            BtnProductCancel.Location = new Point(194, 260);
            BtnProductCancel.Name = "BtnProductCancel";
            BtnProductCancel.Size = new Size(106, 41);
            BtnProductCancel.TabIndex = 7;
            BtnProductCancel.UseVisualStyleBackColor = true;
            // 
            // BtnProductSave
            // 
            BtnProductSave.Image = Properties.Resources.save;
            BtnProductSave.Location = new Point(47, 260);
            BtnProductSave.Name = "BtnProductSave";
            BtnProductSave.Size = new Size(106, 41);
            BtnProductSave.TabIndex = 6;
            BtnProductSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(47, 98);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "Product Name";
            TxtProductName.Size = new Size(307, 23);
            TxtProductName.TabIndex = 5;
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(47, 159);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.PlaceholderText = "Product Price";
            TxtProductPrice.Size = new Size(307, 23);
            TxtProductPrice.TabIndex = 4;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(47, 34);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(198, 23);
            TxtProductId.TabIndex = 3;
            TxtProductId.Text = "0";
            TxtProductId.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 141);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 2;
            label5.Text = "Product Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 80);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 1;
            label4.Text = "Product Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 16);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 0;
            label6.Text = "Product Id";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ProductView";
            Text = "ProductView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProducts;
        public Button BtnProductSearch;
        private TextBox TxtProductSearch;
        private Label label3;
        private TabPage tabPageProductDetail;
        private Button BtnProductCancel;
        private Button BtnProductSave;
        private TextBox TxtProductName;
        private TextBox TxtProductPrice;
        private TextBox TxtProductId;
        private Label label5;
        private Label label4;
        private Label label6;
        private Button BtnProductClose;
        private Button BtnProductDelete;
        private Button BtnProductEdit;
        private Button BtnProductNew;
        private Label label7;
        private TextBox TxtProductStock;
        private TextBox TxtCategoryId;
        private Label label8;
    }
}