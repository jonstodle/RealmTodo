using System;
using System.Collections.Generic;
using System.Linq;
using Realms;
using Xamarin.Forms;

namespace RealmTodo
{
	public partial class PersonPage : ContentPage
	{
		public PersonPage()
		{
			InitializeComponent();
		}

		async void AddTodoToolbarItem_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new AddTodoPage());
		}

		void TodoListView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			// TODO: Toggle IsDone
		}
	}
}
