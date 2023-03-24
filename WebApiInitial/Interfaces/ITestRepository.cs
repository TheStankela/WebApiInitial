using WebApiInitial.Model;

namespace WebApiInitial.Interfaces
{
	public interface ITestRepository
	{
		IEnumerable<TestModel> GetAllTests();
		TestModel GetTestById(int id);
		bool AddTest(TestModel model);
		bool UpdateTest(TestModel model);
		bool DeleteTest(TestModel model);
	}
}
