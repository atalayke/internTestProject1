using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace InternTestProject.Models
{
    public class GrantsContext : DbContext
    {
        public DbSet<Grant> Grants { get; set; }
        public DbSet<Investigator> Investigators { get; set; }

    }

    public class Grant
    {
        [Key, Display(Name = "GrantNumber")]
        [ScaffoldColumn(false)]
        public int GrantNum { get; set; }

        [Required, StringLength(80), Display(Name = "FundedResearch")]
        public string FundedResrch { get; set; }

        [StringLength(40), Display(Name = "PI")]
        public string PrincInvest { get; set; }
    }

    public class Investigator
    {
        [Key]
        public int PI_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Institution { get; set; }
        public string Research { get; set; }
    }
}