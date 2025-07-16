using CommunityToolkit.Mvvm.ComponentModel;

namespace ToDoApp.Models;

public partial class Todo : ObservableObject
{
    [ObservableProperty]
    private string _title;

    [ObservableProperty]
    private string _description;

    public Todo (string title, string descrption)
    {
        Title = title;
        Description = descrption;
    }
}
