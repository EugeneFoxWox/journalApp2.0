using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using journalApp2._0.Infrastructure.Commands;
using journalApp2._0.ViewModels.Base;
using journalApp2._0.Views.Windows;

namespace journalApp2._0.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string title="УП наше крутое";
        /// <summary>
        /// Заголовок окна 
        /// </summary>
        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }

        private string status = "Готов";
        public string Status
        {
            get { return status; }
            set { Set(ref status, value); }
        }

        //Первая задача
        private double ab ;
        private double ad ;
        private double dc ;
        public double Ab
        {
            get { return ab; }
            set { Set(ref ab, value); }
        }
        public double Ad
        {
            get { return ad; }
            set { Set(ref ad, value); }
        }
        public double Dc
        {
            get { return dc; }
            set { Set(ref dc, value); }
        }
        private string per;

        public string Per
        {
            get { return per; }
            set { Set(ref per, value); }
        }


        public ICommand FirstCommand { get; }
        public ICommand GoSecond { get;  }
        private bool CanFirstCommandExecute(object p) => true;
        private bool CanGoSecondExecute(object p) => true;
        
        private void FirstCommandExecute(object p)
        {

            Per = (Math.Sqrt(Ab * Ab + Ad * Ad) + Math.Sqrt(Ad * Ad + Dc * Dc) + Ab + Ad + Dc).ToString();
        
        }

        private void GoSecondExecute(object p)
        {
            Window1 window = new Window1();
            window.ShowDialog();
        }

        public MainWindowViewModel()
        {
            FirstCommand = new LambdaCommand(FirstCommandExecute, CanFirstCommandExecute);
            GoSecond = new LambdaCommand(GoSecondExecute, CanGoSecondExecute);
        }
    }
}
