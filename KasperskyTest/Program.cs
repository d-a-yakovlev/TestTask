using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperskyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryFileProcessor[] factories =
            {
                new FactoryFileProcessorHTML(), 
                new FactoryFileProcessorText(),
                new FactoryFileProcessorJSON()
            };
            Dictionary<string, int> fileTypes = new Dictionary<string, int>
            {
                ["HTML"]= 0,
                ["Text"]= 1,
                ["JSON"]= 2
            };

            Console.WriteLine("Введите название файла");
            string fileName = Console.ReadLine();

            Console.WriteLine("Введите тип файла: HTML, Text, JSON");
            string fileType = Console.ReadLine();

            var factory = factories[fileTypes[fileType]];

            var fileProcessor = factory.GetFileProcessor();

            fileProcessor.ProcessFile(fileName);

            Console.ReadKey();
        }
    }

    public class FileProcessor
    {
        public string type { protected set; get; }

        public virtual void ProcessFile(string fileName){ }
    }

    public class FileProcessorHTML : FileProcessor
    {
        public FileProcessorHTML()
        {
            type = "HTML";
        }

        public override void ProcessFile(string fileName)
        {
            Console.WriteLine($"File {fileName} processed as HTML");
        }
    }

    public class FileProcessorText : FileProcessor
    {
        public FileProcessorText()
        {
            type = "Text";
        }

        public override void ProcessFile(string fileName)
        {
            Console.WriteLine($"File {fileName} processed as Text");
        }
    }

    public class FileProcessorJSON : FileProcessor
    {
        public FileProcessorJSON()
        {
            type = "JSON";
        }

        public override void ProcessFile(string fileName)
        {
            Console.WriteLine($"File {fileName} processed as JSON");
        }
    }

    public abstract class FactoryFileProcessor
    {
        public virtual FileProcessor GetFileProcessor()
        {
            return new FileProcessor();
        }
    }

    public class FactoryFileProcessorHTML : FactoryFileProcessor
    {
        public override FileProcessor GetFileProcessor()
        {
            return new FileProcessorHTML();
        }
    }

    public class FactoryFileProcessorText : FactoryFileProcessor
    {
        public override FileProcessor GetFileProcessor()
        {
            return new FileProcessorText();
        }
    }

    public class FactoryFileProcessorJSON : FactoryFileProcessor
    {
        public override FileProcessor GetFileProcessor()
        {
            return new FileProcessorJSON();
        }
    }
}
