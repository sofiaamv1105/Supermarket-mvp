using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface ICustomersView
    {
        string CustomerId { get; set; }
        string DocumentNumber { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        DateTime Birthday { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetCustomersListBindingSource(BindingSource customersList);
        void Show();
    }
}
