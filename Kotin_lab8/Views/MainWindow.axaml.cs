
using Avalonia.Controls;
using System;
using System.IO;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Interactivity;
using Kotin_lab8.ViewModels;
using Kotin_lab8.Models;

namespace Kotin_lab8.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.FindControl<Button>("Add0").Click += async delegate
            {
                var context = (this.DataContext as MainWindowViewModel);
                Note newnote = new Note("New Note", "");
                context.Scheduled.Add(newnote);
            };
            this.FindControl<Button>("Add1").Click += async delegate
            {
                var context = (this.DataContext as MainWindowViewModel);
                Note newnote = new Note("New Note", "");
                context.InWork.Add(newnote);
            };
            this.FindControl<Button>("Add2").Click += async delegate
            {
                var context = (this.DataContext as MainWindowViewModel);
                Note newnote = new Note("New Note", "");
                context.Completed.Add(newnote);
            };
            
            
        }
    }
}
