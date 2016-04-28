namespace Team_CodeProjectV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restaurant : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RestaurantName = c.String(),
                        Address = c.String(),
                        Website = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Restaurants");
        }
    }
}
