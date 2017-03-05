using System;
using System.Collections.Generic;
using System.Linq;
using Realms;
using Xamarin.Forms;

namespace RealmTodo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		async void AddPersonToolbarItem_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new AddPersonPage());
		}

		void PersonListView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			// TODO: Navigate to person page
		}
	}
}
