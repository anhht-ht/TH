namespace TH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_Account : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        User_name = c.String(nullable: false, maxLength: 128),
                        PassWord = c.String(),
                    })
                .PrimaryKey(t => t.User_name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accounts");
        }
    }
}
