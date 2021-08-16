using Microsoft.AspNetCore.Mvc;
using demomvc.Models;


namespace demomvc.Controllers{


   public class CalculadoraController: Controller
    {

    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Calcular(Calculadora objcalculadora)
    {
        decimal operacion=0;
        ViewData["Message"] ="Sin resultado";

        if(objcalculadora.Operador.Equals("+"))
        {
           operacion=objcalculadora.Operador1+objcalculadora.Operador2;
             ViewData["Message"] = "El resultado de la operacion es:"+operacion;
        }
        else if(objcalculadora.Operador.Equals("/"))
        {
          if(objcalculadora.Operador2 == 0){
                ViewData["Message"] = "No se puede dividir entre 0";
          }else{
              operacion=objcalculadora.Operador1/objcalculadora.Operador2;
                ViewData["Message"] = "El resultado de la operacion es:"+operacion;
          }
        }

       return View("Index");
    }


    }








}