using System;

namespace Relax
{
	using System;
	
	public sealed class Config
	{
		private static volatile Config instance;
		private static object syncRoot = new Object();
		
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


		public string ConnectionString = null;


	}
}



