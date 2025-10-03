using AutoMapper;
using Demo.BusnessLayerLogic.DataTransferObject.Employees;
using Demo.BusnessLayerLogic.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
    public class EmployeeController(IEmployeeService EmployeeService,
        ILogger<EmployeeController> logger,
        IWebHostEnvironment env,
        IMapper mapper) : Controller
    {


        [HttpGet]
        public IActionResult Index()
        {
            var Employee = EmployeeService.GetAll();
           // ViewData["hello"] = "hello fron index controller";
            return View(Employee);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            try
            {
                var result = EmployeeService.Add(request);
                if (result > 0)
                {
                    TempData["message"] = $"Employee {request.Name} Created";
                    return RedirectToAction(nameof(Index));

                }
                else
                {
                    TempData["message"] = $"Caan't Create Employee {request.Name}";
                    return RedirectToAction(nameof(Index));
                }
                //ModelState.AddModelError(string.Empty, "can't add Employee Now");
            }
            catch (Exception ex)
            {
                if (env.IsDevelopment())
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
                else
                {
                    logger.LogError("something wrong", ex.Message);
                }

            }

            return View(request);

        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }
            var Employee = EmployeeService.GetById(id.Value);
            if (Employee == null)
            {
                return NotFound();
            }
            return View(Employee);



        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }
            var Employee = EmployeeService.GetById(id.Value);
            if (Employee == null)
            {
                return NotFound();
            }
            return View(mapper.Map<EmployeeDetailsResponse,EmployeeUpdateRequest>(Employee));



        }
        [HttpPost]
        public IActionResult Edit([FromRoute] int? id, EmployeeUpdateRequest request)
        {

            if (!ModelState.IsValid)
            {
                return View(request);
            }
            if (id.Value != request.Id)
            {
                return BadRequest();
            }

            try
            {
                var result = EmployeeService.Update(request);
                if (result > 0)
                {
                    return RedirectToAction(nameof(Index));

                }
                ModelState.AddModelError(string.Empty, "can't add Employee Now");
            }
            catch (Exception ex)
            {
                if (env.IsDevelopment())
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
                else
                {
                    logger.LogError("something wrong", ex.Message);
                }

            }

            return View(request);

        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }
            var Employee = EmployeeService.GetById(id.Value);
            if (Employee == null)
            {
                return NotFound();
            }
            return View(Employee);

        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }

            var Employee = EmployeeService.GetById(id.Value);
            try
            {
                var IsDeleted = EmployeeService.Delete(id.Value);
                if (IsDeleted)
                {
                    return RedirectToAction(nameof(Index));

                }
                ModelState.AddModelError(string.Empty, "can't Remove Employee Now");
            }
            catch (Exception ex)
            {
                if (env.IsDevelopment())
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
                else
                {
                    logger.LogError("something wrong", ex.Message);
                }

            }

            return View(Employee);

        }




    }

}

