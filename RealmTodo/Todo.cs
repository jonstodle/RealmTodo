using System;
using Realms;

namespace RealmTodo
{
	public class Todo : RealmObject
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

		public bool IsDone
		{
			get;
			set;
		}

		public Person Assignee
		{
			get;
			set;
		}
	}
}
