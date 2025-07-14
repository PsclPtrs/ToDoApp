using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ToDoApp.Models;

namespace ToDoApp.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string? _title;

    [ObservableProperty]
    private string? newTitle;

    [ObservableProperty]
    private string? newDescription;

    [ObservableProperty]
    private ToDo? selectedToDo;

    public ObservableCollection<ToDo> OpenToDos { get; } = [];
    public ObservableCollection<ToDo> CompletedToDos { get; } = [];

    [RelayCommand]
    private void AddToDo()
    {
        if (!string.IsNullOrWhiteSpace(NewTitle))
        {
            OpenToDos.Add(new ToDo { Title = NewTitle, Description = NewDescription });
            NewTitle = string.Empty;
            NewDescription = string.Empty;
        }
    }

    [RelayCommand]
    private void DeleteToDo()
    {
        if (SelectedToDo != null)
        {
            OpenToDos.Remove(SelectedToDo);
            SelectedToDo = null;
        }
    }

    [RelayCommand]
    private void CompleteToDo()
    {
        if (SelectedToDo != null)
        {
            CompletedToDos.Add(SelectedToDo);
            OpenToDos.Remove(SelectedToDo);
            SelectedToDo = null;
        }
    }
}
