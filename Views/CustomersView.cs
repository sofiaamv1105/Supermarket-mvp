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
    public partial class CustomersView : Form, ICustomersView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public CustomersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageCustomersDetail);
            BtnCustomersClose.Click += delegate { this.Close(); };
        }
        private void AssociateAndRaiseViewEvents()
        {
            BtnCustomersSearch.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            TxtCustomersSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnCustomersNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                ClearFields();
                tabControl1.TabPages.Remove(tabPageCustomersList);
                tabControl1.TabPages.Add(tabPageCustomersDetail);
                tabPageCustomersDetail.Text = "Add New Customer";
            };

            BtnCustomersEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCustomersList);
                tabControl1.TabPages.Add(tabPageCustomersDetail);
                tabPageCustomersDetail.Text = "Edit Customer";
            };

            BtnCustomersDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Customer?",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            BtnCustomersSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageCustomersDetail);
                    tabControl1.TabPages.Add(tabPageCustomersList);
                    ClearFields();
                }

                MessageBox.Show(Message);
            };

            BtnCustomersCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCustomersDetail);
                tabControl1.TabPages.Add(tabPageCustomersList);
            };
        }


        public string CustomerId
        {
            get { return TxtCustomersId.Text; }
            set { TxtCustomersId.Text = value; }
        }

        public string DocumentNumber
        {
            get { return TxtCustomersDoc.Text; }
            set { TxtCustomersDoc.Text = value; }
        }

        public string FirstName
        {
            get { return TxtCustomersName.Text; }
            set { TxtCustomersName.Text = value; }
        }

        public string LastName
        {
            get { return TxtCustomersLast.Text; }
            set { TxtCustomersLast.Text = value; }
        }

        public string Address
        {
            get { return TxtCustomersAddress.Text; }
            set { TxtCustomersAddress.Text = value; }
        }

        public DateTime Birthday
        {
            get { return dtpBirthday.Value; }
            set { dtpBirthday.Value = value; }
        }

        public string PhoneNumber
        {
            get { return TxtCustomersPhone.Text; }
            set { TxtCustomersPhone.Text = value; }
        }

        public string Email
        {
            get { return TxtCustomersEmail.Text; }
            set { TxtCustomersEmail.Text = value; }
        }

        public string SearchValue
        {
            get { return TxtCustomersSearch.Text; }
            set { TxtCustomersSearch.Text = value; }
        }

        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetCustomersListBindingSource(BindingSource customersList)
        {
            DgCustomers.DataSource = customersList;
        }
        public void Show()
        {
            base.Show();
        }
        private static CustomersView instance;

        public static CustomersView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomersView();
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
        public void ClearFields()
        {
            CustomerId = "0";
            DocumentNumber = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Address = string.Empty;
            Birthday = DateTime.Today;
            PhoneNumber = string.Empty;
            Email = string.Empty;
        }
    }
}
