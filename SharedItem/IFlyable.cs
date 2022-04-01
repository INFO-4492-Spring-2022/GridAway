using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedItems {
    interface IFlyable<T> {
        string Fly();
        string Land();

        void AddPassengers(T pass);
    }
}
