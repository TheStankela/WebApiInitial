using Microsoft.AspNetCore.Mvc;
using WebApiInitial.Interfaces;
using WebApiInitial.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiInitial.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestController : ControllerBase
	{
		ITestRepository _testRepository;

		public TestController(ITestRepository testRepository)
		{
			_testRepository = testRepository;
		}

        [HttpGet]
		public IActionResult GetAllTests()
		{
			var tests = _testRepository.GetAllTests();
			if (tests == null)
				return NotFound();

			return Ok(tests);
		}
		[HttpGet("{id}")]
		public IActionResult GetTestById(int id)
		{
			var result = _testRepository.GetTestById(id);
			if (result == null)
				return NotFound();

			return Ok(result);
		}

		[HttpPost]
		public IActionResult AddTest([FromBody] TestModel testModel)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			if (!_testRepository.AddTest(testModel))
			{
				ModelState.AddModelError("", "Error while adding test.");
				return BadRequest(ModelState);
			}

			return Ok("Successfully added!");
		}

		[HttpDelete]
		public IActionResult DeleteTestById(int id)
		{
			var testToDelete = _testRepository.GetTestById(id);
			if (testToDelete == null)
				return NotFound("Test not found");

			if (!_testRepository.DeleteTest(testToDelete))
			{
				ModelState.AddModelError("", "Error while deleting test.");
				return BadRequest(ModelState);
			}

			return Ok("Deleted successfully");
		}
	}
}
