namespace CF.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstNameIsRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Education.AttendeesList", "FirstName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("Education.AttendeesList", "FirstName", c => c.String(maxLength: 50));
        }
    }
}
