using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace coreConsoleApp
{
    internal class stringIndexerType
    {
        private string[] strArray = new string[10];
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= strArray.Length)
                    throw new ArgumentOutOfRangeException("Index is out of range.");
                return strArray[index];
            }
            set
            {
                if (index < 0 || index >= strArray.Length)
                    throw new IndexOutOfRangeException("Index is out of range.");
                strArray[index] = value;
            }
        }
    }
}