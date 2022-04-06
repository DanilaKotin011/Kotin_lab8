using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ReactiveUI;
using System.Reactive;
using Avalonia.Media;
using Kotin_lab8.Models;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using System.IO;

namespace Kotin_lab8.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Scheduled = BuildAllNotesSchedelued();
            InWork = BuildAllNotesInWork();
            Completed = BuildAllNotesCompleted();
            DeleteScheduled = ReactiveCommand.Create<Note>((item) =>
            {
                Scheduled.Remove(item);
            });
            DeleteInWork = ReactiveCommand.Create<Note>((item) =>
            {
                InWork.Remove(item);
            });
            DeleteCompleted = ReactiveCommand.Create<Note>((item) =>
            {
                Completed.Remove(item);
            });
            ButtonAddImage = ReactiveCommand.Create<Note, Unit>((item) =>
            {
                GetPath(item);
                return Unit.Default;
            });


        }
        public ObservableCollection<Note> Scheduled { get; set; }

        private ObservableCollection<Note> BuildAllNotesSchedelued()
        {
            return new ObservableCollection<Note>
            {
                new Note("Header 1","Task 1"),
                new Note("Header 2","Task 2"),
                new Note("Header 3","Task 3"),
            };
        }

        public ObservableCollection<Note> InWork { get; set; }

        private ObservableCollection<Note> BuildAllNotesInWork()
        {
            return new ObservableCollection<Note>
            {
                new Note("Header 1","Task 1"),
                new Note("Header 2","Task 2"),
                new Note("Header 3","Task 3"),
            };
        }

        public ObservableCollection<Note> Completed { get; set; }

        private ObservableCollection<Note> BuildAllNotesCompleted()
        {
            return new ObservableCollection<Note>
            {
                new Note("Header 1","Task 1"),
                new Note("Header 2","Task 2"),
                new Note("Header 3","Task 3"),
            };
        }

        public ReactiveCommand<Note, Unit> DeleteScheduled { get; }
        public ReactiveCommand<Note, Unit> DeleteInWork { get; }
        public ReactiveCommand<Note, Unit> DeleteCompleted { get; }
        public ReactiveCommand<Note, Unit> ButtonAddImage { get; }

        private async void GetPath(Note item)
        {   
            var taskPath = new OpenFileDialog()
            {
                Title = "Choose file",
                Filters = null
            };
            string[]? path2 = await taskPath.ShowAsync((Window)this.VisualRoot);
            if (path2 != null) item.PathImage = string.Join(@"\", path2);
        }

        public Window? view = (Window)this.VisualRoot;
    }
}
