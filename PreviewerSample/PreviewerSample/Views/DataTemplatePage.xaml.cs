using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PreviewerSample.Views
{
    public partial class DataTemplatePage : ContentPage
    {
        public DataTemplatePage()
        {
            InitializeComponent();

            var perple = new List<Person>(){
                new Person("Ichiro", 30 ),
                new Person("Jiro", 27),
                new Person("Sabro", 22),
                new Person("Yoshito Tabuchi", 41)
            };

            this.BindingContext = perple;


        }
    }

    public class PersonDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ValidTemplate { get; set; }
        public DataTemplate InvalidTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Person)item).Age <= 40 ? ValidTemplate : InvalidTemplate;
        }
    }

    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}

