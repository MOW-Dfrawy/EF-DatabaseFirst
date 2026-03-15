using EF_D1.Models;

namespace EF_D1
{
    public partial class Form1 : Form
    {
        ITIContext db;
        int id;
        private NotifyIcon notify;
        public Form1()
        {
            InitializeComponent();
            db = new ITIContext();
            notify = new NotifyIcon();
            notify.Icon = SystemIcons.Information;
            notify.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            dgv_course.DataSource = db.Courses.Select(c => new { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Top.Top_Name }).ToList();
            dgv_course.Columns["Crs_Id"].Visible = false;

            cb_topics.DataSource = db.Topics.ToList();
            cb_topics.ValueMember = "Top_Id";
            cb_topics.DisplayMember = "Top_Name";

            Showbtn(true);



        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Course course = new Course()
            {
   
                Crs_Name = txt_name.Text,
                Crs_Duration = int.Parse(txt_Duration.Text),
                Top_Id = (int)cb_topics.SelectedValue


            };

            db.Courses.Add(course);
            db.SaveChanges();

            dgv_course.DataSource = db.Courses.Select(c => new { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Top.Top_Name }).ToList();
             txt_name.Text = txt_Duration.Text = string.Empty;

            notify.BalloonTipTitle = "Success";
            notify.BalloonTipText = $"add!";
            notify.ShowBalloonTip(1000);
        }
        private void dgv_course_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_course.SelectedRows[0].Cells["Crs_Id"].Value;

            Course course = db.Courses.Find(id);
  
            txt_name.Text = course.Crs_Name;
            txt_Duration.Text = course.Crs_Duration.ToString();
            cb_topics.SelectedValue = course.Top_Id;

            Showbtn(false);
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            Course course = db.Courses.Find(id);
        
            course.Crs_Name = txt_name.Text;
            course.Crs_Duration = int.Parse(txt_Duration.Text);
            course.Top_Id = (int)cb_topics.SelectedValue;

            db.SaveChanges();

            dgv_course.DataSource = db.Courses.Select(c => new { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Top.Top_Name }).ToList();
             txt_name.Text = txt_Duration.Text = string.Empty;

            notify.BalloonTipTitle = "Success";
            notify.BalloonTipText = $"Updated!";
            notify.ShowBalloonTip(1000);
            Showbtn(true);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Course course = db.Courses.Find(id);
                db.Courses.Remove(course);
                db.SaveChanges();

                dgv_course.DataSource = db.Courses.Select(c => new { c.Crs_Id, c.Crs_Name, c.Crs_Duration, c.Top.Top_Name }).ToList();
               txt_name.Text = txt_Duration.Text = string.Empty;

                notify.BalloonTipTitle = "Success";
                notify.BalloonTipText = $"Deleted!";
                notify.ShowBalloonTip(1000);

                Showbtn(true);

            }
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        void Showbtn(bool v)
        {
            btn_add.Visible = v;
            btn_delete.Visible = !v;
            btn_update.Visible = !v;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
         


        }

    }
}
