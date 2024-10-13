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
    public partial class ProductView : Form, IProductView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageProductDetail);
            BtnProductClose.Click += delegate { this.Close(); };
        }
        private void AssociateAndRaiseViewEvents()
        {
            BtnProductSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtProductSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            BtnProductNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabPageProductDetail.Text = "Add New Product";
            };

            BtnProductEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabPageProductDetail.Text = "Edit Product";
            };

            BtnProductDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Product?",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);

                    MessageBox.Show(Message);

                }
            };
            BtnProductSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Add(tabPageProductList);
                    tabControl1.TabPages.Remove(tabPageProductDetail);

                }

                MessageBox.Show(Message);
            };

            BtnProductCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductDetail);
                tabControl1.TabPages.Add(tabPageProductList);

            };
        }

        public void SetProductListBindingSource(BindingSource productList)
        {
            DgProducts.DataSource = productList;
        }

        private static ProductView instance;

        public static PayModeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
        public int ProductId
        {
            get { return int.Parse(TxtProductId.Text); }
            set { TxtProductId.Text = value.ToString(); }
        }
        string IProductView.ProductName
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }
        }
        public decimal ProductPrice
        {
            get { return decimal.Parse(TxtProductPrice.Text); }
            set { TxtProductPrice.Text = value.ToString("0.00"); }
        }
        public int ProductStock
        {
            get { return int.Parse(TxtProductStock.Text); }
            set { TxtProductStock.Text = value.ToString(); }
        }
        public int CategoryId
        {
            get { return int.Parse(TxtCategoryId.Text); }
            set { TxtCategoryId.Text = value.ToString(); }
        }
        public string SearchValue
        {
            get { return TxtProductSearch.Text; }
            set { TxtProductSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
