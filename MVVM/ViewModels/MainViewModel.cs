using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskNoter.MVVM.Models;

namespace TaskNoter.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<MyTask> Tasks { get; set; }

        public MainViewModel() 
        {
            FillData();
        }

        public void FillData()
        {
            Categories = new ObservableCollection<Category>
            {
                // number of category along with id, the name (not yet assigned) and colour representation
                new Category
                {
                    Id = 1,
                    CategoryName = "Watch Anime",
                    Color = "#800080"
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Daily Chores",
                    Color = "#008000"
                },
                new Category
                {
                    Id = 3,
                    CategoryName = "Outside Tasks",
                    Color = "#0000FF"
                }
            };

            Tasks = new ObservableCollection<MyTask>
            {
               new MyTask
                {
                    TaskName = "Create a watch list",
                    Completed = false,
                    CategoryId = 1
                },
                new MyTask
                {
                    TaskName = "Finish Fate Series",
                    Completed = true,
                    CategoryId = 1
                },
                new MyTask
                {
                    TaskName = "Mow the lawn ",
                    Completed = false,
                    CategoryId = 2
                },
                new MyTask
                {
                    TaskName = "Clear the gutters",
                    Completed = false,
                    CategoryId = 2
                },
                new MyTask
                {
                    TaskName = "Laundray",
                    Completed = true,
                    CategoryId = 2
                },
                new MyTask
                {
                    TaskName = "Pick up groceries from Pak N Save",
                    Completed = false,
                    CategoryId = 3
                },
                new MyTask
                {
                    TaskName = "Famers Market",
                    Completed = false,
                    CategoryId = 3
                },
            };

            UpdateData();
        }

        public void UpdateData()
        {
            foreach (var c in Categories)
            {
                var tasks = from t in Tasks
                            where t.CategoryId == c.Id
                            select t;

                var completed = from t in tasks
                                where t.Completed == true
                                select t;

                var notCompleted = from t in tasks
                                   where t.Completed == false
                                   select t;


                c.PendingTasks = notCompleted.Count();
                c.Percentage = (float)completed.Count() / (float)tasks.Count();
            }

            foreach (var t in Tasks)
            {
                var categoryColor =
                    (from c in Categories
                     where c.Id == t.CategoryId
                     select c.Color).FirstOrDefault();
                t.TaskColor = categoryColor;
            }
        } 
    }
}
