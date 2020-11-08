﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POTZProjektZaliczeniowy.Model
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }

        public string CompanyName { get; set; }

        public int NIP { get; set; }

        ICollection<Employe> Employes { get; set; }

        
    }
}