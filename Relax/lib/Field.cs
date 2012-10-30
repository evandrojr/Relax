using System;
using System.Collections;
using System.Collections.Generic;

namespace Relax
{
	public class Field
	{
		public bool IsPrimaryKey = false;
		public string Name;
		public FieldType Type;
		public int Size;
		public bool NotNull;


		public enum FieldType{
			Integer,
			Real,
			String,
			Date,
			Time,
			Boolean,
		}






		public Field ()
		{
		}
	}
}

