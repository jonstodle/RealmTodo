using System;
using System.Collections.Generic;
using Realms;
using Xamarin.Forms;

namespace RealmTodo
{
	public partial class AddTodoPage : ContentPage
	{
		public AddTodoPage(Person person)
		{
			InitializeComponent();

			this.person = person;
		}

		void SaveToolbarItem_Clicked(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(NameEntry.Text)) return;
			App.Realm.Write(() => App.Realm.Add(new Todo { Name = NameEntry.Text, Assignee = person }));
		}

		Person person;
	}
}
