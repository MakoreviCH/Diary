using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;


namespace Project
{
    public static class Model
    {
        public static FormView MainForm;
        public static List<Task> TaskList = new List<Task>();
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new FormView();
            Application.Run(MainForm);

        }

        public static string GetText(int index)
        {
            string result = "";
            switch (index)
            {

                case 0:
                    {
                        result = "Сьогодні";

                    }
                    break;
                case 1:
                    {
                        result = "Завтра";
                    }
                    break;
                case 2:
                    {
                        result = "Цього тижня";
                    }
                    break;
                case 3:
                    {
                        result = "Наступного тижня";
                    }
                    break;
                case 4:
                    {
                        result = "Цього місяця";
                    }
                    break;
                case 5:
                    {
                        result = "Наступного місяця";
                    }
                    break;
                case 6:
                    {
                        result = "Пізніше";

                    }
                    break;
                case 7:
                    {
                        result = "Прострочені";

                    }
                    break;

            }
            return result;
        }

        

        public static DateTime GetDate(string value)
        {
            string[] date = value.Split(' ')[0].Split('.');
            string[] time = value.Split(' ')[1].Split(':');

            int day = Convert.ToInt32(date[0]);
            int month = Convert.ToInt32(date[1]);
            int year = Convert.ToInt32(date[2]);

            int hour = Convert.ToInt32(time[0]);
            int minutes = Convert.ToInt32(time[1]);
            int seconds = Convert.ToInt32(time[2]);

            return new DateTime(year, month, day, hour, minutes, seconds);
            
        }
        public static DateTime GetTime(string value)
        {
            string[] time = value.Split(':');

            int hour = Convert.ToInt32(time[0]);
            int minutes = Convert.ToInt32(time[1]);
            int seconds = Convert.ToInt32(time[2]);
            return new DateTime(1970,1,1,hour,minutes, seconds);
        }
        public static List<string> GetGroups()
        {
            List<string> groups = new List<string>();
            groups.Add("Всі списки");
            foreach (Task item in TaskList)
            {
                if(!groups.Contains(item.Group))
                {
                    groups.Add(item.Group);
                }
            }
            return groups;
        }

        public static void ShowTaskList(string group)
        {
            int index = 0;
            int count = 0;
            Model.TaskList.Sort(new TaskComparer());
            bool[] groups = new bool[8];
            for (int i = 0; i < 8; i++)
            {
                groups[i] = false;
            }

            foreach (Task item in Model.TaskList)
            {

                if (group == "Всі списки" || item.Group == group)
                {

                    DateTime time = DateTime.Now;
                    if (DateTime.Compare(item.Date, time) < 0)
                    {
                        if (!groups[7])
                        {
                            MainForm.CreateDateLabel(7);
                            groups[7] = true;
                        }
                        Debug.Print($"INIT {item.Name} 0");
                        MainForm.CreateTaskButton(item, count, index, CountTrue(groups));
                        count++;
                        index++;
                        continue;
                    }
                    time = time.AddDays(1);
                    if (DateTime.Compare(item.Date, time) < 0)
                    {
                        if (!groups[0])
                        {
                            MainForm.CreateDateLabel(0);
                            groups[0] = true;

                        }
                        Debug.Print($"INIT {item.Name} 0");
                        MainForm.CreateTaskButton(item, count, index, CountTrue(groups));
                        count++;
                        index++;
                        continue;
                    }
                    time = time.AddDays(1);
                    if (DateTime.Compare(item.Date, time) < 0)
                    {
                        if (!groups[1])
                        {
                            MainForm.CreateDateLabel(1);
                            groups[1] = true;

                        }
                        MainForm.CreateTaskButton(item, count, index, CountTrue(groups));
                        count++;
                        index++;
                        Debug.Print($"INIT {item.Name} 1");
                        continue;
                    }
                    if (GetDaysWeek(time) != 0 && GetDaysWeek(time) != 1)
                    {
                        time = time.AddDays(GetDaysWeek(time) + 1);
                        if (DateTime.Compare(item.Date, time) < 0)
                        {
                            if (!groups[2])
                            {
                                MainForm.CreateDateLabel(2);
                                groups[2] = true;

                            }
                            MainForm.CreateTaskButton(item, count, index, CountTrue(groups));
                            Debug.Print($"INIT {item.Name} 2");
                            count++;
                            index++;
                            continue;

                        }
                    }
                    time = time.AddDays(7);
                    if (DateTime.Compare(item.Date, time) < 0)
                    {
                        if (!groups[3])
                        {
                            MainForm.CreateDateLabel(3);
                            groups[3] = true;

                        }
                        MainForm.CreateTaskButton(item, count, index, CountTrue(groups));
                        count++;
                        index++;
                        Debug.Print($"INIT {item.Name} 3");
                        continue;
                    }
                    time = DateTime.Today;
                    time = time.AddDays(DateTime.DaysInMonth(time.Year, time.Month) - time.Day + 1);
                    if (DateTime.Compare(item.Date, time) < 0)
                    {
                        if (!groups[4])
                        {
                            MainForm.CreateDateLabel(4);
                            groups[4] = true;

                        }
                        Debug.Print($"INIT {item.Name} 4");
                        MainForm.CreateTaskButton(item, count, index, CountTrue(groups));
                        count++;
                        index++;
                        continue;
                    }
                    time = time.AddDays(DateTime.DaysInMonth((time.Month + 1 == 13) ? time.Year + 1 : time.Year, (time.Month + 1 == 13) ? 1 : time.Month));
                    if (DateTime.Compare(item.Date, time) < 0)
                    {
                        if (!groups[5])
                        {
                            MainForm.CreateDateLabel(5);
                            groups[5] = true;

                        }
                        Debug.Print($"INIT {item.Name} 5");
                        MainForm.CreateTaskButton(item, count, index, CountTrue(groups));
                        count++;
                        index++;
                        continue;
                    }
                    else
                    {
                        if (!groups[6])
                        {
                            MainForm.CreateDateLabel(6);
                            groups[6] = true;

                        }
                        Debug.Print($"INIT {item.Name} 6");
                        MainForm.CreateTaskButton(item, count, index, CountTrue(groups));
                        count++;
                        index++;
                    }
                }
                else if (group == "Завершені")
                {
                    if (item.Complete == true)
                    {
                        MainForm.CreateTaskButton(item, count, index, 0);
                        count++;
                        index++;
                    }
                    continue;
                }


            }
        }
        public static int CountTrue(bool[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == true) result++;
            }
            return result;
        }
        public static int GetDaysWeek(DateTime col)
        {
            switch (col.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return 0;
                case DayOfWeek.Monday:
                    return 6;
                case DayOfWeek.Tuesday:
                    return 5;
                case DayOfWeek.Wednesday:
                    return 4;
                case DayOfWeek.Thursday:
                    return 3;
                case DayOfWeek.Friday:
                    return 2;
                case DayOfWeek.Saturday:
                    return 1;
                default:
                    return 0;
            }


        }
        internal static void Timer_Tick(object sender, EventArgs e)
        {
            foreach (Task item in Model.TaskList)
            {
                DateTime now = DateTime.Now.AddHours(3);
                bool isNow = now.Hour == item.Date.Hour && now.Minute == item.Date.Minute && now.Second == item.Date.Second;

                if (isNow && !item.Complete)
                {
                    MainForm.ShowNote(item);    
                }   
            }

        }
    }
}
