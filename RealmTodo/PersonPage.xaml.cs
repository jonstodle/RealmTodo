﻿using System;
using System.Collections.Generic;
using System.Linq;
using Realms;
using Xamarin.Forms;

namespace RealmTodo
{
	public partial class PersonPage : ContentPage
	{
		public PersonPage(Person person)
		{
			InitializeComponent();

			this.person = person;
			Title = person.Name;
			TodoListView.ItemsSource = App.Realm.All<Todo>().Where(x => x.Assignee == person).OrderBy(x => x.Name).AsRealmCollection();
		}

		async void AddTodoToolbarItem_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new AddTodoPage(person));
		}

		void TodoListView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			var todo = e.Item as Todo;
			App.Realm.Write(() => todo.IsDone = !todo.IsDone);
		}

		Person person;
	}
}
