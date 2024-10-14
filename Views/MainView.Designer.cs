namespace Supermarket_mvp.Views
{
    partial class MainView
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
            BtnCategory = new Button();
            BtnCustomers = new Button();
            BtnProduct = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCategory);
            panel1.Controls.Add(BtnCustomers);
            panel1.Controls.Add(BtnProduct);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 543);
            panel1.TabIndex = 0;
            // 
            // BtnCategory
            // 
            BtnCategory.BackgroundImage = Properties.Resources.categorias;
            BtnCategory.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategory.Location = new Point(0, 352);
            BtnCategory.Name = "BtnCategory";
            BtnCategory.Size = new Size(200, 98);
            BtnCategory.TabIndex = 5;
            BtnCategory.TextAlign = ContentAlignment.MiddleRight;
            BtnCategory.UseVisualStyleBackColor = true;
            BtnCategory.Click += BtnCategory_Click;
            // 
            // BtnCustomers
            // 
            BtnCustomers.BackgroundImage = Properties.Resources.providers;
            BtnCustomers.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCustomers.Location = new Point(0, 260);
            BtnCustomers.Name = "BtnCustomers";
            BtnCustomers.Size = new Size(200, 98);
            BtnCustomers.TabIndex = 4;
            BtnCustomers.TextAlign = ContentAlignment.MiddleRight;
            BtnCustomers.UseVisualStyleBackColor = true;
            BtnCustomers.Click += BtnCustomers_Click;
            // 
            // BtnProduct
            // 
            BtnProduct.BackgroundImage = Properties.Resources.products;
            BtnProduct.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProduct.Location = new Point(0, 165);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new Size(200, 98);
            BtnProduct.TabIndex = 3;
            BtnProduct.TextAlign = ContentAlignment.MiddleRight;
            BtnProduct.UseVisualStyleBackColor = true;
            BtnProduct.Click += BtnProduct_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.salida;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 448);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(200, 95);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(0, 70);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(200, 98);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.TextAlign = ContentAlignment.MiddleLeft;
            BtnPayMode.UseVisualStyleBackColor = true;
            BtnPayMode.Click += BtnPayMode_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 543);
            Controls.Add(panel1);
            Name = "MainView";
            Text = "Supermarket";
            TransparencyKey = Color.Black;
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnCustomers;
        private Button BtnProduct;
        private Button BtnCategory;
    }
}