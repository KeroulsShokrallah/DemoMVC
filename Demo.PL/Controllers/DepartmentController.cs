using Demo.BusnessLayerLogic.DataTransferObject.Departments;
using Demo.BusnessLayerLogic.Services;
using Demo.DataAcssesLayer.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
    public class DepartmentController(IDepartmentService departmentService ,
        ILogger<DepartmentController> logger , 
        IWebHostEnvironment env) : Controller
    {
        

        [HttpGet]
        public IActionResult Index()
        {
            var department = departmentService.GetAll();
            return View(department);
        }

        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(DepartmentRequest request)
        {
            if(!ModelState.IsValid)
            {
                return View(request);
            }

            try
            {
                var result = departmentService.Add(request);
                if(result > 0)
                {
                    return RedirectToAction(nameof(Index));

                }
                ModelState.AddModelError(string.Empty, "can't add Department Now");
            }
            catch (Exception ex)
            {
                if(env.IsDevelopment())
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
            if(!id.HasValue)
            {
                return BadRequest();
            }
            var department = departmentService.GetById(id.Value);
            if(department == null)
            {
                return NotFound();
            }
            return View(department);

            

        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }
            var department = departmentService.GetById(id.Value);
            if (department == null)
            {
                return NotFound();
            }
            return View(department.ToUpdateRequest());



        }



        [HttpPost]
        public IActionResult Edit([FromRoute]int? id , DepartmentUpdateRequest request )
        {

            if (!ModelState.IsValid)
            {
                return View(request);
            }
            if(id.Value != request.Id)
            {
                return BadRequest();
            }

            try
            {
                var result = departmentService.Update(request);
                if (result > 0)
                {
                    return RedirectToAction(nameof(Index));

                }
                ModelState.AddModelError(string.Empty, "can't add Department Now");
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
            var department = departmentService.GetById(id.Value);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);

        }

        [HttpPost ]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int? id)
        {
            if(!id.HasValue )
            {
                return BadRequest();
            }
         
                var department = departmentService.GetById(id.Value);
            try
            {
                var IsDeleted = departmentService.Delete(id.Value);
                if (IsDeleted)
                {
                    return RedirectToAction(nameof(Index));

                }
                ModelState.AddModelError(string.Empty, "can't Remove Department Now");
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

            return View(department);

        }
    }
}
