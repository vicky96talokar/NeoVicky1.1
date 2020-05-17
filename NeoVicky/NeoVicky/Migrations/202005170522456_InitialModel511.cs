namespace NeoVicky.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel511 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "IsSubscriberToNewsletter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "IsSubscriberToNewsletter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "IsSubscribedToNewsletter");
        }
    }
}
