using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidLibrary
{
    [AttributeUsage(AttributeTargets.All)]
    public class GUID : Attribute
    {
        private string guid { get; set; }

        public GUID()
        {
            this.guid = Guid.NewGuid().ToString();
        }

        public GUID(string value)
        {
            this.guid = value;
        }

        public string getGuid()
        {
            return guid;
        }
    }
}
