using System;

namespace Relax
{
	using System;
	
	public sealed class Config
	{
		private static volatile Config instance;
		private static object syncRoot = new Object();
		public string ConnectionString = null;
		public System.Globalization.CultureInfo CuEnUk = new System.Globalization.CultureInfo("en-GB");


		private Config() {}
		
		public static Config Instance
		{
			get 
			{
				if (instance == null) 
				{
					lock (syncRoot) 
					{
						if (instance == null) 
							instance = new Config();
					}
				}
				
				return instance;
			}
		}




	}
}



