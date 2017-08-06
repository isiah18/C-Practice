namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDisplayNameLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "DisplayName", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "DisplayName", c => c.String());
        }
    }
}
