using CommunityToolkit.Mvvm.ComponentModel;

namespace ToDoApp.ViewModels
{
    internal partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = "To-Do List Application";
    }
}
