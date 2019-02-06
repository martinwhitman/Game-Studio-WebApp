using System.Collections.Generic;
using StudentsMVC.Shared.Enums;
using StudentsMVC.Shared.Orchestrators.Interfaces;
using StudentsMVC.Shared.ViewModels;

namespace StudentsMVC.Shared.Orchestrators
{
    public class StudentOrchestrator : IStudentOrchestrator
    {
        public StudentViewModel GetStudentDetails()
        {
            var student = new StudentViewModel();
            student.FirstName = "Robbie";
            student.LastName = "Robertson";
            student.Age = 75;
            student.Major = "Guitar Performance";
            student.Gender = GenderEnum.Male;
            
            return student;
        }
    }
}
