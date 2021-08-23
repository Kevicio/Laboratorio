using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
using demomvc.Data;


namespace demomvc.Controllers
{
    public class ContactoController:Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactoController(ApplicationDbContext context)
        {
            _context = context;
        }
        

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create( Contacto objContacto)
    {
       _context.Add(objContacto);
       _context.SaveChanges();
       ViewData["Message"] = "Está registrado correctamente";
       return View("Index");
    }



    }
    
}