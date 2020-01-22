﻿using NieGadalismyOGrach.Interfaces;
using System;
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
    /// Interaction logic for CounterDecrease.xaml
    /// </summary>
    public partial class CounterDecrease : Window, IGameStage
    {
        private int counter = 50;

        private Random rng = new Random();

        public CounterDecrease()
        {
            InitializeComponent();
        }

        public string StageName { get => "Decrease the counter"; }

        public Action OnStageWin { get; set; }

        public Action OnStageLose { get; set; }

        public void OnStageEnd()
        {
        }

        public void OnStageStart()
        {
            counter = 50;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int decreaseAmount = rng.Next(1, 5);
            counter -= decreaseAmount;
            this.Btn1.Content = counter.ToString();

            if (counter == 0)
            {
                OnStageWin?.Invoke();
            }

            if (counter < 0)
            {
                OnStageLose?.Invoke();

                if (OnStageLose == null)
                {
                    Close();
                }
            }
        }
    }
}