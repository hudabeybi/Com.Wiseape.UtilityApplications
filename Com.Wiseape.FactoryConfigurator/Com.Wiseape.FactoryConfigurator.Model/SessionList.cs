using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.FactoryConfigurator.Model
{
    public class SessionList
    {
        private List<SavedSession> sessionList = new List<SavedSession>();
        public List<SavedSession> Sessions { get
            {
                return sessionList;
            }
            set
            {
                sessionList = value;
            }
        }
    }
}
