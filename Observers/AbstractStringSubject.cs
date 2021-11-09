using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{


    abstract class AbstractStringSubject : ISubject<AbstractStringSubject>
    {

       private ICollection<IObserver<AbstractStringSubject>> observers;

       private string item;

       public string Item
       {
           get => item;

           protected set // com "protected" só classes derivadas de Observers acedem ao set//
           {
               item = value;
               
               foreach(IObserver<AbstractStringSubject> obs in observers)
               {
                   obs.Update(this);
               }

           }


       }

       protected AbstractStringSubject()
       {
           observers = new List<Observer<AbstractStringSubject>>();


       }

        public void RegisterObserver(IObserver<AbstractStringSubject> obs)
        {



        }
        void RemoveObserver(IObserver<AbstractStringSubject> obs)
        {



        }


    }
}