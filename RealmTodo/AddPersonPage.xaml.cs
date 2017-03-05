using System;
using System.Collections.Generic;
using Realms;
using Xamarin.Forms;

namespace RealmTodo
{
	public partial class AddPersonPage : ContentPage
	{
		public AddPersonPage()
		{
			InitializeComponent();
		}

		void SaveToolbarItem_Clicked(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(NameEntry.Text)) return;
			// TODO: Add person to Realm
		}
	}
}
