using System;

namespace Relax
{
	public class Field
	{
		public bool IsPrimaryKey = false;
		public string Name;
		public FieldType Type;
		public int Size;
		public bool MayBeNull;

		public enum FieldType{
			Int,
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

