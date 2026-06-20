using Microsoft.AspNetCore.Mvc;
using T1_Lerggios_Luis.Datos;
using T1_Lerggios_Luis.Models;

namespace T1_Lerggios_Luis.Controllers
{
    public class DistribuidorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DistribuidorController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Distribuidor> lista = _db.Distribuidor;
            return View(lista);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Distribuidor distribuidor)
        {
            if (ModelState.IsValid)
            {
                _db.Distribuidor.Add(distribuidor);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(distribuidor);
        }

        //Get Editar
        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.Distribuidor.Find(Id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Post Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Distribuidor distribuidor)
        {
            if (ModelState.IsValid)
            {
                _db.Distribuidor.Update(distribuidor);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(distribuidor);
        }

        //Get Eliminar
        public IActionResult Eliminar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.Distribuidor.Find(Id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Post Eliminar
        [HttpPost]
        [ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public IActionResult EliminarCategoria(Distribuidor distribuidor)
        {
            if (distribuidor == null)
            {
                return NotFound();
            }

            _db.Distribuidor.Remove(distribuidor);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // pestañas adicionales donde se visualicen información de Distribuidores conocidos en el Perú y el Mundo
        public IActionResult Informacion()
        {
            return View();
        }
    }
}


