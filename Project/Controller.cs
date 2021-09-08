using System;
using System.IO;
using System.Diagnostics;

namespace Project
{
    class Controller
    {
        private const string path = @"data.txt";
        
        public static void GetData()
        {


            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] properties = line.Split(';');

                        string name = properties[0];

                        DateTime data = Model.GetDate(properties[1]);
                        DateTime time = Model.GetTime(properties[2]);
                        bool complete = Convert.ToBoolean(properties[3]);

                        string group = (properties[4] == "") ? "Всі списки" : properties[4];
                        string place = properties[5];
                        Model.TaskList.Add(new Task(name, data, time, complete, group, place));
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {

                File.Create(@"data.txt");

            }

        }

        public static void SaveData()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    foreach (Task item in Model.TaskList)
                    {

                        string name = item.Name;
                        string date = item.Date.ToString("G");
                        string time = item.Time.ToString("T");
                        string complete = Convert.ToString(item.Complete);
                        string group = item.Group;
                        string place = item.Place;
                        Debug.Print(name + ";" + date + ";" + time + ";" + complete + ";" + group);
                        sw.WriteLine(name + ";" + date + ";" + time + ";" + complete + ";" + group + ";" + place);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
