using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BigExam.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class Context :DbContext
    {
        public Context() : base("name=MyContext")
        {

        }
        public DbSet<Exam> Exams { get; set; }
    }
}
