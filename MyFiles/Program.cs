using System;
using System.IO;
namespace MyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullFilePath = @"C:\Users\opilane\Samples\TITpe21";
            string filePath = fullFilePath + @"\MyFiles.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            for (int i = 0; i < dataFromFile.Length; i++)
            {
                dataFromFile[i] = dataFromFile[i].Replace('4', 'a');
                dataFromFile[i] = dataFromFile[i].Replace('3', 'e');
                dataFromFile[i] = dataFromFile[i].Replace('0', 'o');
                dataFromFile[i] = dataFromFile[i].Replace('1', 'i');

                File.WriteAllLines(filePath, dataFromFile);
            }
            foreach (string line in dataFromFile)
            {
                File.Create($@"{fullFilePath}\{line}.txt");
            }
        }
    }
}
