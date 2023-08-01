using System;
namespace Service
{
	public interface IAPIService
	{
		Task<string> GetTestInfo();
	}
}

