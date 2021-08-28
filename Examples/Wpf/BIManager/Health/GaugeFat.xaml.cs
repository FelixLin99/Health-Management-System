﻿using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Wpf
{

    public partial class GaugesFat : UserControl, INotifyPropertyChanged
    {
        private double _value;

        public GaugesFat()
        {
            InitializeComponent();

            Value = 0;

            DataContext = this;
        }

        public double Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        private void ChangeValueOnClick(object sender, RoutedEventArgs e)
        {
            Value = new Random().Next(50, 250);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
