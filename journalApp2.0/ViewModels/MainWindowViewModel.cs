using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using journalApp2._0.Infrastructure.Commands;
using journalApp2._0.ViewModels.Base;

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
        private double per;

        public double Per
        {
            get { return per; }
            set { Set(ref per, value); }
        }
        public double Button_Click()
        {

            per = Math.Sqrt(ab* ab + ad* ad)+ Math.Sqrt(ad* ad + dc* dc)+ ab + ad + dc;
            return per;
        }


        public ICommand FirstCommand { get; }
        private bool CanFirstCommandExecute(object p) => true;
        
        private void FirstCommandExecute(object p)
        {

            per = Math.Sqrt(ab * ab + ad * ad) + Math.Sqrt(ad * ad + dc * dc) + ab + ad + dc;
            per.ToString();
        
        }

        public MainWindowViewModel()
        {
            FirstCommand = new LambdaCommand(FirstCommandExecute, CanFirstCommandExecute);
        }
    }
}
