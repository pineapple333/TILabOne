using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace TeamInternationalFirst.Writers
{
    class JSONFileWriter : IWriter
    {
        public void OnGameFinished(object source, GameFinishedEventArgs gameFinishedEventArgs)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(gameFinishedEventArgs, options);
            File.WriteAllText("local_json_file.json", jsonString);
        }
    }
}
