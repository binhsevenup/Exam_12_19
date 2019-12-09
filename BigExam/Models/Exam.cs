using System;
using System.ComponentModel.DataAnnotations;
namespace BigExam.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        public int StartTime { get; set; }
        public DateTime ExamDate { get; set; }
        public int Duration { get; set; }
        public String Classroom { get; set; }
        

        public EStatus Status { get; set; }
        public enum EStatus
        {
            Done = 1, UpComing = 2, OnGoing = 3 
        }
        
        public EFaculty Faculty { get; set; }
        public enum EFaculty
        {
            Jayalakshmi = 1, John_Carter = 2, HienPA = 3 
        }
        
        public ESubject Subject { get; set; }
        public enum ESubject
        {
            CoreJava = 1, AdvantageJava = 2, ProgrammingC = 3 
        }

    }
}