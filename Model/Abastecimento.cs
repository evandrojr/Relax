using System;
using Relax;


namespace Model
{
	public class Abastecimento : ActiveRecord
	{
		public Abastecimento ()
		{
			RealFieldAdd("Horimetro");
			IntFieldAdd("IdEquipamento");
		}


		public double Horimetro{ get; set; } 
		public int IdEquipamento{ get; set; } 


	}
}

