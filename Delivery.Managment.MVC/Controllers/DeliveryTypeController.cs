using Delivery.Managment.MVC.Contracts;
using Delivery.Managment.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Managment.MVC.Controllers
{
    public class DeliveryTypeController : Controller
    {
        private readonly IDeliveryTypeService _deliveryTypeRepository;

            public DeliveryTypeController(IDeliveryTypeService deliveryTypeRepository)
        {
            _deliveryTypeRepository = deliveryTypeRepository;
        }

        // GET: DeliveryTypeController
        public async Task<ActionResult> Index()
        {
            var model = await _deliveryTypeRepository.GetDeliveryTypes();
            return View(model);
        }

        // GET: DeliveryTypeController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View();
        }

        // GET: DeliveryTypeController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: DeliveryTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
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
        public async Task<ActionResult> Edit(int id)
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
        public async Task<ActionResult> Delete(int id)
        {
            return View();
        }

        // POST: DeliveryTypeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
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
