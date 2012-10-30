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

		public ActiveRecord ()
		{
			if(Config.Instance == null)
				throw new Exception ("Null configuration for the ActiveRecord");
			Config=Config.Instance;
		}

		public void FieldAdd(string field){
			Fields.Add(field);
		}


		public void StringFieldAdd (String name, int size)
		{
			Field f = new Field();
			f.Type = Field.FieldType.String;
			f.Name = name;
			f.Size = size;
			Fields.Add(f);
		}


		public void IntFieldAdd (String name, int size)
		{
			Field f = new Field();
			f.Type = Field.FieldType.Int;
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

		public string EntityName(){
			return this.GetType().Name;
		}




	}
}

