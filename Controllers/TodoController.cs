using microservice.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace microservice.Controllers
{
    public class TodoController : Controller
    {
        private ITodoRepository todoRepo;

        public TodoController(ITodoRepository todo_db)
        {
            todoRepo = todo_db;    
        }
        // GET: TodoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TodoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TodoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TodoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TodoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TodoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TodoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TodoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
