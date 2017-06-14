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
        public int GrantNum { get; set; }
        [Required, StringLength(80), Display(Name = "FundedResearch")]
        public string FundedResrch { get; set; }
        [StringLength(40), Display(Name = "PI")]
        public string PrincInvest { get; set; }
    }

    public class Investigator
    {
        [Key, Display(Name="InvestigatorID")]
        public int PI_ID { get; set; }
        [Required, StringLength(40)]
        public string FirstName { get; set; }
        [Required, StringLength(40)]
        public string LastName { get; set; }
        [Required, StringLength(80)]
        public string Institution { get; set; }
        [Required, StringLength(80)]
        public string Research { get; set; }
    }
}