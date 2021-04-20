namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pierwszaMigracja : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID_Category = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.ID_Category);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        ID_Task = c.Int(nullable: false, identity: true),
                        ID_User_FK = c.Int(nullable: false),
                        ID_Category_FK = c.Int(nullable: false),
                        Title = c.String(),
                        Content = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        DateLimit = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Task)
                .ForeignKey("dbo.Categories", t => t.ID_Category_FK, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.ID_User_FK, cascadeDelete: true)
                .Index(t => t.ID_User_FK)
                .Index(t => t.ID_Category_FK);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID_User = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID_User);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "ID_User_FK", "dbo.Users");
            DropForeignKey("dbo.Tasks", "ID_Category_FK", "dbo.Categories");
            DropIndex("dbo.Tasks", new[] { "ID_Category_FK" });
            DropIndex("dbo.Tasks", new[] { "ID_User_FK" });
            DropTable("dbo.Users");
            DropTable("dbo.Tasks");
            DropTable("dbo.Categories");
        }
    }
}
