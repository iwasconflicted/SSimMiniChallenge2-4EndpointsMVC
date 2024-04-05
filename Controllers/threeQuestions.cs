using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SSimMiniChallenge2_4EndpointsMVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class threeQuestions : ControllerBase
    {
        [HttpGet("/doMath")]
        public string DoMath(int a, int b){
             return "The sum of " + a + " + " + b + " is " + (a+b); 
        }


        [HttpGet("/nameTime")]
        public string NameTime(string name, string time){
            return "This is " + name + " & " + "they woke up at " + time;
        }

        [HttpGet("/BiggerThan")]

        public string BiggerThan(int a, int b){
               if (a == b){
                return a + " is equal to " + b;
                }
                else if (a < b){
                return a + " is less than " + b;
                }
                    else{
                return a + " is greater than " + b;
                    }
        }
    }
}