using System;

namespace Relax
{
	public class Table
	{

		public ActiveRecord Entity;
		public string Name{get{return Entity.Name;}}

		public Table (ActiveRecord entity)
		{
			Entity = entity;
		}

		public string Create ()
		{
			string notNull;
			string s = "Create table " + Name + " (" + Environment.NewLine;
			s += " Id INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT," + Environment.NewLine;
			foreach (Field f in Entity.Fields) {
				notNull = f.NotNull ? " NOT NULL" : "";
				s += f.Name + " " + f.Type.ToString() + notNull + "," + Environment.NewLine;
			}
			s = s.Substring(0, s.Length - 1 - Environment.NewLine.Length);
			s +=")";
			Db.ExecuteNonQuery(s);
			return s;
		}



	}
}

