using CommunityToolkit.Mvvm.ComponentModel;

namespace ToDoApp.Models;

public partial class ToDo : ObservableObject
{
    [ObservableProperty]
    private string? _title;

    [ObservableProperty]
    private string? _description;
}
