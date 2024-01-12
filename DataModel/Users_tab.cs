using System;
using SQLite;

namespace BusyZone.DataModel
{
	public class Users_tab
	{
		[PrimaryKey]
		public int user_id { get; set; }
		public string firstname { get; set; }
		public string lastname { get; set; }
        [Unique]
		public string email { get; set; }
		public string telephone { get; set; }
		public string password { get; set; }
		public string user_token { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }
	}
}

