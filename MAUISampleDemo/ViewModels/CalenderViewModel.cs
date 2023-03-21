using CommunityToolkit.Mvvm.ComponentModel;
using MAUISampleDemo.Model;
using Microsoft.Maui.Graphics.Text;
using System.Collections.ObjectModel;
using System.Drawing;

namespace MAUISampleDemo.ViewModels
{
    public partial class CalenderViewModel: ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<CalenderModel> calender;
        public CalenderModel mCalender;
        public CalenderViewModel()
        {
            calender = new ObservableCollection<CalenderModel>();
            BindCalenderData(DateTime.Now);
        }

        public void BindCalenderData(DateTime selectedDate)
        {
            //var days = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);
            var currentdate = DateTime.Now;
            var month = DateTime.Now.AddDays(30);
            for (DateTime date = currentdate; date <= month; date = date.AddDays(1))
            {
                mCalender = new CalenderModel();
                if(date.DayOfWeek == DayOfWeek.Sunday)
                {
                    mCalender.bgColor = Microsoft.Maui.Graphics.Color.FromArgb("#FFC0CB");
                    mCalender.textcolor = Microsoft.Maui.Graphics.Color.FromArgb("#FFFFFF");
                }
                else
                {
                    mCalender.bgColor = Microsoft.Maui.Graphics.Color.FromArgb("#FFFFFF");
                    mCalender.textcolor = Microsoft.Maui.Graphics.Color.FromArgb("#000000");
                }
                   
                mCalender.Date = date.Date;
                mCalender.Day = date.DayOfWeek.ToString().Substring(0,3);
                mCalender.month = date.Date;
                mCalender.year = date.Year.ToString();
                Calender.Add(mCalender);
            }
        }
    }
}
