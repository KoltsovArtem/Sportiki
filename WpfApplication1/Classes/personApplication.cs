using CsvHelper.Configuration.Attributes;

namespace WpfApplication1.Classes
{
    public class personApplication
    {
        [Name("Номер")]
        public string id{get; set; }
        [Name("Группа")]
        public string Group{get; set; }
        [Name("Фамилия")]
        public string Surname{get; set; }
        [Name("Имя")]
        public string Name{get; set; }
        [Name("Г.р.")]
        public string YOB { get; set; }
        [Name("Разр.")]
        public string Category{get; set; }
        public string Team{get; set; }


    }
}