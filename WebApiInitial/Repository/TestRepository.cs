using WebApiInitial.Data;
using WebApiInitial.Interfaces;
using WebApiInitial.Model;

namespace WebApiInitial.Repository
{
	public class TestRepository : ITestRepository
	{
		public bool AddTest(TestModel model)
		{
			Database.testList.Add(model);
			return true;
		}

		public bool DeleteTest(TestModel model)
		{
			return Database.testList.Remove(model);
		}

		public IEnumerable<TestModel> GetAllTests()
		{
			return Database.testList;
		}

		public TestModel? GetTestById(int id)
		{
			return Database.testList.FirstOrDefault(x => x.Id == id);
		}

		public bool UpdateTest(TestModel model)
		{
			throw new NotImplementedException();
		}
	}
}
