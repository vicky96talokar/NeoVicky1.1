namespace NeoVicky.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Neo : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MembershipTypes", newName: "MembershipTypeDtoes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.MembershipTypeDtoes", newName: "MembershipTypes");
        }
    }
}
