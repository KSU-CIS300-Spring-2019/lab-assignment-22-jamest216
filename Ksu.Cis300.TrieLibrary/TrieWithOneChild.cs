using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    public class TrieWithOneChild : ITrie
    {
        /// <summary>
        /// 
        /// </summary>
        private bool _contains;

        /// <summary>
        /// 
        /// </summary>
        private ITrie _child;

        /// <summary>
        /// 
        /// </summary>
        private char _label;

        public ITrie Add(string s)
        {
            if(s == "")
            {
                _contains = true;
            }
            return this;
        }

        public bool Contains(string s)
        {
            if(s == "")
            {
                return _contains;
            }
            return false;
        }

        public TrieWithOneChild(bool b, string s)
        {
            if (s == "" || (s[0] < 'a' || s[0] > 'z'))
            {
                throw new ArgumentException();
            }
            else
            {
                _contains = b;
                _label = s[0];
                _child = new TrieWithNoChildren().Add(s.Substring(1));
            }
        }
    }
}
