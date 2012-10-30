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
				runOnce = true;
			}
			cf = Config.Instance;
			cf.ConnectionString = dataBaseFile;
			ar = new ActiveRecord();
		}

		[Test()]
		public void TestCase ()
		{
			ab = new Abastecimento();
		}

		[Test()]
		public void TestFillVars ()
		{
			ab.Horimetro = 73.32;
			ab.IdEquipamento = 5;
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




	}
}

