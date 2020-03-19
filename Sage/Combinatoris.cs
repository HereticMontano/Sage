using System;
using System.Collections.Generic;
using System.Linq;

namespace Sage
{
    public static class Combinatoris
    {
        public static bool SplitArray(int[] input)
        {
            if (input.Length == 2)
                return input[0] == input[1];

            foreach (var item in input)
            {
                for (int i = input.Length - 2; i >= 0; i--)
                {
                    List<int> firstList = input.ToList();
                    List<int> secondList = new List<int> { item };
                    firstList.Remove(item);

                    for (int j = i; j >= 0; j--)
                    {
                        var actualElement = firstList[j];
                        secondList.Add(actualElement);
                        firstList.Remove(actualElement);

                        if (firstList.Sum() == secondList.Sum())
                            return true;
                        else if (secondList.Count > input.Length / 2)
                        {
                            firstList.Add(actualElement);
                            secondList.Remove(actualElement);
                        }

                    }
                }
            }

            return false;
        }
    }
}
