using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Project
{
    public partial class FormAddView : Form
    {
        public bool AddedTask = false;
        public FormAddView()
        {
            InitializeComponent();

        }

        public void FormAdd_Load(object sender, EventArgs e)
        {
            foreach(string item in FormView.combo.Items)
            {
                if (item != "Завершені")
                    GroupsListBox.Items.Add(item);
                Debug.Print(item);
            }
			
            GroupsListBox.SelectedIndex = 0;
            
        }

		public void FormAddView_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
			{
                this.Close();
			}
            else if(e.KeyCode == Keys.Enter)
            {
                Debug.Print("add");
                AddButton_Click(sender, e);
			}
		}

		public void AddButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || PlaceBox.Text == "")
            {
                MessageBox.Show("Додайте текст завдання та місця проведення", "Помилка!");
            }
            else
            {
                bool create = true;

                DateTime NewTimeBefore = DateTimeBox.Value;

                DateTime NewTimeAfter = NewTimeBefore.AddHours(TimeBox.Value.Hour).AddMinutes(TimeBox.Value.Minute).AddSeconds(TimeBox.Value.Second);
                foreach (Task item in Model.TaskList)
                {
                    DateTime TimeBefore = item.Date;

                    DateTime TimeAfter = TimeBefore.AddHours(item.Time.Hour).AddMinutes(item.Time.Minute).AddSeconds(item.Time.Second);



                    if ((DateTime.Compare(NewTimeBefore, TimeBefore) <= 0 && DateTime.Compare(TimeBefore, NewTimeAfter) <= 0) || (DateTime.Compare(NewTimeBefore, TimeAfter) <= 0 && DateTime.Compare(TimeAfter, NewTimeAfter) <= 0) || (DateTime.Compare(NewTimeBefore, TimeBefore) >= 0 && DateTime.Compare(TimeAfter, NewTimeBefore) >= 0))
                    {
                        MessageBox.Show($"Подія перетинається з цією подією \n{item.Name}", "Помилка при створенні!");
                        create = false;
                        break;
                    }

                }
                if (create)
                {
                    Model.TaskList.Add(new Task(NameBox.Text, DateTimeBox.Value, TimeBox.Value, CompleteBox.Checked, (string)GroupsListBox.SelectedItem, PlaceBox.Text));
                    AddedTask = true;
                    this.Close();
                }

            }
        }

        public void AddGroup_Click(object sender, EventArgs e)
        {

            Debug.Print("q");
            FormAddGroup form = new FormAddGroup();
            form.FormClosing += AddGroupForm_FormClosing;
            form.ShowDialog();
            
        }

        public void AddGroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if((sender as FormAddGroup).GroupAdded)
            {
                
                GroupsListBox.Items.Add((sender as FormAddGroup).GroupBox.Text);
                GroupsListBox.SelectedIndex=this.GroupsListBox.Items.Count - 1;
                (sender as FormAddGroup).GroupAdded = false;

            }
            
        }
        
    }
}
