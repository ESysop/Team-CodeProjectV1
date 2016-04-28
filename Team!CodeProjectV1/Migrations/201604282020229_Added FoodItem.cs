namespace Team_CodeProjectV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFoodItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DishName = c.String(),
                        DishPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FoodItems");
        }
    }
}
