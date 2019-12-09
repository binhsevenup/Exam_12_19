namespace BigExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(unicode: false),
                        StartTime = c.Int(nullable: false),
                        ExamDate = c.DateTime(nullable: false, precision: 0),
                        Duration = c.Int(nullable: false),
                        Classroom = c.String(unicode: false),
                        Faculty = c.String(unicode: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exams");
        }
    }
}
