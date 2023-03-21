using SQLite;

namespace MAUISampleDemo.Model
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPSSPLEmployee { get; set; }
    }
}
