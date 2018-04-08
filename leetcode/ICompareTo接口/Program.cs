﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable接口
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<Temperature, string> temps =
             new SortedList<Temperature, string>();

            // Add entries to the sorted list, out of order.
            temps.Add(new Temperature(2017.15), "Boiling point of Lead");
            temps.Add(new Temperature(0), "Absolute zero");
            temps.Add(new Temperature(273.15), "Freezing point of water");
            temps.Add(new Temperature(5100.15), "Boiling point of Carbon");
            temps.Add(new Temperature(373.15), "Boiling point of water");
            temps.Add(new Temperature(600.65), "Melting point of Lead");

            foreach (KeyValuePair<Temperature, string> kvp in temps)
            {
                Console.WriteLine("{0} is {1} degrees Celsius.", kvp.Value, kvp.Key.Celsius);
            }
            Console.ReadLine();
        }
    }

    public class Temperature : IComparable<Temperature>
    {
        // Implement the generic CompareTo method with the Temperature 
        // class as the Type parameter. 
        //
        public int CompareTo(Temperature other)
        {
            // If other is not a valid object reference, this instance is greater.
            if (other == null) return 1;

            // The temperature comparison depends on the comparison of 
            // the underlying Double values. 
            return m_value.CompareTo(other.m_value);
        }

        // The underlying temperature value.
        protected double m_value = 0.0;

        public double Celsius
        {
            get
            {
                return m_value - 273.15;
            }
        }

        public double Kelvin
        {
            get
            {
                return m_value;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("Temperature cannot be less than absolute zero.");
                }
                else
                {
                    m_value = value;
                }
            }
        }

        public Temperature(double kelvins)
        {
            this.Kelvin = kelvins;
        }
    }

}





