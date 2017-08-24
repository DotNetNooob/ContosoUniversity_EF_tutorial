using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity_EF_tutorial.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UserId { get; set; }
        public Exception Exception { get; set; }


        public Log()
        {
        }
    }
}