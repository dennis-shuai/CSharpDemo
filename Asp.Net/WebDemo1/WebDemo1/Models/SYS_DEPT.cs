using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebDemo1.Models
{
    public class SYS_DEPT
    {
        int FACTORY_ID { get; set; }

        [Key]
        int DEPT_ID { get; set; }
        string DEPT_NAME { get; set; }
        int UPDATE_USERID { get; set; }
        DateTime UPDATE_TIME { get; set; }
        char ENABLED { get; set; }
        string DEPT_DESC { get; set; }
    }
}