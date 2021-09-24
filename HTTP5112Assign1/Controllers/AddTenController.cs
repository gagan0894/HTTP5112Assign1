using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112Assign1.Controllers
{
    public class AddTenController : ApiController
    {
        //GET: AddTen
        //Path:/api/AddTen/{id}

        public int Get(int id)
        {
            return id + 10;
        }
    }
}
