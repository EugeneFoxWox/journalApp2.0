using journalApp2._0.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace journalApp2._0.ViewModels
{
    internal class Window1ViewModel : ViewModel
    {
        private double height1;
        private double height2;
        private double base1;
        private double base2;
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
        public double Base1
        {
            get { return base1; }
            set { Set(ref base1, value); }
        }
        public double Base2
        {
            get { return base2; }
            set { Set(ref base2, value); }
        }


    }
}
