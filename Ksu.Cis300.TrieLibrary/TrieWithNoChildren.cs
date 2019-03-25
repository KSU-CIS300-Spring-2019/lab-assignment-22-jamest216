using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    class TrieWithNoChildren : ITrie
    {
        private bool _contains = false;
        public ITrie Add(string s)
        {
            if(s == "")
            {
                _contains = true;
            }
            else
            {
                return new TrieWithOneChild(_contains, s);
            }
            return this;
        }

        public bool Contains(string s)
        {
            if(s != "")
            {
                return false;
            }
        }
    }
}
