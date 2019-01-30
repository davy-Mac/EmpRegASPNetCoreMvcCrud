using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EmpRegASPNetCoreMvcCrud.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required..!")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(10)")]
        [Required(ErrorMessage = "This field is required..!")]
        [DisplayName("Emp. Code")]
        public string EmpCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "This field is required..!")]
        public string Position { get; set; }

        [DisplayName("Office Location")]
        [Required(ErrorMessage = "This field is required..!")]
        [Column(TypeName = "varchar(100)")]
        public string OfficeLocation { get; set; }

    }
}
