using System;
using System.Data;
using SQLite;


namespace Relax
{
	public class Db
	{
		static string conStr = Config.Instance.ConnectionString;

		public Db ()
		{
		}

		static public int ExecuteNonQuery(string sql)
		{
			using(SQLiteConnection Con = new SQLiteConnection(conStr))
			{
				return	Con.Execute(sql);
			}
		}

	}
}

