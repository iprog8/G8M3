using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BazaDate
{
    public class Database
    {
        private static ILog log;
        static ILog Log
        {
            get
            {
                if (log == null)
                {
                    log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                }
                return log;
            }
        }

        public Database(string file)
        {
            ConnectionString = file;
        }

        public string ConnectionString { get; internal set; }

        public static T LoadData<T>(string file) where T : Database, new()
        {
            string fileData = null;
            if (File.Exists(file))
            {
                fileData = File.ReadAllText(file);
            }
            if (fileData != null)
            {
                Log.Info($"LoadData: Baza de date a fost incarcata.");
                return JsonConvert.DeserializeObject<T>(fileData);
            }
            else
            {
                Log.Info($"LoadData: Baza de date a fost Creata.");
                return new T();
            }
        }

        public void SaveData()
        {
            var serializerSettings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string fileData = JsonConvert.SerializeObject(this, serializerSettings);
            File.WriteAllText(ConnectionString, fileData);
            Log.Info($"SaveData: Baza de date a fost salvata in: {ConnectionString}.");
        }
    }
}
