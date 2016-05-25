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
using PreviewerSample.Models;
using Xamarin.Forms;

namespace PreviewerSample.ViewModels
{
    public class PersonsViewModel : INotifyPropertyChanged
    {
        
        public PersonsViewModel()
        {
            _persons = new ObservableCollection<Person>();
            //_persons.CollectionChanged += _persons_CollectionChanged;

            this.Persons.Add(new Person { Name = "John Silverstain", City = "MELBOURNE", Department = "Marketing", Age = 29, Followers = 243, Photo = "friend_thumbnail_01.jpg" });
            this.Persons.Add(new Person { Name = "Pam Tailor", City = "SIDNEY", Department = "Design", Age = 32, Followers = 24, Photo = "friend_thumbnail_05.jpg" });
            this.Persons.Add(new Person { Name = "Casy Niman", City = "HOBART", Department = "Accounts", Age = 58, Followers = 267, Photo = "friend_thumbnail_06.jpg" });
            this.Persons.Add(new Person { Name = "Gorge Tach", City = "NEWCASTLE", Department = "Design", Age = 29, Followers = 127, Photo = "friend_thumbnail_04.jpg" });
            this.Persons.Add(new Person { Name = "Cristina Maciel", City = "HOBART", Department = "MobileDev.", Age = 32, Followers = 80, Photo = "friend_thumbnail_02.jpg" });
            this.Persons.Add(new Person { Name = "Simon Deuva", City = "MELBOURNE", Department = "Media", Age = 58, Followers = 420, Photo = "friend_thumbnail_03.jpg" });
            this.Persons.Add(new Person { Name = "田淵 義人", City = "東京本社", Department = "ソフトウェア事業部", Age = 41, Followers = 924, Photo = "friend_thumbnail_07.jpg" });

            _personCount = Persons.Count;

            this.FilterCommand = new Command(() =>
            {
                var filtered = this.Persons.Where(x => x.Followers > this.FilterNumber).ToList();
                this.Persons.Clear();

                foreach (var item in filtered)
                {
                    this.Persons.Add(item);
                    PersonCount = Persons.Count;
                }
            });

            this.ResetCommand = new Command(() =>
            {
                this.Persons.Clear();
                this.Persons.Add(new Person { Name = "John Silverstain", City = "MELBOURNE", Department = "Marketing", Age = 29, Followers = 243, Photo = "friend_thumbnail_01.jpg" });
                this.Persons.Add(new Person { Name = "Pam Tailor", City = "SIDNEY", Department = "Design", Age = 32, Followers = 24, Photo = "friend_thumbnail_05.jpg" });
                this.Persons.Add(new Person { Name = "Casy Niman", City = "HOBART", Department = "Accounts", Age = 58, Followers = 267, Photo = "friend_thumbnail_06.jpg" });
                this.Persons.Add(new Person { Name = "Gorge Tach", City = "NEWCASTLE", Department = "Design", Age = 29, Followers = 127, Photo = "friend_thumbnail_04.jpg" });
                this.Persons.Add(new Person { Name = "Cristina Maciel", City = "HOBART", Department = "MobileDev.", Age = 32, Followers = 80, Photo = "friend_thumbnail_02.jpg" });
                this.Persons.Add(new Person { Name = "Simon Deuva", City = "MELBOURNE", Department = "Media", Age = 58, Followers = 420, Photo = "friend_thumbnail_03.jpg" });
                this.Persons.Add(new Person { Name = "田淵 義人", City = "港区", Department = "ソフトウェア事業部", Age = 41, Followers = 924, Photo = "friend_thumbnail_07.jpg" });
                PersonCount = Persons.Count;
            });
        }

        public ICommand FilterCommand { get; protected set; }

        public ICommand ResetCommand { get; protected set; }

        private ObservableCollection<Person> _persons;
        public ObservableCollection<Person> Persons
        {
            get { return this._persons; }
            set
            {
                if (_persons != value)
                    _persons = value;
                OnPropertyChanged();
            }
        }

        private int _personCount;
        public int PersonCount
        {
            get { return _personCount; }
            set
            {
                if (_personCount != value)
                {
                    _personCount = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _filterNumber;
        public int FilterNumber
        {
            get { return _filterNumber; }
            set
            {
                if (_filterNumber != value)
                {
                    _filterNumber = value;
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










#region CollectionChanged
//void _persons_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
//{
//    if (e.Action == NotifyCollectionChangedAction.Replace)
//    {
//        foreach (Person item in e.OldItems)
//            item.PropertyChanged -= MyType_PropertyChanged;
//        foreach (Person item in e.NewItems)
//            item.PropertyChanged += MyType_PropertyChanged;
//    }
//    else if (e.Action == NotifyCollectionChangedAction.Add)
//    {
//        foreach (Person item in e.NewItems)
//            item.PropertyChanged += MyType_PropertyChanged;
//    }
//    else if (e.Action == NotifyCollectionChangedAction.Remove)
//    {
//        foreach (Person item in e.OldItems)
//            item.PropertyChanged -= MyType_PropertyChanged;
//    }
//    //else if (e.Action == NotifyCollectionChangedAction.Reset)
//    //{
//    //    this.Persons.Clear();
//    //}
//}

//void MyType_PropertyChanged(object sender, PropertyChangedEventArgs e)
//{
//    //change event hook here
//    System.Diagnostics.Debug.WriteLine(e.PropertyName);
//}
#endregion
