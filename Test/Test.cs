using NUnit.Framework;
using Model;
using System;
using System.IO;
using Relax;

namespace Test
{
	[TestFixture()]
	public class Test
	{
		private Abastecimento ab = null;
		private Config cf = null;
		private ActiveRecord ar = null;
		string dataBaseFile = "relax.db3";
		bool runOnce = false;

		[SetUp]
		public void Init()
		{
			if(File.Exists(dataBaseFile) && !runOnce){
				File.Delete(dataBaseFile);

			}
			cf = Config.Instance;
			cf.ConnectionString = dataBaseFile;
			ar = new ActiveRecord();
			ab = new Abastecimento();


			runOnce = true;
		}

		[Test()]
		public void TestCase ()
		{
			ab = new Abastecimento();
		}


		public void FillVars ()
		{
			ab.Horimetro = 73.32;
			ab.Equipamento = 5;
			ab.Operador = 9;
			ab.Objeto = 9494;
			ab.Tanque = 5;
			ab.Funcionario = 704;
			ab.TipoDerivador = 2;
			ab.Quantidade = 435.53;
			ab.Data = DateTime.Now;
			ab.Hora = "10:43:52";
		}


		public void FillWithNulls ()
		{
			ab.Horimetro = 73.32;
			ab.Equipamento = 5;
			//ab.Operador = 9;
			ab.Objeto = 9494;
			ab.Tanque = 5;
			//ab.Funcionario = 704;
			ab.TipoDerivador = 2;
			ab.Quantidade = 435.53;
			//ab.Data = DateTime.Now;
			ab.Hora = "10:43:52";
		}




		[Test()]
		public void TestSingleton ()
		{
			Assert.AreEqual(ab.Config.ConnectionString, cf.ConnectionString);
			Console.WriteLine(ab.Config.ConnectionString);
		}

		[Test()]
		public void TestEntidadeAbastecimento()
		{
			Abastecimento ab =  new Abastecimento();
			foreach (Field f in ab.Fields)
				Console.WriteLine(f.Name);
		}


		[Test()]
		public void TestClassName()
		{
			Assert.AreEqual(ab.Name, "Abastecimento");
			Console.WriteLine(ab.Name);
		}

		[Test()]
		public void TestCreateTable()
		{
			Console.WriteLine(ab.CreateTable());
		}


		[Test()]
		public void TestSave ()
		{
			FillVars();
			ab.Save();

		}


		[Test()]
		public void TestSaveWithNulls ()
		{
			FillWithNulls();
			ab.Save();
		}



	}
}

