using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedItems {
    public class Lair<T> {

        private List<T> _Members;

        public Lair() {
            Members = new List<T>();
        }

        public List<T> Members {
            get {
                if(_Members == null) {
                    _Members = new List<T>();
                }
                return _Members;
            }
            private set {
                _Members = value;
            }
        }

        public void Add(T per) {
            Members.Add(per);
        }

    }
}
