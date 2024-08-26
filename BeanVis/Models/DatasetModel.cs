using Deedle;

namespace BeanVis.Models
{
    public class DatasetModel
    {
        public string Name { get; private set; }
        public Frame<int, string> DataFrame { get; private set; }

        public DatasetModel(string name, Frame<int, string> data)
        {
            Name = name;
            DataFrame = data;
        }
    }
}
