using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using API_CRUD_April_101224.Models;

namespace API_CRUD_April_101224.Controllers
{
    public class StudentApiController : ApiController
    {
        API_CRUD_AprilEntities dbo = new API_CRUD_AprilEntities();
        [HttpGet]
        public IHttpActionResult getStudents()
        {
            List<tblStudent> studList = dbo.tblStudents.ToList();
            if (studList!=null)
            {
                return Ok(studList);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IHttpActionResult postTry()
        {
            return Ok(" this is post method");
        }
    }
}
