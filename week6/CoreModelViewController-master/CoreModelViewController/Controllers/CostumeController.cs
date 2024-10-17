using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoreModelViewController.Controllers
{
    public class CostumeController : Controller
    {
        // GET : /Costume/Welcome -> A webpage that welcomes our user to costume store
        [HttpGet]
        public IActionResult Welcome()
        {
            // Routes/direct to /Views/Costume/Welcome.cshtml
            return View();
        }

        // GET : /Costume/Store -> A webpage that asks the user what kind of costume they want to buy
        [HttpGet]
        public IActionResult Store()
        {
            // Route to /Views/Costume/Store.cshtml
            return View();
        }

        // GET: /Costume/OrderSummary?CustomerName={CustomerName}&CostumeType={CostumeType}&CostumeSize={CostumeSize} -> A webpage which shows the order details
        [HttpGet]
        public IActionResult OrderSummay(string CustomerName, string CostumeType, string CostumeSize)
        {
          // test that you have received the information
          Debug.WriteLine("The customer name is " +CustomerName);
          Debug.WriteLine("The costume type is " +CostumeType);
          Debug.WriteLine("The costume size is " +CostumeSize);

          //use ViewData to send inormation to the view
          ViewData["CustomerName"] = CustomerName;
          ViewData["CostumeType"] = CostumeType;
          ViewData["CostumeSize"] = CostumeSize;
          
          //todo: compute order total
          decimal VampirePrice = 50.99m;
          decimal GhostPrice = 30.99m;
          decimal CatPrice = 40.99m;

          decimal OrderTotal = 0m;

          if(CostumeType == "Vampire")
          {
            OrderTotal += VampirePrice;
          }else if(CostumeType == "Ghost"){
            OrderTotal += GhostPrice;
          } else if (CostumeType == "Cat"){
            OrderTotal += CatPrice;
          }

          if(CostumeSize == ""){
            
          }


          ViewData["OrderTotal"] = OrderTotal;

          // direct to /View/Costume/OrderSummary.cshtml
          return View();
        }

        
        






        
        // POST: /Candy/Checkout
        // Header: Content-Type: application/x-www-form-urlencoded
        // FORM DATA: OrderAddress={OrderAddress}&CandyNumPieces={CandyNumPieces}&CandyType={CandyType} -> A checkout webpage
        [HttpPost]
        public IActionResult Checkout(string OrderAddress, int CandyNumPieces, string CandyType)
        {
            // Leverage debugging method to check if we receive the information
            Debug.WriteLine("The address is "+OrderAddress);
            Debug.WriteLine("The number of pieces of candy is " + CandyNumPieces);
            Debug.WriteLine("The candy type is "+CandyType);

            //ViewData to communicate information to the view as key value pairs
            ViewData["OrderAddress"] = OrderAddress;
            ViewData["CandyNumPieces"] = CandyNumPieces;
            ViewData["CandyType"] = CandyType;

            
            decimal PerPiece = 0m;

            if(CandyType== "Snackers")
            {
                PerPiece = 3m;

            } else if (CandyType== "KatKit")
            {
                PerPiece = 2.50m;

            } else if (CandyType== "Jupiters")
            {
                PerPiece = 2.75m;
            }

            decimal OrderTotal = Math.Round(CandyNumPieces * PerPiece,2);

            ViewData["OrderTotal"] = OrderTotal;

            // Route to /Views/Candy/Checkout.cshtml
            return View();
        }

    }
}
