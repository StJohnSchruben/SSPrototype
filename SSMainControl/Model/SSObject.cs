using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMainControl.Model
{
    public class SSObject
    {
        readonly List<SSObject> items = new List<SSObject>();
        public IList<SSObject> Items
        {
            get { return items; }
        }

        public string Name { get; set; }
    }
}
