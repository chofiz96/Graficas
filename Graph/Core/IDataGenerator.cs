using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IDataGenerator
    {
        List<double> GenerateData();
    }
    public class RandomDataGenerator : IDataGenerator
    {
        public List<double> GenerateData()
        {
            List<double> data = new List<double>();
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                data.Add(rand.NextDouble() * 100);
            }
            return data;
        }
        public override string ToString()
        {
            return "Random Data Generator";
        }
    }
    public class PolynomicDataGenerator : IDataGenerator
    {
        public List<double> GenerateData()
        {
            List<double> data = new List<double>();
            for (int i = 0; i < 50; i++)
            {
                data.Add((0.00027 * i * i * i) + (0.01175 * i * i) - (0.1121 * i) + 36.41);
            }
            return data;
        }
        public override string ToString()
        {
            return "Polynomic Data Generator";
        }
    }
    public class UltimateDataGenerator : IDataGenerator
    {
        public List<double> GenerateData()
        {
            List<double> data = new List<double>();
            for (int i = -25; i < 25; i++)
            {
                data.Add((i * i * i));
            }
            return data;
        }
        public override string ToString()
        {
            return "Ultimate Data Generator";
        }
    }
}
