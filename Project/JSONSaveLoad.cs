using System;
using System.IO;
using Newtonsoft.Json;
using System.Threading;
class JSONSaveLoad
{
    public static void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false) where T: new()
    {
        string directory = Path.GetDirectoryName(filePath);
        if(!Directory.Exists(directory))
            Directory.CreateDirectory(directory);
        
        FileInfo file = new FileInfo(filePath);
        TextWriter writer = null;
        var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
        writer = new StreamWriter(filePath, append);
        writer.Write(contentsToWriteToFile);
        writer.Close();
    }


    public static T ReadFromJsonFile<T>(string filePath) where T:new()
    { 
        FileInfo file = new FileInfo(filePath);
        TextReader reader = null;
        reader = new StreamReader(filePath);
        var fileContents = reader.ReadToEnd();
        reader.Close();
        return JsonConvert.DeserializeObject<T>(fileContents);
    }
}