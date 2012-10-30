using NUnit.Framework;
using Model;
using System;
using Relax;

namespace Test
{
	[TestFixture()]
	public class Test
	{
		private Abastecimento ab = null;
		private Config cf = null;
		private ActiveRecord ar = null;
		public class Car { public int Color { get; set; } }
		public class Person { public string Name { get; set; } }


		[SetUp]
		public void Init()
		{
			cf = Config.Instance;
			cf.ConnectionString = "Data Source=banco.db,version=3";
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
			ab.IdAbastecimento = 90;
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
			foreach (string s in ab.Fields)
				Console.WriteLine(s);
		}


		[Test()]
		public void TestClassName()
		{
			Assert.AreEqual(ab.EntityName(), "Abastecimento");
			Console.WriteLine(ab.EntityName());
		}






	}
}

