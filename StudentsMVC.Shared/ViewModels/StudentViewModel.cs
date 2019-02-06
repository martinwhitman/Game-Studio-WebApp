using StudentsMVC.Shared.Enums;

namespace StudentsMVC.Shared.ViewModels
{
    public class StudentViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public GenderEnum Gender { get; set; }
    }
}
