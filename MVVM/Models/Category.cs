using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNoter.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Category
    {
        // will add id to catergory
        public int Id { get; set; }

        // will assign a name to category
        public string CategoryName { get; set; }

        // what colour we can assign to cat
        public string Color { get; set; }

        // tasks that we will assign to the cat
        public int PendingTasks { get; set; }

        // complete rate of task
        public float Percentage { get; set; }

        public bool IsSelected { get; set; }
    }
}
