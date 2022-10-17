namespace PYHDATA.NETFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_Item : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        Desciption = c.String(maxLength: 500),
                        CateogryName = c.String(nullable: false, maxLength: 250),
                        Location = c.String(),
                        ImageUrl = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Items");
        }
    }
}
