using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using TaskNoter.MVVM.Models;


namespace TaskNoter.MVVM.ViewModels
{
    internal class NewTaskViewModel
    {
        public string Task {  get; set; }
        public ObservableCollection<MyTask> Tasks { get; set; }
        public ObservableCollection<Category> Categories { get; set; }
    }
}
