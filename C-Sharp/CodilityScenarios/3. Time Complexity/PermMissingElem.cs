﻿using System.Linq;

namespace CodilityScenarios
{
    /// <summary>
    /// Write a function that, given a zero-indexed array A, 
    /// returns the value of the missing element.
    /// </summary>
    public class PermMissingElem
    {
        public int solution(int[] numericArray){

            int minimalReturnValue = 1;

            // defensive code
            if (!numericArray.Any())
            {
                return minimalReturnValue;
            }

            // Get the range from min to max, find exceptions in the array
            return Enumerable.Range(minimalReturnValue, numericArray.Max() + 1)
                                    .Except(numericArray)
                                    .FirstOrDefault();
        }
    }
}