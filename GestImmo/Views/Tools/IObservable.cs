using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Views.Tools
{
    public interface IObservable
    {

        List<IObserver> Observers { get; set; }  

        void notifyObservers()
        {
            foreach (IObserver obs in Observers)
            {
                obs.update();
            }
        }
    }
}
