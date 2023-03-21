using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUISampleDemo.Model;
using MAUISampleDemo.Shared;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace MAUISampleDemo.ViewModels
{
    public partial class ObservablePropertyViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Employee> employeeList;

        [ObservableProperty]
        private string employee;

        private Employee _itemBeingDragged;

        public ObservablePropertyViewModel()
        {
            GetEmployeeList();
        }

        [RelayCommand]
        public void AddEmployee()
        {
            Device.BeginInvokeOnMainThread(() =>
             {
                 if (!string.IsNullOrEmpty(Employee) && (EmployeeList.Where(x => x.EmployeeName.ToLower().Contains(Employee.ToLower())).FirstOrDefault() == null))
                 {
                     EmployeeList.Add(new Employee() { EmployeeName = Employee });
                     Employee = string.Empty;
                 }
                 else
                 {
                     App.Current.MainPage.DisplayAlert("Message", "User already exist", "Ok", "Cancel");
                 }
             });
        }

        [RelayCommand]
        public void DeleteEmployee(Employee employee)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (EmployeeList.Contains(employee))
                {
                    EmployeeList.Remove(employee);
                }
            });
        }

        [RelayCommand]
        public void ItemDragged(Employee employee)
        {
             employee.IsBeingDragged = true;
            _itemBeingDragged = employee;
        }

        [RelayCommand]
        public void ItemDragLeave(Employee employee)
        {
            employee.IsBeingDraggedOver = false;
        }

        [RelayCommand]
        public void ItemDraggedOver(Employee employee)
        {
            if (employee == _itemBeingDragged)
            {
                employee.IsBeingDragged = false;
            }
            employee.IsBeingDraggedOver = employee != _itemBeingDragged ? true : false;
        }

        [RelayCommand]
        public void ItemDropped(Employee employee)
        {
            try
            {
                var itemToMove = _itemBeingDragged;
                var itemToInsertBefore = employee;
                if (itemToMove == null || itemToInsertBefore == null || itemToMove == itemToInsertBefore)
                    return;
                int insertAtIndex = EmployeeList.IndexOf(itemToInsertBefore);
                if (insertAtIndex >= 0 && insertAtIndex < EmployeeList.Count)
                {
                    EmployeeList.Remove(itemToMove);
                    EmployeeList.Insert(insertAtIndex, itemToMove);
                    itemToMove.IsBeingDragged = false;
                    itemToInsertBefore.IsBeingDraggedOver = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void GetEmployeeList()
        {
            EmployeeList = new ObservableCollection<Employee>()
            {
                new Employee(){EmployeeName = "Employee 1"},
                new Employee(){EmployeeName= "Employee 2"},
                new Employee(){EmployeeName= "Employee 3"},
                new Employee(){EmployeeName= "Employee 4"},
                new Employee(){EmployeeName= "Employee 5"},
                new Employee(){EmployeeName= "Employee 6"},
            };
        }
    }
}
