using System;
using Relax;


namespace Model
{
	public class Abastecimento : ActiveRecord
	{
		public Abastecimento ()
		{
			IntFieldAdd("Objeto");
			IntFieldAdd("Tanque");
			IntFieldAdd("Funcionario");
			IntFieldAdd("Operador");
			IntFieldAdd("Equipamento");
			RealFieldAdd("Horimetro");
			IntFieldAdd("TipoDerivador");
			RealFieldAdd("Quantidade");
			DateFieldAdd("Data");
			TimeFieldAdd("Hora");
		}


		public int Objeto{ get; set; } 
		public int Tanque{ get; set; } 
		public int? Funcionario{ get; set; } 
		public int? Operador{ get; set; } 
		public int Equipamento{ get; set; } 

		public double Horimetro{ get; set; } 
		public int TipoDerivador{ get; set; } 
		public double? Quantidade{ get; set; } 

		public DateTime? Data{ get; set; } 
		public string Hora{ get; set; } 


	}
}

