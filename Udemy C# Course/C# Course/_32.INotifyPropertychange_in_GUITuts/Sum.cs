using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.INotifyPropertychange_in_GUITuts
{
    public class Sum : INotifyPropertyChanged
    {

        private string num1;
        private string num2;
        private string sum;

        public string Num1 { 
            get { return num1; }
            set {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) num1 = value;
                OnPropertyChange("Num1");
                OnPropertyChange("Result");
            }
        }

        public string Num2
        {
            get { return num2; }
            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) num2 = value;
                OnPropertyChange("Num1");
                OnPropertyChange("Result");
            }
        }

        public string Result
        {
            get {
                int res = int.Parse(Num1) + int.Parse(Num2);
                return res.ToString();
            }
            set
            {
                int res = int.Parse(Num1) + int.Parse(Num2);
                Result =  res.ToString();
                OnPropertyChange("Result");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChange(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
