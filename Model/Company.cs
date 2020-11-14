using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POTZProjektZaliczeniowy.Model
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }

        public string CompanyName { get; set; }
#nullable enable
        public string? NIP { get; set; }


        public ICollection<Employe> Employes { get; set; }

        
    }
}