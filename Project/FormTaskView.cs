using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Project
{
    public class FormTaskView : FormAddView
    {
        public int taskIndex;
        public Task task;
        public bool TaskChanged = false;

        
        public FormTaskView(int index)
        {
            //          Debug.Print(index.ToString());
            System.ComponentModel.ComponentResourceManager resources =
              new System.ComponentModel.ComponentResourceManager(typeof(FormTaskView));
            this.taskIndex = index;
            this.task = Model.TaskList[taskIndex];
            //            Debug.Print(task.Name);
            
            this.NameBox.Text = task.Name;
            this.PlaceBox.Text = task.Place;
            this.TimeBox.Value = task.Time;
            this.DateTimeBox.Value = task.Date;

            this.KeyDown -= FormAddView_KeyDown;
            this.AddButton.Click -= AddButton_Click;
            
            this.AddButton.Click += ChangeButton_Click;
            this.RemoveButton.Click += RemoveButton_Click;
            this.KeyDown += FormTaskView_KeyDown;

            this.RemoveButton.Visible = true;
            this.Text = "Змінити завдання";
            this.Load += FormTask_Load;

        }

        private void FormTaskView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Debug.Print("change");
                ChangeButton_Click(sender, e);
            }
        }


        public void ChangeButton_Click(object sender, EventArgs e)
        {

            if (NameBox.Text == "" || PlaceBox.Text == "")
            {
                MessageBox.Show("Додайте текст завдання та місця проведення", "Помилка!");
            }
            else
            {
                bool change = true;

                DateTime NewTimeBefore = DateTimeBox.Value;

                DateTime NewTimeAfter = NewTimeBefore.AddHours(TimeBox.Value.Hour).AddMinutes(TimeBox.Value.Minute).AddSeconds(TimeBox.Value.Second);
                foreach (Task item in Model.TaskList)
                {
                    if(item != task)
					{
                        DateTime TimeBefore = item.Date;

                        DateTime TimeAfter = TimeBefore.AddHours(item.Time.Hour).AddMinutes(item.Time.Minute).AddSeconds(item.Time.Second);



                        if ((DateTime.Compare(NewTimeBefore, TimeBefore) <= 0 && DateTime.Compare(TimeBefore, NewTimeAfter) <= 0) || (DateTime.Compare(NewTimeBefore, TimeAfter) <= 0 && DateTime.Compare(TimeAfter, NewTimeAfter) <= 0) || (DateTime.Compare(NewTimeBefore, TimeBefore) >= 0 && DateTime.Compare(TimeAfter, NewTimeBefore) >= 0))
                        {
                            MessageBox.Show($"Подія перетинається з цією подією \n{item.Name}", "Помилка при редактуванні!");
                            change = false;
                            break;
                        }
                    }
                    

                }

                if (change)
                {
                    Debug.Print("changed");
                    Model.TaskList[taskIndex].Name = NameBox.Text;
                    Model.TaskList[taskIndex].Date = DateTimeBox.Value;
                    Model.TaskList[taskIndex].Time = TimeBox.Value;
                    Model.TaskList[taskIndex].Complete = CompleteBox.Checked;
                    Model.TaskList[taskIndex].Group = (string)GroupsListBox.SelectedItem;
                    Model.TaskList[taskIndex].Place = PlaceBox.Text;

                    TaskChanged = true;
                    this.Close();
                }


                
            }
        }

        private void FormTask_Load(object sender, EventArgs e)
        {

            GroupsListBox.SelectedItem = task.Group;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете видалити завдання?", "Увага!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                TaskChanged = true;
                Model.TaskList.RemoveAt(taskIndex);
                this.Close();
            }
        }
    }
}
