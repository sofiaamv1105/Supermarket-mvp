using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;
using Supermarket_mvp._Repositories;
using Supermarket_mvp.Presenters;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace Supermarket_mvp.Presenters
{
    internal class CustomersPresenter
    {
        private ICustomersView view;
        private ICustomerRepository repository;
        private BindingSource customersBindingSource;
        private IEnumerable<CustomersModel> customersList;

        public CustomersPresenter(ICustomersView view, ICustomerRepository repository)
        {
            this.customersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomers;
            this.view.AddNewEvent += AddNewCustomers;
            this.view.EditEvent += LoadSelectedCustomerToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomersListBindingSource(customersBindingSource);
            LoadAllCustomersList();
            this.view.Show();
        }

        private void LoadAllCustomersList()
        {
            customersList = repository.GetAll();
            customersBindingSource.DataSource = customersList;
        }

        private void SearchCustomers(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!emptyValue)
            {
                customersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customersList = repository.GetAll();
            }
            customersBindingSource.DataSource = customersList;
        }

        private void AddNewCustomers(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectedCustomerToEdit(object? sender, EventArgs e)
        {
            var customer = (CustomersModel)customersBindingSource.Current;

            view.CustomerId = customer.Customer_Id.ToString();
            view.DocumentNumber = customer.Document_Number;
            view.FirstName = customer.First_Name;
            view.LastName = customer.Last_Name;
            view.Address = customer.Address;
            view.Birthday = customer.Birthday;  // Asumimos que tienes un DateTimePicker
            view.PhoneNumber = customer.Phone_Number;
            view.Email = customer.Email;

            view.IsEdit = true;
        }

        private void DeleteSelectedCustomer(object? sender, EventArgs e)
        {
            try
            {
                var customer = (CustomersModel)customersBindingSource.Current;
                repository.Delete(customer.Customer_Id);
                view.IsSuccessful = true;
                view.Message = "Customer deleted successfully";
                LoadAllCustomersList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void SaveCustomer(object? sender, EventArgs e)
        {
            var customer = new CustomersModel
            {
                Customer_Id = string.IsNullOrEmpty(view.CustomerId) ? 0 : Convert.ToInt32(view.CustomerId),
                Document_Number = view.DocumentNumber,
                First_Name = view.FirstName,
                Last_Name = view.LastName,
                Address = view.Address,
                Birthday = view.Birthday,
                Phone_Number = view.PhoneNumber,
                Email = view.Email
            };

            try
            {
                if (view.IsEdit)
                {
                    repository.Edit(customer);
                    view.Message = "Customer edited successfully";
                }
                else
                {
                    repository.Add(customer);
                    view.Message = "Customer added successfully";
                }

                view.IsSuccessful = true;
                LoadAllCustomersList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            LoadAllCustomersList();

        }
        private void ClearSearchField()
        {
            view.SearchValue = string.Empty;
        }

    }
}
