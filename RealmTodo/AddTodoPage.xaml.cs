using System;
using System.Collections.Generic;
using Realms;
using Xamarin.Forms;

namespace RealmTodo
{
	public partial class AddTodoPage : ContentPage
	{
		public AddTodoPage()
		{
			InitializeComponent();
		}

		void SaveToolbarItem_Clicked(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(NameEntry.Text)) return;
			// TODO: Add todo to Realm
		}
	}
}
