
using Sunny.UI;

namespace opencvNode
{
    public partial class Form1 : UIForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.uiLabel2.Text = System.DateTime.Now.ToString("t");
            if (!ExistPage(1002))
            {
                AddPage(new Form2());
            }

            SelectPage(1002);
        }

        private void uiButton1_Click(object sender, System.EventArgs e)
        {
            if (!ExistPage(1003))
            {
                AddPage(new Form3());
            }

            SelectPage(1003);
        }

        private void timeget(object sender, System.EventArgs e)
        {
            this.uiLabel2.Text = System.DateTime.Now.ToString("t");
        }

        private void uiButton2_Click(object sender, System.EventArgs e)
        {
            if (!ExistPage(1002))
            {
                AddPage(new Form2());
            }

            SelectPage(1002);
        }
    }
}
