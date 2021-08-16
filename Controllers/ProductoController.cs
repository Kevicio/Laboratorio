using Microsoft.AspNetCore.Mvc;
using demomvc.Models;


namespace demomvc.Controllers{

    public class ProductoController:Controller
    {
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Vender(Producto objproducto){
        double operacion1=0.0;
        double operacion2=0.0;
        double igv=1.18;
        
        if(objproducto.cantidad=='0'){
            ViewData["Message"] = "No se puede ingresar 0 como cantidad";
        }
        else if(objproducto.precio=='0'){
            ViewData["Message"] = "No existe ningun producto con precio 0";
        }
        else{ 
        ViewData["Message"] = "Cantidad Total "+objproducto.cantidad;
        ViewData["Message"] = "Precio "+objproducto.precio;
        ViewData["Message"] = "IGV = 18% ";

        operacion1=objproducto.cantidad*objproducto.precio;
        ViewData["Message"] ="El subtotal de la venta es: "+operacion1;

        operacion2=operacion1*igv;
        ViewData["Message"] ="El total de la venta es: "+operacion2;

        }







        return View("Index");

    }




    















    }


}
