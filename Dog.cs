using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDogCsharp
{
    public class Dog : Observer
    {
        public Cat cat;
        public Dog (string name): base( name)
        {

        }

       public  override void Notify(Observer observer,Subject subject)
        {
           
        }
       public void Smell(Dog dog,Cat cat )
        {
            cat.RegisterObserver(cat, this);
            Console.WriteLine(this.name + " Just smelled " + cat.name);
        }
    }
}
