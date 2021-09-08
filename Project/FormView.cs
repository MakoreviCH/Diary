using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;


namespace Project
{
    public partial class FormView : Form
    {
        
        public static ComboBox combo = new ComboBox();
        bool AT = false;
        bool CT = false;
        List<Button> tasksButton = new List<Button>();
        List<Label> lableList = new List<Label>();
        public FormView()
        {
            InitializeComponent();

        }
        
        

        private void ClearView()
        {
            foreach  (Button item in tasksButton)
            {
                Controls.Remove(item);
            }
            tasksButton.Clear();
            foreach (Label item in lableList)
            {
                Controls.Remove(item);
            }
            lableList.Clear();
            
            
        }
        
        public void CreateTaskButton(Task value, int count, int index, int groupindex)
        {
            Button task = new Button();
            task.Name = ""+index;
            task.Location = new Point(10, count * 65 + 43 +( (groupindex!=0) ? groupindex * 16 + 5:0 ));
            task.Size = new Size(this.Size.Width-45,60);
            task.MouseHover += Task_MouseHover;
            task.MouseLeave += Task_MouseLeave;
            task.FlatStyle = FlatStyle.Flat;
            task.BackColor=Color.FromKnownColor(KnownColor.ControlLight);
            task.FlatAppearance.MouseOverBackColor = Color.FromArgb(204, 204, 204);
            task.Click += Task_Click;
        //    Debug.Print(value.Name);

            Label name = new Label();
            name.Parent = task;
            name.Text = value.Name;
            name.Font = new Font("Times New Roman", 11f);
            name.Height = 16;
            name.BackColor = Color.Transparent;
       //     Debug.Print(Convert.ToString(name.Height));
            name.Location = new Point(30, 5);
            name.MouseHover += TaskChild_MouseHover;
            name.MouseLeave += TaskChild_MouseLeave;

            Label info = new Label();
            info.Parent = task;
            info.Size = new Size(task.Size.Width - 25, 17);
            string hour=    (value.Time.Hour!=0)?$"{value.Time.Hour} г. ":"";
            string minutes = (value.Time.Minute != 0) ? $"{value.Time.Minute} хв. " : "";
            string seconds = (value.Time.Second != 0) ? $"{value.Time.Second} с. " : "";
            string time = hour + minutes + seconds;
            info.Text = value.Date.ToString("r") + ((time=="")?"":$"   тривалістю {time}");
            info.Location = new Point(30, (task.Height) / 2+10);
            info.Font = new Font("Times new roman", 9f);
             info.BackColor = Color.Transparent;
            info.MouseHover += TaskChild_MouseHover;
            


            Label place = new Label();
            place.Parent = task;
            place.Size = new Size(task.Size.Width - 25, 18);
            place.Text = value.Place;
            place.Font = new Font("Times new roman",9f);
            place.Location = new Point(30, (task.Height - name.Height) / 2);
            place.BackColor = Color.Transparent;
            place.MouseHover += TaskChild_MouseHover;


            using (Graphics g = CreateGraphics())
            {
                SizeF sz = g.MeasureString(name.Text, name.Font);
                name.Width = (int)Math.Ceiling(sz.Width)+5;
              // name.Height= (int)Math.Ceiling(sz.Height);
                sz = g.MeasureString(info.Text, info.Font);
                info.Width = (int)Math.Ceiling(sz.Width);
                info.Height = (int)Math.Ceiling(sz.Height);
                sz = g.MeasureString(place.Text, place.Font);
                place.Width = (int)Math.Ceiling(sz.Width)+5;
                place.Height = (int)Math.Ceiling(sz.Height);

            }


            CheckBox complete = new CheckBox();
            complete.Parent = task;
            complete.Width = 14;
            complete.Height = 14;
            complete.CheckedChanged += Complete_CheckedChanged;
            complete.Location = new Point(10, (task.Height - complete.Height) / 2);
            complete.Checked = value.Complete;
           // complete.MouseHover += Task_MouseHover;
            
            tasksButton.Add(task);
            
            Controls.Add(task);

        }
        

        
        public void CreateDateLabel(int index)
        {
            int lastlocation = (tasksButton.Count==0)? 43 : tasksButton[tasksButton.Count - 1].Location.Y+65;
            Label DateLabel = new Label();
            DateLabel.Font = new Font("Times New Roman", 11f);
            DateLabel.Height = 16;
            DateLabel.Location = new Point(20, lastlocation);
            DateLabel.Text = Model.GetText(index);
            using (Graphics g = CreateGraphics())
            {
                SizeF sz = g.MeasureString(DateLabel.Text, DateLabel.Font);
                DateLabel.Width = (int)Math.Ceiling(sz.Width) + 5;
            }
            lableList.Add(DateLabel);
            Controls.Add(DateLabel);
        }

        public void NotificationTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Model.Timer_Tick;
            timer.Start();
        }

        

        public void ShowNote(Task value)
        {

            Label note = new Label();
            note.Text = $"Нагадування! Через 3 години відбудеться\n{value.Name}";
            note.Font = new Font("Times New Roman", 11f);
            note.Height = 36;
            note.BackColor = Color.Gray;
            note.Location = new Point(10, this.Height - 85);
            note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));

            string more = "Нагадування! Через 3 години відбудеться ".Length > value.Name.Length ? "Нагадування! Через 3 години відбудеться " : value.Name;
            using (Graphics gr = CreateGraphics())
            {
                SizeF sz = gr.MeasureString(more, note.Font);
                note.Width = (int)Math.Ceiling(sz.Width) + 5;
            }

            Controls.Add(note);

            Timer timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += (sender, EventArgs) => { Controls.Remove(note); Debug.Print("delete"); timer.Dispose(); } ;
            timer.Start();
            
        }


        public void SetGroups()
        {
            combo.Items.Clear();
            foreach (string item in Model.GetGroups())
            {
                combo.Items.Add(item);
            }
            combo.Items.Add("Завершені");
            
            
        }

        public void CreateCombo()
        {
            combo.Location = new Point(10, 10);
            combo.Size = new Size(Size.Width - 45, combo.Height);
            combo.Font = new Font("Microsoft Sans Serif", 10);
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            SetGroups();
            combo.SelectedIndex = 0;
            combo.SelectedValueChanged += Combo_SelectedValueChanged;
            Controls.Add(combo);
        }

        private void FormView_SizeChanged(object sender, EventArgs e)
        {
            //  System.Diagnostics.Debug.WriteLine($"{combo.Size}");

            combo.Size = new Size(Size.Width - 45, combo.Height);
            foreach (Button item in tasksButton)
            {
                item.Size = new Size(Size.Width - 45, item.Height);
            }
        }
        private void Task_Click(object sender, EventArgs e)
        {
            FormTaskView form = new FormTaskView(Convert.ToInt32((sender as Button).Name));
            form.FormClosing += FormTask_FormClosing;
            form.ShowDialog();

        }

        private void FormTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.Print("FormTaskClosing");
            if ((sender as FormTaskView).TaskChanged)
            {
                CT = true;
                int last_item = combo.SelectedIndex;
                SetGroups();
                combo.SelectedIndex = last_item;
                ClearView();
                Model.ShowTaskList(combo.SelectedItem.ToString());
                CT = false;
                (sender as FormTaskView).TaskChanged = false;
            }
        }

        private void FormView_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F1)
			{
                System.Diagnostics.Process.Start("instruction.pdf");
            }
		}
        public void TaskChild_MouseHover(object sender, EventArgs e)
        {
            {

                Button task = ((sender as Label).Parent as Button);

                task.BackColor = Color.FromArgb(204, 204, 204);

            }
        }
        private void Task_MouseLeave(object sender, EventArgs e)
        {

            (sender as Button).BackColor = Color.FromKnownColor(KnownColor.ControlLight);

        }

        public void TaskChild_MouseLeave(object sender, EventArgs e)
        {
            {
                Button task = ((sender as Label).Parent as Button);
                task.BackColor = Color.FromKnownColor(KnownColor.ControlLight);

            }
        }

        private void Task_MouseHover(object sender, EventArgs e)
        {

            //Debug.Print((sender as Button).BackColor.ToString());
            //  (sender as Button).BackColor = Color.FromArgb(255,204, 204, 204);
            //   Debug.Print("Button come");
        }


        private void Complete_CheckedChanged(object sender, EventArgs e)
        {
            Model.TaskList[Convert.ToInt32((sender as CheckBox).Parent.Name)].Complete = (sender as CheckBox).Checked;
        }
        private void FormView_Load(object sender, EventArgs e)
        {
            Controller.GetData();
            CreateCombo();
            Model.ShowTaskList(combo.SelectedItem.ToString());
         
            this.SizeChanged += FormView_SizeChanged;
            NotificationTimer();
        }

        private void AddButton_MouseHover(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Transparent;
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!AT && !CT)
            {
                ClearView();
                Model.ShowTaskList((sender as ComboBox).SelectedItem.ToString());
            }
        }
        
        private void AddButton_Click(object sender, EventArgs e)
        {
            FormAddView AddForm = new FormAddView();
            AddForm.FormClosing += AddForm_FormClosing;
            AddForm.ShowDialog();
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.Print("AddFormClosing");

            if((sender as FormAddView).AddedTask)
            {
                AT = true;
                int last_item = combo.SelectedIndex;
                SetGroups();
                combo.SelectedIndex = last_item;
                ClearView();
                Model.ShowTaskList(combo.SelectedItem.ToString());
                AT = false;
                (sender as FormAddView).AddedTask = false;
            }
        }

        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.SaveData();
        }
    }
}
