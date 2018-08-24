using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebDemo1.Models
{
    public class SYS_EMP
    {
        [Key]
        int EMP_ID { get; set; }
        string EMP_NO { get; set; }
        string EMP_NAME { get; set; }
        DateTime QIUT_DATE { get; set; }

        int UPDATE_USERID { get; set; }

        char Enbaled { get; set; }

        int SHIFT_ID { get; set; }
        int FACTORY_ID { get; set; }

        String LAST_FUNCTION { get; set; }

        int DEPT_ID { get; set; }

        DateTime CHANGE_PW_TIME { get; set; }

        [DataType(DataType.Password)]
        [StringLength(15)]
        String PASSWD {get;set;}
        

    }
}