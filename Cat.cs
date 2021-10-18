using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDogCsharp
{
    public  class Cat : Subject
    {
        public Observer observer;
        //public Subject subject;
        public Cat(string name, int type) : base(name, type)
        {
            
        }
        /*public enum CatEvent
        {
            SPEAK= 0
        }*/
        public void Speak(Cat cat)
        {
            Console.WriteLine("My name is " + cat.name + " miau");
            NotifyObservers(cat);
        }

       /* public override int RegisterObserver(Subject subject, Observer observer)
        {
           
        }*/
    }
}
