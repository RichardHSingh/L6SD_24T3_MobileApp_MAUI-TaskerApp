using TaskNoter.MVVM.ViewModels;
using TaskNoter.MVVM.Models;

namespace TaskNoter.MVVM.Views;


public partial class NewTaskView : ContentPage
{
	public NewTaskView()
	{
		InitializeComponent();
    }

    private async void AddTaskBTN_Clicked(object sender, EventArgs e)
    {
        var vm = BindingContext as NewTaskViewModel;

        var selectedCategory =
            vm.Categories.Where(x => x.IsSelected == true).FirstOrDefault();

        if (selectedCategory != null)
        {
            var task = new MyTask
            {
                TaskName = vm.Task,
                CategoryId = selectedCategory.Id,
            };
            vm.Tasks.Add(task);
            await Navigation.PopAsync();
        }
        else
        {
            await DisplayAlert("Invalid Input", "Please select a category!", "Affirmative");
        }
    }

    private async void AddCategoryBTN_Clicked(object sender, EventArgs e)
    {
        var vm = BindingContext as NewTaskViewModel;

        string category =
            await DisplayPromptAsync("New Category",
            "Implement a new category name",
            maxLength: 20,
            keyboard: Keyboard.Text);

        var random = new Random();

        if (!string.IsNullOrEmpty(category))
        {
            vm.Categories.Add(new Category
            {
                Id = vm.Categories.Max(x => x.Id) + 1,
                Color = Color.FromRgb(
                    random.Next(0, 255),
                    random.Next(0, 255),
                    random.Next(0, 255)).ToHex(),
                CategoryName = category,
            });
        }
    }
}