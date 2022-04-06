﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Media;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Avalonia.Media.Imaging;

namespace Kotin_lab8.Models
{
    public class Note : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Note(string hd, string tsk)
        {
            head = hd;
            task = tsk;
        }

        string? pathimage = null;
        public string? PathImage
        {
            get { return pathimage; }
            set
            {
                pathimage = value;
                NotifyPropertyChanged();
            }
        }

        Bitmap? image = null;
        public Bitmap? Image
        {
            get { return image; }
            set
            {
                image = value;
                NotifyPropertyChanged();
            }
        }

        string head;
        public string Head
        {
            get { return head; }
            set { head = value; NotifyPropertyChanged(); }
        }

        string task;

        public string Task
        {
            get { return task; }
            set { task = value; NotifyPropertyChanged(); }
        }
    }
}