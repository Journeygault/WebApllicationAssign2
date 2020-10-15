using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApllicationAssign2.Controllers
{
   
    public class J1Controller : ApiController
       /// 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Burger"> Array containing burger calories</param>
        /// <param name="Drink">Array Containing Drink Calories</param>
        /// <param name="Side">Array Containing Side Calories</param>
        /// <param name="Dessert">Array Containing Dessert Calories</param>
        /// <returns></returns>
        // GET api/J1/menu/{id}/{id}/{id}/id}
        [Route("api/J1/Menu/{Burger}/{Drink}/{Side}/{Dessert}")]
        
        ///

        public string GetMenu(int Burger, int Drink, int Side, int Dessert)
        
        {
            //Collection of arrays            
        int[] BurgerArray = { 461, 431, 420, 0 };
        int[] DrinkArray = { 130, 160, 118, 0 };
        int[] SideArray = { 100, 57, 70, 0 };
        int[] DessertArray = { 167, 266, 75, 0 };
            //Integer collecting and adding totaL callories based of user input
        int totalCall = (BurgerArray[Burger - 1] + DrinkArray[Drink - 1] + SideArray[Side - 1] + DessertArray[Dessert - 1]);
            //String with text/ conversion of totalcall into string
        string ReturnTotalCall = "there are" + totalCall.ToString() + " ways to get to 10";
            //Return of the String and integer to the window
        return  ReturnTotalCall;
       
        }

        
    }
}
