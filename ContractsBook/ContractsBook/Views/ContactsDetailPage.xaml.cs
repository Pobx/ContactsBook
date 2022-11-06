﻿using System;
using System.Collections.Generic;
using ContractsBook.Persistence;
using ContractsBook.ViewModels;
using Xamarin.Forms;

namespace ContractsBook.Views
{
    public partial class ContactsDetailPage : ContentPage
    {
        public ContactsDetailPage(ContactViewModel viewModel)
        {
            InitializeComponent();
            var contactStore = new SQLiteContactStore(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();
            Title = (viewModel.Phone == null) ? "New Contact" : "Edit Contact";
            BindingContext = new ContactsDetailViewModel(viewModel ?? new ContactViewModel(), contactStore, pageService);
        }
    }
}

