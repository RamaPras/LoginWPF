namespace WpfLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingmodelmaster : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TB_User");
            DropTable("dbo.TB_M_Employee");
        }
    }
}
