namespace TH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_Nhanvien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 20),
                        TenNV = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanViens");
        }
    }
}
