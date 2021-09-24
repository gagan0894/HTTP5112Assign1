using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112Assign1.Controllers
{
    public class NumberMachineController : ApiController
    {
        //GET: NumberMachine
        //Path: /api/NumberMachine/{id}

        public int Get(int id)
        {
            return (((id * 2) - id) / id) + 10;
        }
    }
}
