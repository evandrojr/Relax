using System;
using Relax;


namespace Model
{
	public class Abastecimento : ActiveRecord
	{
		public Abastecimento ()
		{
			PrimaryKey = "IdAbastecimento";
			FieldAdd("Horimetro");
			FieldAdd("IdEquipamento");
		}

		public int IdAbastecimento{ get; set; } 
		public double Horimetro{ get; set; } 
		public int IdEquipamento{ get; set; } 


	}
}

