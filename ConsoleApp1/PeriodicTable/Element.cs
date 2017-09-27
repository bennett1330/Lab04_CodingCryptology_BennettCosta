using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.PeriodicTable
{
    public class Element
    {

        public int AtomicNumber { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public double AtomicWeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="atomicNumber"></param>
        /// <param name="symbol"></param>
        /// <param name="name"></param>
        /// <param name="atomicWeight"></param>
        public Element(int atomicNumber, string symbol, string name, double atomicWeight)
        {
            AtomicNumber = atomicNumber;
            Symbol = symbol;
            Name = name;
            AtomicWeight = atomicWeight;
        }

    }
}
