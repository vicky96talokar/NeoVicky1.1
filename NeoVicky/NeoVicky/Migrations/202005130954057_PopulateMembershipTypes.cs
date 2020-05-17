namespace NeoVicky.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(1,0,0,0)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(2,30,1,10)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(3,40,2,15)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(4,50,5,12)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(5,60,70,16)");
        }
        
        public override void Down()
        {
        }
    }
}
