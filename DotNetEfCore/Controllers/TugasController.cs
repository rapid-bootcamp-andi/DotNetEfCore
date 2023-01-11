using DotnetEfCore.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace DotNetEfCore.Controllers
{
    public class TugasController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TugasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllTokoKomputer()
        {
            IEnumerable<TokoKomputerEntity> data = _context.TokoKomputerEntities.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult DetailsTokoKomputer(int? id)
        {
            TokoKomputerEntity data = _context.TokoKomputerEntities.Find(id);
            return View(data);
        }

        [HttpGet]
        public IActionResult AddTokoKomputer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveTokoKomputer([Bind("Nama, Kategori, Jumlah, Harga")] TokoKomputerEntity request)
        {
            // add ke entity
            _context.TokoKomputerEntities.Add(request);
            // commit to database
            _context.SaveChanges();

            return Redirect("GetAllTokoKomputer");
        }

        [HttpGet]
        public IActionResult EditTokoKomputer(int? id)
        {
            var entity = _context.TokoKomputerEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult DeleteTokoKomputer(int? id)
        {
            var entity = _context.TokoKomputerEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }
            // remove from entity
            _context.TokoKomputerEntities.Remove(entity);
            // commit to database
            _context.SaveChanges();
            return RedirectToAction("GetAllTokoKomputer");
        }

        [HttpPost]
        public IActionResult UpdateTokoKomputer([Bind("Id, Nama, Kategori, Jumlah, Harga")] TokoKomputerEntity request)
        {
            // update entity
            _context.TokoKomputerEntities.Update(request);
            // commit to database
            _context.SaveChanges();
            return Redirect("GetAllTokoKomputer");
        }









        public IActionResult GetAllTokoGame()
        {
            IEnumerable<TokoGameEntity> data = _context.TokoGameEntities.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult DetailsTokoGame(int? id)
        {
            TokoGameEntity data = _context.TokoGameEntities.Find(id);
            return View(data);
        }

        [HttpGet]
        public IActionResult AddTokoGame()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveTokoGame([Bind("Nama, Genre, Jumlah, Tahun, Harga")] TokoGameEntity request)
        {
            // add ke entity
            _context.TokoGameEntities.Add(request);
            // commit to database
            _context.SaveChanges();

            return Redirect("GetAllTokoGame");
        }

        [HttpGet]
        public IActionResult EditTokoGame(int? id)
        {
            var entity = _context.TokoGameEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult DeleteTokoGame(int? id)
        {
            var entity = _context.TokoGameEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }
            // remove from entity
            _context.TokoGameEntities.Remove(entity);
            // commit to database
            _context.SaveChanges();
            return RedirectToAction("GetAllTokoGame");
        }

        [HttpPost]
        public IActionResult UpdateTokoGame([Bind("Id, Nama, Genre, Jumlah, Tahun, Harga")] TokoGameEntity request)
        {
            // update entity
            _context.TokoGameEntities.Update(request);
            // commit to database
            _context.SaveChanges();
            return Redirect("GetAllTokoGame");
        }









        public IActionResult GetAllDataTamu()
        {
            IEnumerable<DataTamuEntity> data = _context.DataTamuEntities.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult DetailsDataTamu(int? id)
        {
            DataTamuEntity data = _context.DataTamuEntities.Find(id);
            return View(data);
        }

        [HttpGet]
        public IActionResult AddDataTamu()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveDataTamu([Bind("Nama, Kota, NoWa, NoTlp")] DataTamuEntity request)
        {
            // add ke entity
            _context.DataTamuEntities.Add(request);
            // commit to database
            _context.SaveChanges();

            return Redirect("GetAllDataTamu");
        }

        [HttpGet]
        public IActionResult EditDataTamu(int? id)
        {
            var entity = _context.DataTamuEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult DeleteDataTamu(int? id)
        {
            var entity = _context.DataTamuEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAllDataTamu");
            }
            // remove from entity
            _context.DataTamuEntities.Remove(entity);
            // commit to database
            _context.SaveChanges();
            return RedirectToAction("GetAllDataTamu");
        }

        [HttpPost]
        public IActionResult UpdateDataTamu([Bind("Id, Nama, Kota, NoWa, NoTlp")] DataTamuEntity request)
        {
            // update entity
            _context.DataTamuEntities.Update(request);
            // commit to database
            _context.SaveChanges();
            return Redirect("GetAllDataTamu");
        }

    }
}
