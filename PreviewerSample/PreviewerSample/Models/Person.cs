using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PreviewerSample.Models
{
    public class Person : INotifyPropertyChanged
    {
        //public string Name { get; }
        //public string City { get; }
        //public string Depertment { get; }
        //public int Age { get; }
        //public int Followers { get; }
        //public string Photo { get; }

        //public Person(string name, string city, string depertment, int age, int followers, string photo)
        //{
        //    this.Name = name;
        //    this.City = city;
        //    this.Depertment = depertment;
        //    this.Age = age;
        //    this.Followers = followers;
        //    this.Photo = photo;
        //}

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _department;
        public string Department
        {
            get { return _department; }
            set
            {
                if (_department != value)
                {
                    _department = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _followers;
        public int Followers
        {
            get { return _followers; }
            set
            {
                if (_followers != value)
                {
                    _followers = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _photo;
        public string Photo
        {
            get { return _photo; }
            set
            {
                if (_photo != value)
                {
                    _photo = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

