﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NieGadalismyOGrach
{
    /// <summary>
    /// Logika interakcji dla klasy TheEnd.xaml
    /// </summary>
    public partial class TheEnd : Window
    {
        public TheEnd()
        {
            InitializeComponent();
            endLabel.Content = Properties.Resources.THEEND;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
