namespace Supermarket_mvp.Views
{
    partial class CustomersView
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
            tabPageCustomersList = new TabPage();
            BtnCustomersClose = new Button();
            BtnCustomersDelete = new Button();
            BtnCustomersEdit = new Button();
            BtnCustomersNew = new Button();
            DgCustomers = new DataGridView();
            TxtCustomersSearch = new TextBox();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnCustomersSearch = new Button();
            label2 = new Label();
            tabPageCustomersDetail = new TabPage();
            TxtCustomersEmail = new TextBox();
            label10 = new Label();
            TxtCustomersPhone = new TextBox();
            label9 = new Label();
            label8 = new Label();
            TxtCustomersAddress = new TextBox();
            label7 = new Label();
            TxtCustomersDoc = new TextBox();
            label6 = new Label();
            BtnCustomersCancel = new Button();
            BtnCustomersSave = new Button();
            TxtCustomersName = new TextBox();
            TxtCustomersLast = new TextBox();
            TxtCustomersId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dtpBirthday = new DateTimePicker();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).BeginInit();
            tabPageCustomersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 99);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.user_interface;
            pictureBox1.Location = new Point(36, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 0);
            label1.Name = "label1";
            label1.Size = new Size(400, 93);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomersList);
            tabControl1.Controls.Add(tabPageCustomersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 99);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 351);
            tabControl1.TabIndex = 3;
            // 
            // tabPageCustomersList
            // 
            tabPageCustomersList.Controls.Add(BtnCustomersClose);
            tabPageCustomersList.Controls.Add(BtnCustomersDelete);
            tabPageCustomersList.Controls.Add(BtnCustomersEdit);
            tabPageCustomersList.Controls.Add(BtnCustomersNew);
            tabPageCustomersList.Controls.Add(DgCustomers);
            tabPageCustomersList.Controls.Add(TxtCustomersSearch);
            tabPageCustomersList.Controls.Add(BtnClose);
            tabPageCustomersList.Controls.Add(BtnDelete);
            tabPageCustomersList.Controls.Add(BtnEdit);
            tabPageCustomersList.Controls.Add(BtnNew);
            tabPageCustomersList.Controls.Add(BtnCustomersSearch);
            tabPageCustomersList.Controls.Add(label2);
            tabPageCustomersList.Location = new Point(4, 24);
            tabPageCustomersList.Name = "tabPageCustomersList";
            tabPageCustomersList.Padding = new Padding(3);
            tabPageCustomersList.Size = new Size(792, 323);
            tabPageCustomersList.TabIndex = 0;
            tabPageCustomersList.Text = "Customers List";
            tabPageCustomersList.UseVisualStyleBackColor = true;
            // 
            // BtnCustomersClose
            // 
            BtnCustomersClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCustomersClose.Image = Properties.Resources.cerrar;
            BtnCustomersClose.Location = new Point(577, 247);
            BtnCustomersClose.Name = "BtnCustomersClose";
            BtnCustomersClose.Size = new Size(182, 55);
            BtnCustomersClose.TabIndex = 13;
            BtnCustomersClose.UseVisualStyleBackColor = true;
            // 
            // BtnCustomersDelete
            // 
            BtnCustomersDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCustomersDelete.Image = Properties.Resources.delete;
            BtnCustomersDelete.Location = new Point(577, 186);
            BtnCustomersDelete.Name = "BtnCustomersDelete";
            BtnCustomersDelete.Size = new Size(182, 55);
            BtnCustomersDelete.TabIndex = 12;
            BtnCustomersDelete.UseVisualStyleBackColor = true;
            // 
            // BtnCustomersEdit
            // 
            BtnCustomersEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCustomersEdit.Image = Properties.Resources.edit;
            BtnCustomersEdit.Location = new Point(577, 125);
            BtnCustomersEdit.Name = "BtnCustomersEdit";
            BtnCustomersEdit.Size = new Size(182, 55);
            BtnCustomersEdit.TabIndex = 11;
            BtnCustomersEdit.UseVisualStyleBackColor = true;
            // 
            // BtnCustomersNew
            // 
            BtnCustomersNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCustomersNew.Image = Properties.Resources._new;
            BtnCustomersNew.Location = new Point(577, 64);
            BtnCustomersNew.Name = "BtnCustomersNew";
            BtnCustomersNew.Size = new Size(182, 55);
            BtnCustomersNew.TabIndex = 10;
            BtnCustomersNew.UseVisualStyleBackColor = true;
            // 
            // DgCustomers
            // 
            DgCustomers.AllowUserToAddRows = false;
            DgCustomers.AllowUserToDeleteRows = false;
            DgCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomers.BackgroundColor = SystemColors.GradientInactiveCaption;
            DgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomers.Location = new Point(35, 64);
            DgCustomers.Name = "DgCustomers";
            DgCustomers.ReadOnly = true;
            DgCustomers.Size = new Size(536, 238);
            DgCustomers.TabIndex = 9;
            // 
            // TxtCustomersSearch
            // 
            TxtCustomersSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtCustomersSearch.Location = new Point(35, 35);
            TxtCustomersSearch.Name = "TxtCustomersSearch";
            TxtCustomersSearch.PlaceholderText = "Data to search";
            TxtCustomersSearch.Size = new Size(428, 23);
            TxtCustomersSearch.TabIndex = 8;
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
            // BtnCustomersSearch
            // 
            BtnCustomersSearch.Image = Properties.Resources.search_small;
            BtnCustomersSearch.Location = new Point(466, 17);
            BtnCustomersSearch.Name = "BtnCustomersSearch";
            BtnCustomersSearch.Size = new Size(49, 41);
            BtnCustomersSearch.TabIndex = 2;
            BtnCustomersSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 20);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Cutomers";
            // 
            // tabPageCustomersDetail
            // 
            tabPageCustomersDetail.Controls.Add(dtpBirthday);
            tabPageCustomersDetail.Controls.Add(TxtCustomersEmail);
            tabPageCustomersDetail.Controls.Add(label10);
            tabPageCustomersDetail.Controls.Add(TxtCustomersPhone);
            tabPageCustomersDetail.Controls.Add(label9);
            tabPageCustomersDetail.Controls.Add(label8);
            tabPageCustomersDetail.Controls.Add(TxtCustomersAddress);
            tabPageCustomersDetail.Controls.Add(label7);
            tabPageCustomersDetail.Controls.Add(TxtCustomersDoc);
            tabPageCustomersDetail.Controls.Add(label6);
            tabPageCustomersDetail.Controls.Add(BtnCustomersCancel);
            tabPageCustomersDetail.Controls.Add(BtnCustomersSave);
            tabPageCustomersDetail.Controls.Add(TxtCustomersName);
            tabPageCustomersDetail.Controls.Add(TxtCustomersLast);
            tabPageCustomersDetail.Controls.Add(TxtCustomersId);
            tabPageCustomersDetail.Controls.Add(label5);
            tabPageCustomersDetail.Controls.Add(label4);
            tabPageCustomersDetail.Controls.Add(label3);
            tabPageCustomersDetail.Location = new Point(4, 24);
            tabPageCustomersDetail.Name = "tabPageCustomersDetail";
            tabPageCustomersDetail.Padding = new Padding(3);
            tabPageCustomersDetail.Size = new Size(792, 323);
            tabPageCustomersDetail.TabIndex = 1;
            tabPageCustomersDetail.Text = "Customers Detail";
            tabPageCustomersDetail.UseVisualStyleBackColor = true;
            // 
            // TxtCustomersEmail
            // 
            TxtCustomersEmail.Location = new Point(379, 206);
            TxtCustomersEmail.Name = "TxtCustomersEmail";
            TxtCustomersEmail.PlaceholderText = "Customer Email";
            TxtCustomersEmail.Size = new Size(307, 23);
            TxtCustomersEmail.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(379, 188);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 16;
            label10.Text = "Customers Email";
            // 
            // TxtCustomersPhone
            // 
            TxtCustomersPhone.Location = new Point(379, 147);
            TxtCustomersPhone.Name = "TxtCustomersPhone";
            TxtCustomersPhone.PlaceholderText = "Customer Phone";
            TxtCustomersPhone.Size = new Size(307, 23);
            TxtCustomersPhone.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(379, 129);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 14;
            label9.Text = "Customers Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(379, 73);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 12;
            label8.Text = "Customers Birthday";
            // 
            // TxtCustomersAddress
            // 
            TxtCustomersAddress.Location = new Point(379, 34);
            TxtCustomersAddress.Name = "TxtCustomersAddress";
            TxtCustomersAddress.PlaceholderText = "Customer Address";
            TxtCustomersAddress.Size = new Size(307, 23);
            TxtCustomersAddress.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(379, 16);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 10;
            label7.Text = "Customers Address";
            // 
            // TxtCustomersDoc
            // 
            TxtCustomersDoc.Location = new Point(47, 91);
            TxtCustomersDoc.Name = "TxtCustomersDoc";
            TxtCustomersDoc.PlaceholderText = "Customer Document";
            TxtCustomersDoc.Size = new Size(307, 23);
            TxtCustomersDoc.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 73);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 8;
            label6.Text = "Customers Document";
            // 
            // BtnCustomersCancel
            // 
            BtnCustomersCancel.Image = Properties.Resources.cancel;
            BtnCustomersCancel.Location = new Point(194, 260);
            BtnCustomersCancel.Name = "BtnCustomersCancel";
            BtnCustomersCancel.Size = new Size(106, 41);
            BtnCustomersCancel.TabIndex = 7;
            BtnCustomersCancel.UseVisualStyleBackColor = true;
            // 
            // BtnCustomersSave
            // 
            BtnCustomersSave.Image = Properties.Resources.save;
            BtnCustomersSave.Location = new Point(47, 260);
            BtnCustomersSave.Name = "BtnCustomersSave";
            BtnCustomersSave.Size = new Size(106, 41);
            BtnCustomersSave.TabIndex = 6;
            BtnCustomersSave.UseVisualStyleBackColor = true;
            // 
            // TxtCustomersName
            // 
            TxtCustomersName.Location = new Point(47, 147);
            TxtCustomersName.Name = "TxtCustomersName";
            TxtCustomersName.PlaceholderText = "Customer Name";
            TxtCustomersName.Size = new Size(307, 23);
            TxtCustomersName.TabIndex = 5;
            // 
            // TxtCustomersLast
            // 
            TxtCustomersLast.Location = new Point(47, 206);
            TxtCustomersLast.Name = "TxtCustomersLast";
            TxtCustomersLast.PlaceholderText = "Customer Last Name";
            TxtCustomersLast.Size = new Size(307, 23);
            TxtCustomersLast.TabIndex = 4;
            // 
            // TxtCustomersId
            // 
            TxtCustomersId.Location = new Point(47, 34);
            TxtCustomersId.Name = "TxtCustomersId";
            TxtCustomersId.ReadOnly = true;
            TxtCustomersId.Size = new Size(198, 23);
            TxtCustomersId.TabIndex = 3;
            TxtCustomersId.Text = "0";
            TxtCustomersId.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 188);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 2;
            label5.Text = "Customers Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 129);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 1;
            label4.Text = "Customers Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 19);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 0;
            label3.Text = "Customers Id";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(379, 91);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 18;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // CustomersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomersView";
            Text = "Customers Management";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomersList.ResumeLayout(false);
            tabPageCustomersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).EndInit();
            tabPageCustomersDetail.ResumeLayout(false);
            tabPageCustomersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCustomersList;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        public Button BtnCustomersSearch;
        private Label label2;
        private TabPage tabPageCustomersDetail;
        private Button BtnCustomersCancel;
        private Button BtnCustomersSave;
        private TextBox TxtCustomersName;
        private TextBox TxtCustomersLast;
        private TextBox TxtCustomersId;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtCustomersSearch;
        private DataGridView DgCustomers;
        private Button BtnCustomersClose;
        private Button BtnCustomersDelete;
        private Button BtnCustomersEdit;
        private Button BtnCustomersNew;
        private TextBox TxtCustomersDoc;
        private Label label6;
        private TextBox TxtCustomersEmail;
        private Label label10;
        private TextBox TxtCustomersPhone;
        private Label label9;
        private Label label8;
        private TextBox TxtCustomersAddress;
        private Label label7;
        private DateTimePicker dtpBirthday;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}