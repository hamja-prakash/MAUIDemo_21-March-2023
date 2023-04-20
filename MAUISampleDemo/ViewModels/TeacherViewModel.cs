using MAUISampleDemo.Model;
using System.Windows.Input;

namespace MAUISampleDemo.ViewModels
{
    public class TeacherViewModel
    {
        private List<Teacher> _allTeachers = new List<Teacher>();
        public List<TeacherGroup> Teachers { get; set; } = new List<TeacherGroup>();

        public TeacherViewModel()
        {
            _allTeachers.AddRange(new List<Teacher>
            {
                  new Teacher
                {
                    FullName ="Ashwin"
                },
                 new Teacher
                {
                    FullName ="Ashwariya"
                },
                  new Teacher
                {
                    FullName ="Anil"
                },
                new Teacher
                {
                    FullName ="Brijesh"
                },
                 new Teacher
                {
                    FullName ="Biren"
                },
                  new Teacher
                {
                    FullName ="Bhavik"
                },
                   new Teacher
                {
                    FullName ="Carl"
                },
                 new Teacher
                {
                    FullName ="Clay"
                },
                  new Teacher
                {
                    FullName ="Clinton"
                },
                   new Teacher
                {
                    FullName ="Janani"
                },
                 new Teacher
                {
                    FullName ="Jignesh"
                },
                  new Teacher
                {
                    FullName ="Jitesh"
                },
                    new Teacher
                {
                    FullName ="Krishna"
                },
                 new Teacher
                {
                    FullName ="Karishma"
                },
                  new Teacher
                {
                    FullName ="Karan"
                },
                       new Teacher
                {
                    FullName ="Krishna"
                },
                 new Teacher
                {
                    FullName ="Karishma"
                },
                  new Teacher
                {
                    FullName ="Karan"
                },     new Teacher
                {
                    FullName ="Krishna"
                },
                 new Teacher
                {
                    FullName ="Karishma"
                },
                  new Teacher
                {
                    FullName ="Karan"
                },     new Teacher
                {
                    FullName ="Krishna"
                },
                 new Teacher
                {
                    FullName ="Karishma"
                },
                  new Teacher
                {
                    FullName ="Karan"
                },     new Teacher
                {
                    FullName ="Krishna"
                },
                 new Teacher
                {
                    FullName ="Karishma"
                },
                  new Teacher
                {
                    FullName ="Karan"
                },     new Teacher
                {
                    FullName ="Krishna"
                },
                 new Teacher
                {
                    FullName ="Karishma"
                },
                  new Teacher
                {
                    FullName ="Karan"
                },     new Teacher
                {
                    FullName ="Krishna"
                },
                 new Teacher
                {
                    FullName ="Karishma"
                },
                  new Teacher
                {
                    FullName ="Karan"
                },     new Teacher
                {
                    FullName ="Krishna"
                },
                 new Teacher
                {
                    FullName ="Karishma"
                },
                  new Teacher
                {
                    FullName ="Karan"
                },     new Teacher
                {
                    FullName ="Krishna"
                },
                 new Teacher
                {
                    FullName ="Karishma"
                },
                  new Teacher
                {
                    FullName ="Karan"
                },     new Teacher
                {
                    FullName ="Krishna"
                },
                 new Teacher
                {
                    FullName ="Karishma"
                },
                  new Teacher
                {
                    FullName ="Karan"
                },     new Teacher
                {
                    FullName ="Krishna"
                },
                 new Teacher
                {
                    FullName ="Karishma"
                },
                  new Teacher
                {
                    FullName ="Karan"
                },     new Teacher
                {
                    FullName ="Krishna"
                },
                 new Teacher
                {
                    FullName ="Karishma"
                },
                  new Teacher
                {
                    FullName ="Karan"
                },     new Teacher
                {
                    FullName ="Krishna"
                },
                  new Teacher
                {
                    FullName ="Karan"
                }
            });

            var groupedData = _allTeachers.GroupBy(f => f.FullName[0]).Select(f => new TeacherGroup(f.Key.ToString(), f.ToList()));
            Teachers.AddRange(groupedData);
        }

        public ICommand AddOrRemoveGroupDataCommand => new Command<TeacherGroup>((item) =>
        {
            if (item.GroupIcon == "down_arrow")
            {
                item.Clear();
                item.GroupIcon = "up_arrow";
            }
            else
            {
                var recordsTobeAdded = _allTeachers.Where(f => f.FullName.ToLower().StartsWith(item.GroupTitle.ToLower())).ToList();
                item.AddRange(recordsTobeAdded);
                item.GroupIcon = "down_arrow";
            }
        });
    }
}

