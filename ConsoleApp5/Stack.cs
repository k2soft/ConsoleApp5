using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Stack : IEnumerable
    {

        int[] table;

        public int[] Table { get => table; set => table = value; }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i<10;i++)
            {

                yield return Table[i];
            }
            yield break;
        }

        public IEnumerable FromToBy (int from, int to, int by)
        {
            for (int i = from; i<=to; i+=by)
            {
                yield return Table[i];

            }

        }

    }//class
}
