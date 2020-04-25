﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;


namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {

        private GridViewColumnHeader nameCol = null;

        private CollectionView view = null;

        public SecondWindow()
        {
            InitializeComponent();
            var users = new List<Models.User>();
            users.Add(new Models.User { Name = "Dave", Password = "1DavePwd" });
            users.Add(new Models.User { Name = "Steve", Password = "2StevePwd" });
            users.Add(new Models.User { Name = "Lisa", Password = "3LisaPwd" });

            uxList.ItemsSource = users;
            view = (CollectionView)CollectionViewSource.GetDefaultView(uxList.ItemsSource);
        }

		private void name_Click(object sender, RoutedEventArgs e)
		{
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }

        private void password_Click (object sender, RoutedEventArgs e)
        {
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new SortDescription("Password", ListSortDirection.Ascending));
        }
	}
}
