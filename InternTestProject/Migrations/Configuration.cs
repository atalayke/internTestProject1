namespace InternTestProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using InternTestProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<InternTestProject.Models.GrantsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InternTestProject.Models.GrantsContext context)
        {
            context.Grants.AddOrUpdate(
                new Grant
                {
                    //GrantNum = 1234,
                    FundedResrch = "Sleep Apnea",
                    PrincInvest = "John Doe"
                },
                new Grant
                {
                    //GrantNum = 6789,
                    FundedResrch = "Asthma",
                    PrincInvest = "Mary Jane"
                }
                );

            context.SaveChanges();

            context.Investigators.AddOrUpdate(
                new Investigator {
                    //PI_ID = 0000,
                    FirstName = "John",
                    LastName = "Doe",
                    Institution = "UMD",
                    Research = "Sleep Disorders" },
                new Investigator {
                    //PI_ID = 0001,
                    FirstName = "Mary",
                    LastName = "Jane",
                    Institution = "Georgia Tech",
                    Research = "Lung Diseases"
                });

            context.SaveChanges();
        }
    }
}
