using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace INotify_Property_Changed {
    public class Car : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        public string _brand { get; set; }
        public string _model { get; set; }
        public int _power { get; set; }

        public Car(string brand, string model, int power) {
            _brand = brand;
            _model = model;
            _power = power;
        }


        public void changeBrand(string newBrand) {
            _brand = newBrand;
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs("Brand"));
            }
        }

        public void changeModel(string newModel) {
            _model = newModel;
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs("Model"));
            }
        }

        public void changePower(int newPower) {
            _power = newPower;
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs("Power"));
            }
        }
    }
}
