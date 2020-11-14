using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace POTZProjektZaliczeniowy.Model
{
    public class Employe
    {
        [Key]
        public int EmployeID { get; set; }

        public string FristName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

#nullable enable
        
        public int? CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public Company? Company { get; set; }

       
    }
}
