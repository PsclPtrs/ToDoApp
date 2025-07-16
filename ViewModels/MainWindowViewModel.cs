using System.Collections.ObjectModel;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ToDoApp.Models;

namespace ToDoApp.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    public string TitlePlaceHolderText = "Bitte hier ihren Titel reinschreiben!:";

    public string DescriptionPlaceHolderText = "Bitte hier ihre Beschreibung reinschreiben!:";

    [ObservableProperty]
    private string _title = "To-Do List Application";

    [ObservableProperty]
    private string _toDoTitle = "Bitte hier ihren Titel reinschreiben!:";

    partial void OnToDoTitleChanged(string? oldValue, string newValue) { }

    [ObservableProperty]
    private string _toDescription = "Bitte hier ihre Beschreibung reinschreiben!:";

    partial void OnToDescriptionChanged(string? oldValue, string newValue) { }

    [ObservableProperty]
    public ObservableCollection<Todo> _openToDos = [];

    [ObservableProperty]
    public ObservableCollection<Todo> _closedToDos = [];

    [ObservableProperty]
    private Todo? _selectedOpenToDo;

    [RelayCommand]
    public void CreateToDo()
    {
        var todo = new Todo(ToDoTitle, ToDescription);
        OpenToDos.Add(todo);
    }

    [RelayCommand]
    public void ChangeToDo()
    {
        if (SelectedOpenToDo is null)
        {
            return;
        }
        ClosedToDos.Add(SelectedOpenToDo);
        OpenToDos.Remove(SelectedOpenToDo);
    }
}
