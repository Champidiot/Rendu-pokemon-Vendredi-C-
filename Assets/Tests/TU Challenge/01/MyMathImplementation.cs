using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        

        internal static int Add(int a, int b)
        {
            return a + b;
        }

        internal static List<int> GenericSort(List<int> toSort, Func<int, int, bool> isInOrder)
        {
            throw new NotImplementedException();
        }

        internal static List<int> GetAllPrimary(int a)
        {

            List<int> list = new List<int>();

              for (int i = 2; i<=a; i++)
            {
                for (int u = 2; u <= Mathf.Sqrt(a); u++)
                {
                    if (a % u == 0)
                    {
                        
                    }
                }
                list.Add(i);
            }
              return list;
        }

        internal static bool IsDivisible(int a, int b)
        {
            return a%b == 0;
        }

        internal static bool IsEven(int a)
        {
            return a%2 == 0;
        }

        internal static bool IsInOrder(int a, int b)
        {
            return a < b;
        }

        internal static bool IsInOrderDesc(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }

        internal static bool IsListInOrder(List<int> list)
        {
            throw new NotImplementedException();
        }

        internal static bool IsMajeur(int age)
        {
            if (age < 0) throw new ArgumentException();

            //return age >= 18;
            if (age >= 18) return true; 
            else return false;
        }

        internal static bool IsPrimary(int a)
        { 
            for(int i = 2; i <= Mathf.Sqrt(a); i++)
            {
                if(a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        internal static int Power(int a, int b)
        {
            int newA = a;

            for(int i = 1; i<b; i++)
            {
                newA *= a;
            }

            return newA;
        }

        internal static int Power2(int a)
        {
            return a * a;
        }

        internal static List<int> Sort(List<int> toSort)
        {
            List<int> listSorted = new List<int>();

            List<int> listToSort = toSort;

            int a = 0;

            int b = 0;

            a = listToSort[0];

            listToSort.Remove(a);

            listSorted.Add(a);

            while(listToSort.Count > 0)
            {
                b = listToSort[0];
                listToSort.Remove(b);

                for(int i = 1; i <= listSorted.Count; i++)
                {
                    if(b < listSorted[i-1])
                    {
                        listSorted.Insert(i-1, b);
                        i = listSorted.Count + 1;
                    }

                    else if (i == listSorted.Count)
                    {
                        listSorted.Insert(i, b);
                        i += 1;
                    }
                }
            }

            return listSorted;

        }
    }
}
