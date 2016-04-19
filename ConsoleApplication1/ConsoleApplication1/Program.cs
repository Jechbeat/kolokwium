using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 14,7,3,12,9,11,6,2};
            list = MergeSort(list);
        }

        public static List<int> MergeSort(List<int> lista)
        {
            int p = 0;
            int r = lista.Count - 1;
            int q = (p + r) / 2;

            if(p < r)
            {
                List<int> sublist1 = MergeSort(SubList(lista, p, q));
                List<int> sublist2 = MergeSort(SubList(lista, q + 1, r));
                return Merge(sublist1, sublist2);
            }
            else
            {
                return lista;
            }
        }

        public static List<int> SubList(List<int> lista, int from, int to)
        {
            List<int> sublist = new List<int>();
            for(int i = from; i <= to; i++)
            {
                sublist.Add(lista[i]);
            }

            return sublist;
        }

        public static List<int> Merge(List<int> lista1, List<int> lista2)
        {
            List<int> mergelist = new List<int>();
            int x = 0;
            int y = 0;
            for(int i = 0; i < (lista1.Count) + (lista2.Count); i++)
            {               
                if(lista2.Count < y + 1 || lista1[x] < lista2[y])
                {
                    mergelist.Add(lista1[x++]);
                }
                else
                {
                    mergelist.Add(lista2[y++]);
                }
            }

            return mergelist;
        }


    }
}
