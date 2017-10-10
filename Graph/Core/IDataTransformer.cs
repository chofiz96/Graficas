using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IDataTransformer
    {
        List<double> TransformData(List<double> data);
    }
    internal class SortTransformer : IDataTransformer
    {
        public List<double> TransformData(List<double> data)
        {
            data.Sort();
            return data;
        }
    }
    internal class RootTransformer : IDataTransformer
    {
        public List<double> TransformData(List<double> data)
        {
            for(int i = 0; i<data.Count; i++)
            {
                data[i] = Math.Sqrt(data[i]);
            }
            return data;
        }
    }
    internal class LogTransformer : IDataTransformer
    {
        public List<double> TransformData(List<double> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] != 0)
                {
                    data[i] = Math.Log(data[i]);
                }
            }
            return data;
        }
    }
}
