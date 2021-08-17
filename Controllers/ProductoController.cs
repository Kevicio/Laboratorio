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
        double operacion3=0.0;
        double igv=0.18;
        double red1,red2;
      
        
        
        if(objproducto.cantidad== 0){
            ViewData["Message"] = "No se puede ingresar 0 como cantidad";
        }
        else if(objproducto.precio== 0){
            ViewData["Message"] = "No existe ningun producto con precio 0";
        }
        else{ 
        ViewData["Producto"] =  "Producto: "+objproducto.nombre;
        ViewData["Cantidad"] = "Cantidad Total: "+objproducto.cantidad+" unidades";
        ViewData["Precio"] = "Precio: S/."+objproducto.precio;
        
        operacion1=objproducto.cantidad*objproducto.precio;
        ViewData["subtotal"] ="El subtotal de la venta es: S/."+operacion1;

        operacion3=operacion1*igv;
        ViewData["IGV"] = "IGV: S/."+operacion3;
        
        operacion2=operacion1*(1+igv);
        ViewData["Message"] ="El total de la venta es: S/."+operacion2;

        }
       


        return View("Index");

    }




    















    }


}
