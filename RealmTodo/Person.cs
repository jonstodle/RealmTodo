using System;
using System.Linq;
using Realms;

namespace RealmTodo
{
	public class Person : RealmObject
	{
		[PrimaryKey]
		public string Id
		{
			get;
			set;
		} = Guid.NewGuid().ToString();

		[Indexed]
		public string Name
		{
			get;
			set;
		}

		[Backlink(nameof(Todo.Assignee))]
		public IQueryable<Todo> Todos
		{
			get;
		}
	}
}
