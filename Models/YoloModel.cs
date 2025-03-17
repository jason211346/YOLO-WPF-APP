using System;
using System.IO;

namespace ObjectDetectionApp.Models
{
    public class YoloModel
    {
        public string Name { get; }
        public string FilePath { get; }
        public string DisplayName { get; }
        
        public YoloModel(string name, string filePath)
        {
            Name = name;
            FilePath = filePath;
            DisplayName = Path.GetFileNameWithoutExtension(name);
        }
        
        public override string ToString()
        {
            return DisplayName;
        }
    }
}
