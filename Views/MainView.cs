using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            BtnExit.Click += delegate { this.Close(); };
        }

        private void BtnExit_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnPayMode_Click(object sender, EventArgs e)
        {
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            BtnProduct.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            BtnCategory.Click += delegate { ShowCategoryView?.Invoke(this, EventArgs.Empty); };
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            BtnCustomers.Click += delegate { ShowCustomersView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowCustomersView;
        public event EventHandler ShowCategoryView;
    }
}
