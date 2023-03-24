using WebApiInitial.Model;

namespace WebApiInitial.Data
{
	public static class Database
	{
		public static List<TestModel> testList = new List<TestModel>
			{
				new TestModel {Id = 1, Name = "Test 1"},
				new TestModel {Id = 2, Name = "Test 2"},
				new TestModel {Id = 3, Name = "Test 3"},
				new TestModel {Id = 4, Name = "Test 4"},
				new TestModel {Id = 5, Name = "Test 5"}
			};
	}
}
