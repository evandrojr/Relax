using System;
using Relax;


namespace Model
{
	public class Abastecimento : ActiveRecord
	{
		public Abastecimento ()
		{
			PrimaryKey = "IdAbastecimento";
			IntFieldAdd("Horimetro");
			IntFieldAdd("IdEquipamento");
		}

		public int IdAbastecimento{ get; set; } 
		public double Horimetro{ get; set; } 
		public int IdEquipamento{ get; set; } 


	}
}

