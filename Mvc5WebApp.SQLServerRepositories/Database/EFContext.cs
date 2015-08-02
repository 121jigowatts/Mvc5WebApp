using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc5WebApp.SQLServerRepositories.Database
{
    public class EFContext : DbContext
    {
        public EFContext()
            : base("name=EFC")
        {
        }

        public virtual DbSet<Person> People { get; set; }
    }

    [Table("People")]
    public class Person
    {
        [Required]
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        [MaxLength(25)]
        public string Job { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
