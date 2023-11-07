using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Database;
using SQLiteDemo.Views;

namespace SQLiteDemo.ViewModels;

public partial class StudentListPageViewModel : ObservableObject
{


    [RelayCommand]

    public async Task AddUpdateStudent()
    {
        await AppShell.Current.GoToAsync(nameof(AddUpdateStudentDetail));
    }



}
