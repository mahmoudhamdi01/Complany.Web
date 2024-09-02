using Company.repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Complany.Web.Controllers
{
	public class DepartmentController : Controller
	{
		private readonly IDepartmentRepository departmentRepository;

		public DepartmentController(IDepartmentRepository _departmentRepository) 
		{
			departmentRepository = _departmentRepository;
		}
		public IActionResult Index()
		{
			var department = departmentRepository.All();
			return View(department);
		}
	}
}
