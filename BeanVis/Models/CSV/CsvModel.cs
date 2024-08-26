namespace BeanVis.Models.CSV
{
    public class CsvModel
    {
        public string FilePath { get; private set; }

        public CsvModel(string filePath)
        {
            FilePath = filePath;
        }
    }
}
