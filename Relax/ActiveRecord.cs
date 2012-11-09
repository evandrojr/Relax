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

		public int Id{ get; set; } 

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

		public void RealFieldAdd (String name)
		{
			Field f = new Field();
			f.Type = Field.FieldType.Real;
			f.Name = name;
			Fields.Add(f);
		}

		public void DateFieldAdd (String name)
		{
			Field f = new Field();
			f.Type = Field.FieldType.Date;
			f.Name = name;
			Fields.Add(f);
		}

		public void TimeFieldAdd (String name)
		{
			Field f = new Field();
			f.Type = Field.FieldType.Time;
			f.Name = name;
			Fields.Add(f);
		}


		public void GetAll(){

		}

		public void Save ()
		{
			string fields = "Insert into " + Name + " (" + Environment.NewLine;
			string values = "(";
			object value;
			foreach (Field f in Fields) {
				fields += f.Name + ", ";
				value = GetPropValue(this, f.Name);
				if(value != null)
					values += "'" + GetPropValue(this, f.Name) + "', ";
				else
					values += "NULL, ";
			}
			fields = fields.Substring(0, fields.Length - 2);
			fields +=")";
			values = values.Substring(0, values.Length - 2);
			values +=")";
			fields+= " values " + values;
			Console.Out.WriteLine(fields);
			Db.ExecuteNonQuery(fields);
		}

		public string Name{
				get{return this.GetType().Name;}
		}


		public static object GetPropValue( object src, string propName )
		{
			if(src.GetType( ).GetProperty( propName ).GetValue( src, null ) == null)
				return null;
			Type t = src.GetType( ).GetProperty( propName ).GetValue( src, null ).GetType();
			if(t.Equals(typeof(System.DateTime) )) {
				DateTime val;
			    val = (DateTime) src.GetType( ).GetProperty( propName ).GetValue( src, null );
				return val.Year.ToString().PadLeft(4,'0') + "-" + val.Month.ToString().PadLeft(2,'0') + "-" + val.Day.ToString().PadLeft(2,'0') + " " + val.Hour.ToString().PadLeft(2,'0') + ":" + val.Minute.ToString().PadLeft(2,'0') + ":" + val.Second.ToString().PadLeft(2,'0');
			}
			else
				return Convert.ToString(src.GetType( ).GetProperty( propName ).GetValue( src, null ), Config.Instance.CuEnUk) ;
		}

	}
}

