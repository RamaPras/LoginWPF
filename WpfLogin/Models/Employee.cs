using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLogin.Models
{
    [Table ("TB_M_Employee")]
   public  class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname{ get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
       
    }
}
