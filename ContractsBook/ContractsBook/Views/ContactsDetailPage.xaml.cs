using System;
using System.Collections.Generic;
using ContractsBook.ViewModels;
using Xamarin.Forms;

namespace ContractsBook.Views
{
    public partial class ContactsDetailPage : ContentPage
    {
        public ContactsDetailPage(ContactViewModel viewModel)
        {
            InitializeComponent();
        }
    }
}

