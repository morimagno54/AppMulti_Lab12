using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mori_Lab11
{
    public class TaskViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Task> Tasks { get; set; } = new ObservableCollection<Task>();

        private string newTaskTitle;
        public string NewTaskTitle
        {
            get { return newTaskTitle; }
            set
            {
                if (newTaskTitle != value)
                {
                    newTaskTitle = value;
                    OnPropertyChanged(nameof(NewTaskTitle));
                }
            }
        }

        private string newTaskDescription;
        public string NewTaskDescription
        {
            get { return newTaskDescription; }
            set
            {
                if (newTaskDescription != value)
                {
                    newTaskDescription = value;
                    OnPropertyChanged(nameof(NewTaskDescription));
                }
            }
        }

        public ICommand AddTaskCommand => new Command(Insertar);

        private void Insertar()
        {
            Task newTask = new Task
            {
                Title = NewTaskTitle,
                Description = NewTaskDescription
            };

            Tasks.Add(newTask);
            OnPropertyChanged(nameof(Tasks));

            // Limpiar los campos después de agregar la tarea
            NewTaskTitle = string.Empty;
            NewTaskDescription = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
