using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVC.Models
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

        public SYS_EMP(string EMP_NO, string EMP_NAME, int SHIFT_ID,int FACTORY_ID, int DEPT_ID, String PASSWD)
        {
            this.EMP_NO = EMP_NO;
            this.EMP_NAME = EMP_NAME;
            this.SHIFT_ID = SHIFT_ID;
            this.FACTORY_ID = FACTORY_ID;
            this.DEPT_ID = DEPT_ID;
            this.PASSWD = PASSWD;
        }

        

    }
}