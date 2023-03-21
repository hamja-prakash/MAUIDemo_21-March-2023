using SQLite;

namespace MAUISampleDemo.Model
{
    public class Student
    {
        [AutoIncrement,PrimaryKey]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsAdmin { get; set; }
    }
}

