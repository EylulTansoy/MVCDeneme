namespace LayoutDeneme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qwe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        description = c.String(),
                        createdTime = c.DateTime(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        User_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.User_id)
                .Index(t => t.User_id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        surname = c.String(),
                        username = c.String(),
                        createdTime = c.DateTime(nullable: false),
                        Role_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Roles", t => t.Role_id)
                .Index(t => t.Role_id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TagPosts",
                c => new
                    {
                        Tag_id = c.Int(nullable: false),
                        Post_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_id, t.Post_id })
                .ForeignKey("dbo.Tags", t => t.Tag_id, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.Post_id, cascadeDelete: true)
                .Index(t => t.Tag_id)
                .Index(t => t.Post_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Role_id", "dbo.Roles");
            DropForeignKey("dbo.Posts", "User_id", "dbo.Users");
            DropForeignKey("dbo.TagPosts", "Post_id", "dbo.Posts");
            DropForeignKey("dbo.TagPosts", "Tag_id", "dbo.Tags");
            DropIndex("dbo.TagPosts", new[] { "Post_id" });
            DropIndex("dbo.TagPosts", new[] { "Tag_id" });
            DropIndex("dbo.Users", new[] { "Role_id" });
            DropIndex("dbo.Posts", new[] { "User_id" });
            DropTable("dbo.TagPosts");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Tags");
            DropTable("dbo.Posts");
        }
    }
}
