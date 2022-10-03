using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.SearchingAlgorithms
{
    public class Search
    {
        /// <summary>
        /// Linear Search algorithm example
        /// </summary>
        /// <param name="listOfData">array of data</param>
        /// <param name="searchKey">which key is search</param>
        /// <returns>retunr index</returns>
        public int LinearSearch(int[] listOfData, int searchKey)
        {
            for (int i = 0; i < listOfData.Length; i++)
            {
                if (listOfData[i] == searchKey)
                    return i;
            }

            return -1;
        }

        /// <summary>
        /// Binary Search alogorithms example using itterative
        /// </summary>
        /// <param name="listOfData"></param>
        /// <param name="searchKey"></param>
        /// <returns></returns>
        public int BinearySearchItterative(int[] listOfData, int searchKey)
        {
            int leftIndex = 0, rightIndex = listOfData.Length - 1;
            while(leftIndex <= rightIndex)
            {
                int midIndex = (leftIndex + rightIndex) / 2;
                if (listOfData[midIndex] == searchKey)
                    return midIndex;
                else if (searchKey < listOfData[midIndex])
                    rightIndex = midIndex - 1;
                else if (searchKey > listOfData[midIndex])
                    leftIndex = midIndex + 1;
            }

            return -1;
        }

        public int BinarySearchRecursive(int[] listOfData, int searchKey, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
                return -1;
            else
            {
                int mid = (leftIndex + rightIndex) / 2;
                if (searchKey == listOfData[mid])
                    return mid;
                else if (searchKey < listOfData[mid])
                    return BinarySearchRecursive(listOfData, searchKey, leftIndex, mid - 1);
                else if (searchKey > listOfData[mid])
                    return BinarySearchRecursive(listOfData, searchKey, mid + 1, rightIndex);
            }
            return -1;
        }
    }
}
