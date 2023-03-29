using journalApp2._0.Infrastructure.Commands;
using journalApp2._0.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace journalApp2._0.ViewModels
{
    internal class Window1ViewModel : ViewModel
    {
        private double height1;
        private double height2;
        private double base11;
        private double base12;
        private double base21;
        private double base22;
        public double Height1
        {
            get { return height1; }
            set { Set(ref height1, value); }
        }
        public double Height2
        {
            get { return height2; }
            set { Set(ref height2, value); }
        }
        public double Base11
        {
            get { return base11; }
            set { Set(ref base11, value); }
        }
        public double Base12
        {
            get { return base12; }
            set { Set(ref base12, value); }
        }
        public double Base21
        {
            get { return base21; }
            set { Set(ref base21, value); }
        }
        public double Base22
        {
            get { return base22; }
            set { Set(ref base22, value); }
        }
        private string result;

        public string Result
        {
            get { return result; }
            set { Set(ref result, value); }
        }
        
        public ICommand TrapCommand { get; }

        private bool CanTrapCommandExecute(object p) => true;

        private void TrapCommandExecute(object p)
        {
            double c1 = Math.Sqrt(Height1 * Height1 + ((Base11 - Base12) / 2) * ((Base11 - Base12) / 2));
            double c2 = Math.Sqrt(Height2 * Height2 + ((Base21 - Base22) / 2) * ((Base21 - Base22) / 2));
            Result = (Base11 + Base12 + Base21 + Base22 + c1+ c1 + c2 + c2).ToString();
        }
        public Window1ViewModel()
        {
            TrapCommand = new LambdaCommand(TrapCommandExecute, CanTrapCommandExecute);
        }

    }
}
