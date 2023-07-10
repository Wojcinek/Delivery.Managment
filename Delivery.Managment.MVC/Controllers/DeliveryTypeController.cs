using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Managment.MVC.Controllers
{
    public class DeliveryTypeController : Controller
    {
        // GET: DeliveryTypeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DeliveryTypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeliveryTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeliveryTypeController/Create
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

        // GET: DeliveryTypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeliveryTypeController/Edit/5
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

        // GET: DeliveryTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeliveryTypeController/Delete/5
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
