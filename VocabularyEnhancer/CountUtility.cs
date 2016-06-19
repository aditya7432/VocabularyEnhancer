using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyEnhancer
{
    class CountUtility
    {
        private static int _SetChances = 5, _Setmarks = 0;

        public static int Setmarks
        {
            get { return _Setmarks; }
            set { _Setmarks = value; }
        }
        public static int SetChances
        {
            get { return _SetChances; }
            set { _SetChances = value; }
        }
    }
}
