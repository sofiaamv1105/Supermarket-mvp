namespace Supermarket_mvp.Views
{
    partial class CategoryView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCategoryList = new TabPage();
            BtnCategorySearch = new Button();
            TxtCategorySearch = new TextBox();
            label2 = new Label();
            tabPageCategoryDetail = new TabPage();
            BtnCategoryCancel = new Button();
            BtnCategorySave = new Button();
            TxtDescription = new TextBox();
            TxtCategoryName = new TextBox();
            TxtCategoryId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            BtnCategoryClose = new Button();
            BtnCategoryDelete = new Button();
            BtnCategoryEdit = new Button();
            BtnCategoryNew = new Button();
            DgCategory = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoryList.SuspendLayout();
            tabPageCategoryDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.categorias1;
            pictureBox1.Image = Properties.Resources.categorias;
            pictureBox1.Location = new Point(27, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(356, 86);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoryList);
            tabControl1.Controls.Add(tabPageCategoryDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategoryList
            // 
            tabPageCategoryList.Controls.Add(DgCategory);
            tabPageCategoryList.Controls.Add(BtnCategoryClose);
            tabPageCategoryList.Controls.Add(BtnCategoryDelete);
            tabPageCategoryList.Controls.Add(BtnCategoryEdit);
            tabPageCategoryList.Controls.Add(BtnCategoryNew);
            tabPageCategoryList.Controls.Add(BtnCategorySearch);
            tabPageCategoryList.Controls.Add(TxtCategorySearch);
            tabPageCategoryList.Controls.Add(label2);
            tabPageCategoryList.Location = new Point(4, 24);
            tabPageCategoryList.Name = "tabPageCategoryList";
            tabPageCategoryList.Padding = new Padding(3);
            tabPageCategoryList.Size = new Size(792, 322);
            tabPageCategoryList.TabIndex = 0;
            tabPageCategoryList.Text = "Category List";
            tabPageCategoryList.UseVisualStyleBackColor = true;
            // 
            // BtnCategorySearch
            // 
            BtnCategorySearch.Image = Properties.Resources.search_small;
            BtnCategorySearch.Location = new Point(253, 25);
            BtnCategorySearch.Name = "BtnCategorySearch";
            BtnCategorySearch.Size = new Size(50, 43);
            BtnCategorySearch.TabIndex = 2;
            BtnCategorySearch.UseVisualStyleBackColor = true;
            // 
            // TxtCategorySearch
            // 
            TxtCategorySearch.Location = new Point(45, 45);
            TxtCategorySearch.Name = "TxtCategorySearch";
            TxtCategorySearch.PlaceholderText = "Data to Search";
            TxtCategorySearch.Size = new Size(202, 23);
            TxtCategorySearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 27);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Category";
            // 
            // tabPageCategoryDetail
            // 
            tabPageCategoryDetail.Controls.Add(BtnCategoryCancel);
            tabPageCategoryDetail.Controls.Add(BtnCategorySave);
            tabPageCategoryDetail.Controls.Add(TxtDescription);
            tabPageCategoryDetail.Controls.Add(TxtCategoryName);
            tabPageCategoryDetail.Controls.Add(TxtCategoryId);
            tabPageCategoryDetail.Controls.Add(label5);
            tabPageCategoryDetail.Controls.Add(label4);
            tabPageCategoryDetail.Controls.Add(label3);
            tabPageCategoryDetail.Location = new Point(4, 24);
            tabPageCategoryDetail.Name = "tabPageCategoryDetail";
            tabPageCategoryDetail.Padding = new Padding(3);
            tabPageCategoryDetail.Size = new Size(792, 322);
            tabPageCategoryDetail.TabIndex = 1;
            tabPageCategoryDetail.Text = "Category Detail";
            tabPageCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCategoryCancel
            // 
            BtnCategoryCancel.Image = Properties.Resources.cancel;
            BtnCategoryCancel.Location = new Point(194, 260);
            BtnCategoryCancel.Name = "BtnCategoryCancel";
            BtnCategoryCancel.Size = new Size(106, 41);
            BtnCategoryCancel.TabIndex = 8;
            BtnCategoryCancel.UseVisualStyleBackColor = true;
            // 
            // BtnCategorySave
            // 
            BtnCategorySave.Image = Properties.Resources.save;
            BtnCategorySave.Location = new Point(42, 260);
            BtnCategorySave.Name = "BtnCategorySave";
            BtnCategorySave.Size = new Size(106, 41);
            BtnCategorySave.TabIndex = 7;
            BtnCategorySave.UseVisualStyleBackColor = true;
            // 
            // TxtDescription
            // 
            TxtDescription.Location = new Point(42, 173);
            TxtDescription.Multiline = true;
            TxtDescription.Name = "TxtDescription";
            TxtDescription.PlaceholderText = "Category Description";
            TxtDescription.Size = new Size(295, 68);
            TxtDescription.TabIndex = 5;
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.Location = new Point(42, 111);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.PlaceholderText = "Category Name";
            TxtCategoryName.Size = new Size(297, 23);
            TxtCategoryName.TabIndex = 4;
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.BackColor = SystemColors.Control;
            TxtCategoryId.Location = new Point(44, 52);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.ReadOnly = true;
            TxtCategoryId.Size = new Size(176, 23);
            TxtCategoryId.TabIndex = 3;
            TxtCategoryId.Text = "0";
            TxtCategoryId.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 155);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 2;
            label5.Text = "Category Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 93);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 1;
            label4.Text = "Category Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 34);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 0;
            label3.Text = "Category Id";
            // 
            // BtnCategoryClose
            // 
            BtnCategoryClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCategoryClose.Image = Properties.Resources.cerrar;
            BtnCategoryClose.Location = new Point(589, 257);
            BtnCategoryClose.Name = "BtnCategoryClose";
            BtnCategoryClose.Size = new Size(182, 55);
            BtnCategoryClose.TabIndex = 11;
            BtnCategoryClose.UseVisualStyleBackColor = true;
            // 
            // BtnCategoryDelete
            // 
            BtnCategoryDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCategoryDelete.Image = Properties.Resources.delete;
            BtnCategoryDelete.Location = new Point(589, 196);
            BtnCategoryDelete.Name = "BtnCategoryDelete";
            BtnCategoryDelete.Size = new Size(182, 55);
            BtnCategoryDelete.TabIndex = 10;
            BtnCategoryDelete.UseVisualStyleBackColor = true;
            // 
            // BtnCategoryEdit
            // 
            BtnCategoryEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCategoryEdit.Image = Properties.Resources.edit;
            BtnCategoryEdit.Location = new Point(589, 135);
            BtnCategoryEdit.Name = "BtnCategoryEdit";
            BtnCategoryEdit.Size = new Size(182, 55);
            BtnCategoryEdit.TabIndex = 9;
            BtnCategoryEdit.UseVisualStyleBackColor = true;
            // 
            // BtnCategoryNew
            // 
            BtnCategoryNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCategoryNew.Image = Properties.Resources._new;
            BtnCategoryNew.Location = new Point(589, 74);
            BtnCategoryNew.Name = "BtnCategoryNew";
            BtnCategoryNew.Size = new Size(182, 55);
            BtnCategoryNew.TabIndex = 8;
            BtnCategoryNew.UseVisualStyleBackColor = true;
            // 
            // DgCategory
            // 
            DgCategory.AllowUserToAddRows = false;
            DgCategory.AllowUserToDeleteRows = false;
            DgCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategory.BackgroundColor = SystemColors.GradientInactiveCaption;
            DgCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategory.Location = new Point(45, 74);
            DgCategory.Name = "DgCategory";
            DgCategory.ReadOnly = true;
            DgCategory.Size = new Size(536, 238);
            DgCategory.TabIndex = 12;
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoryView";
            Text = "Category Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategoryList.ResumeLayout(false);
            tabPageCategoryList.PerformLayout();
            tabPageCategoryDetail.ResumeLayout(false);
            tabPageCategoryDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageCategoryList;
        private TextBox TxtCategorySearch;
        private Label label2;
        private TabPage tabPageCategoryDetail;
        private Button BtnCategorySearch;
        private TextBox TxtDescription;
        private TextBox TxtCategoryName;
        private TextBox TxtCategoryId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button BtnCategorySave;
        private Button BtnCategoryCancel;
        private Button BtnCategoryClose;
        private Button BtnCategoryDelete;
        private Button BtnCategoryEdit;
        private Button BtnCategoryNew;
        private DataGridView DgCategory;
    }
}