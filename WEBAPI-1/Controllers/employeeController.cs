using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI_1.Models;

namespace WEBAPI_1.Controllers
{
    public class employeeController : ApiController
    {
        public static List<employe> employes = new List<employe>()
        {
            new employe() { id =1, name="amira",address="alex" },
            new employe() { id =2, name="ola",address="alex" },
            new employe() { id =4, name="ali",address="CAiro" },
            new employe() { id =3, name="sraa",address="CAiro" },

    };

        //getall
        public List<employe> getall ()
        {
            return employes;
        }

        //getby id



        //getbyname


        //add


        //edit


        //delete

}
}