using System.Collections.Generic;

namespace Warehouse
{
	public interface IDatabase
	{
		public void Save();
		public void Update();
		public void Delete();
	}
}