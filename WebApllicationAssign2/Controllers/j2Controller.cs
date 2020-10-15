using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace WebApllicationAssign2.Controllers
{
    public class j2Controller : ApiController
        
    {
        /// <summary>
        /// My attempt was to use two loops, one nested in another
        /// the first loop would count all numbers from the first inmputed value to zero
        /// the second would take the 2nd inputed value and run through them
        /// an if statement would coullect the total number of ways they could be added
        /// together to equal 10.
        /// Truth be told I dont think I have ever gotten so stuck on an assignment in my life
        /// it was a good challenge 
        /// </summary>
        /// <param name="m">The inputed value of dice 1</param>
        /// <param name="n">The inputed value of dice 2</param>
        /// <returns>Returns the phrase Your total number of sides is:
        /// {total number of side from two dice}
        /// </returns>
        // GET api/values/api/J1/DiceGame/{id}/{id}
        [Route("api/J1/DiceGame/{m}/{n}")]

        public string GetDiceGame(int m, int n)
        {
            //Out of Loop Integers
            string message = " Your total number of sides are:";
            int counter = 0;
            //Loop 1 which count up from one stopping at the value of {m} in an increment of 1
            for(int i=1; i<=m ;i++)
            {
              //Loop 2 Which starts at 1 and increase the value of{n} until J= the value of {n"
                for (int j = 1; j<=n; j++)
                {
                    //An if statement, which logs the number of times the loop hits 10 per combined integer
                    if ((i + j) == 10)
                    {
                        counter = counter + 1;                       
                    }
                }
            }
            return message +counter.ToString();
        }
    }
}


//Aditional Failled attempts; 
//Christine, I thought you might get a 
//laugh out of these horrible first attempts
//I tried to base it off which value was 
//higher than the other and have it loop down until
//there combined total was less than 10

//Thank you for your help in class the other day
//It helped my way of going about things

/*  int counter = 0;
  string message = "";
}
/* //Numbers greater than 9 can not equal to 10
  if (n >= 10)
  {
      n = 9;
  }
  if (m >= 10)
  {
      m = 9;
  }

      // If N is over 9 this line will reduce it to a point where the dice 
      //combination can equal 10
      for (int i = n; n <= 0; i= i-1)
      {
          n = n - 1;
          if ((n + m) == 10)
          {
              //loop for when n+m finaly = 10
              for ( i = n; n <= 1 ||m>=9; i = i - 1)
              {
                  n = n - 1;
                  m = m + 1;
                  loopTotal = loopTotal + 1;

              }
              message = loopTotal+"Total loops";
          }
      }                

}
return message;*/

/*    
        string message = " ";
        int counter = 0;
        while (n>m)
        {
            n--;
            if ((n + m) == 10)
            {
                while (n > 0 && -m < 10 )
                {
                    n--;
                    m++;
                    counter = (counter + 1);
                    message = message + counter;
                }
            return message;
        }


    }
    return "bla";
    }


    //if else






}*/