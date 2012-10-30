using System;
using System.Reflection;
using System.Collections.Generic;

namespace Relax
{
	public class ActiveRecord
	{
		public Config Config = null;
		public string PrimaryKey;
		public List<ActiveRecord> HasMany = new List<ActiveRecord>();
		public List<Field> Fields = new List<Field>();
		public Table Table;


		public ActiveRecord ()
		{
			if(Config.Instance == null)
				throw new Exception ("Null configuration for the ActiveRecord");
			Config=Config.Instance;
			Table = new Table(this);
		}

		public void StringFieldAdd (String name, int size)
		{
			Field f = new Field();
			f.Type = Field.FieldType.String;
			f.Name = name;
			f.Size = size;
			Fields.Add(f);
		}

		public string CreateTable(){
			return Table.Create();
		}

		public void IntFieldAdd (String name)
		{
			Field f = new Field();
			f.Type = Field.FieldType.Integer;
			f.Name = name;
			Fields.Add(f);
		}

		public void RealFieldAdd (String name, int size)
		{
			Field f = new Field();
			f.Type = Field.FieldType.Real;
			f.Name = name;
			Fields.Add(f);
		}

		public void GetAll(){

		}

		public string Name{
				get{return this.GetType().Name;}
		}




	}
}

