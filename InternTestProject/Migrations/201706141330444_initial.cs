namespace InternTestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grants",
                c => new
                    {
                        GrantNum = c.Int(nullable: false, identity: true),
                        FundedResrch = c.String(nullable: false, maxLength: 80),
                        PrincInvest = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.GrantNum);
            
            CreateTable(
                "dbo.Investigators",
                c => new
                    {
                        PI_ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 40),
                        LastName = c.String(nullable: false, maxLength: 40),
                        Institution = c.String(nullable: false, maxLength: 80),
                        Research = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.PI_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Investigators");
            DropTable("dbo.Grants");
        }
    }
}
