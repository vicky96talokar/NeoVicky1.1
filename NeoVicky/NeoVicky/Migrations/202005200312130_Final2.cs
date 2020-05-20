namespace NeoVicky.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("Customers", "PinCode");
            DropColumn("Customers", "State");

        }

        public override void Down()
        {
        }
    }
}
