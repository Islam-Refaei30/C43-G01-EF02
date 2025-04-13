using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    // we have 4 ways to map class to table
    // 1. By Convention
    // 2. Data Annotations [Set of Attributes]
    // 3. Fluent API (Set of Methods)
    // 4. Configuration Class (Set of Classes)


    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Increment (1.1) by default
        public int Code { get; set; }
        [Column(TypeName = "nvarchar")] // Column Name 
        [StringLength(50, MinimumLength = 10)]
        public string? Name { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public double Salary { get; set; }
        //[Range(22,30)]
        //[AllowedValues(22,23,25)]
        [DeniedValues(10,15)]
        public int? Age { get; set; }

        //[EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }

        //[Phone]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [NotMapped] // Not mapped to database
        public double NetSalary { get; set; }


    }
}
