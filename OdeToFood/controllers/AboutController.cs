using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
       
        public string Phone()
        {
            return "111-22-111";
        }
        
        public string Address()
        {
            return "USA";
        }
    }
}
