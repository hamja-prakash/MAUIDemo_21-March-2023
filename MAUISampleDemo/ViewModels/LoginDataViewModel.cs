using CommunityToolkit.Mvvm.ComponentModel;
using MAUISampleDemo.Model;
using System.Collections.ObjectModel;

namespace MAUISampleDemo.ViewModels
{
    public partial class LoginDataViewModel : ObservableObject
    {
        [ObservableProperty]
        public List<Student> studentList;

        public LoginDataViewModel()
        {
            studentList = new List<Student>();
            BindStudentData();
        }

        public async void BindStudentData()
        {
            var mStudents = await App.Database.GetStudentAsync();
            if(mStudents != null && mStudents.Count > 0)
                StudentList = mStudents.ToList();
        }
    }
}
