using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebDemo1.Models
{
    public class SYS_FACTORY
    {
        [Key]
        int FACTORY_ID { get; set; }
        String FACTORY_CODE { get; set; }
        String FACTORY_NAME { get; set; }
        String FACTORY_DESC { get; set; }

        int UPDATE_USERID{ get; set; }
        DateTime UPDATE_TIME { get; set; }
        char ENABLED { get; set; }

    }

    public class MESDbContext:DbContext
    {

        public MESDbContext() : base("OracleDbContext") 
        { 
        }
        public DbSet<SYS_EMP> SYS_EMPS {get;set;}

        public DbSet<SYS_DEPT> SYS_DEPTS { get; set; }

        public DbSet<SYS_FACTORY> SYS_FACTORYS { get; set; }

    }
}