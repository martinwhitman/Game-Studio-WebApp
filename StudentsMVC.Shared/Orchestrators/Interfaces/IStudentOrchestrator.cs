using System.Collections.Generic;
using StudentsMVC.Shared.ViewModels;

namespace StudentsMVC.Shared.Orchestrators.Interfaces
{
    interface IStudentOrchestrator
    {
        StudentViewModel GetStudentDetails();
    }
}
