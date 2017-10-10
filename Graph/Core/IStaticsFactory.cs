using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IStaticsFactory
    {
        IDataTransformer GetDataTransformer();
        IMeanCalculator GetMeanCalculator();
    }
    public class AverageSortFactory : IStaticsFactory
    {
        public IDataTransformer GetDataTransformer()
        {
            return new SortTransformer();
        }
        public IMeanCalculator GetMeanCalculator()
        {
            return new AverageCalculator();
        }
        public override string ToString()
        {
            return "Average-Sort Factory";
        }
    }
    public class StandardRootFactory : IStaticsFactory
    {
        public IDataTransformer GetDataTransformer()
        {
            return new RootTransformer();
        }
        public IMeanCalculator GetMeanCalculator()
        {
            return new StandardDeviationCalculator();
        }
        public override string ToString()
        {
            return "Standard-Root Factory";
        }
    }
    public class AverageRootFactory : IStaticsFactory
    {
        public IDataTransformer GetDataTransformer()
        {
            return new RootTransformer();
        }
        public IMeanCalculator GetMeanCalculator()
        {
            return new AverageCalculator();
        }
        public override string ToString()
        {
            return "Average-Root Factory";
        }
    }
    public class StandardSortFactory : IStaticsFactory
    {
        public IDataTransformer GetDataTransformer()
        {
            return new SortTransformer();
        }
        public IMeanCalculator GetMeanCalculator()
        {
            return new StandardDeviationCalculator();
        }
        public override string ToString()
        {
            return "Standard-Sort Factory";
        }
    }
    public class AverageLogFactory : IStaticsFactory
    {
        public IDataTransformer GetDataTransformer()
        {
            return new LogTransformer();
        }
        public IMeanCalculator GetMeanCalculator()
        {
            return new AverageCalculator();
        }
        public override string ToString()
        {
            return "Averag-Log Factory";
        }
    }
}
