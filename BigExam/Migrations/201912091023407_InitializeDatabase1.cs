namespace BigExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Exams", "Subject", c => c.Int(nullable: false));
            AlterColumn("dbo.Exams", "Faculty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Exams", "Faculty", c => c.String(unicode: false));
            AlterColumn("dbo.Exams", "Subject", c => c.String(unicode: false));
        }
    }
}
