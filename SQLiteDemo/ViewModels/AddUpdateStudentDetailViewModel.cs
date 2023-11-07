using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SQLiteDemo.Services;

namespace SQLiteDemo.ViewModels
{
    public partial class AddUpdateStudentDetailViewModel : ObservableObject
    {
        private readonly IStudentService _studentService;

            public AddUpdateStudentDetailViewModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [ObservableProperty]
        private string _firstName;

        [ObservableProperty]
        private string _lastName;

        [ObservableProperty]
        private string _email;

        [RelayCommand]

        public async Task AddUpdateStudent()
        {
            var response = _studentService.AddStudent(new Model.StudentModel
            {
                Email = Email,
                FirstName = FirstName,
                LastName = LastName,
            
            });
            await Shell.Current.DisplayAlert("Record Added", "Record Added to Student Table", "Ok");

            /*  if(response)
              {
                  await Shell.Current.DisplayAlert("Record Added", "Record Added to Student Table", "Ok");
              }
              else
              {
                  await Shell.Current.DisplayAlert("Record Added", "Record Added to Student Table", "Ok");
              }*/
        }




    }
}
