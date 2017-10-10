using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IMeanCalculator
    {
        double CalculateMean(List<double> data);
    }
    internal class AverageCalculator : IMeanCalculator
    {
        public double CalculateMean(List<double> data)
        {
            if (data.Count == 0)
                return 0;

            double avg = 0;
            foreach (double i in data)
            {
                avg += i;
            }
            avg = avg / data.Count;
            return avg;
        }
    }
    internal class StandardDeviationCalculator : IMeanCalculator
    {
        public double CalculateMean(List<double> data)
        {
            if (data.Count == 0)
                return 0;

            double sumOfSqrs = 0;
            double meanValue = 0;
            double dev = 0;
            foreach (double value in data)
            {
                meanValue += value;
            }
            meanValue = (meanValue / data.Count);

            for (int i = 0; i < data.Count; i++)
            {
                sumOfSqrs += Math.Pow((data[i] - meanValue), 2);
            }
            dev = sumOfSqrs / (data.Count - 1);
            return dev;
        }
    }
}
