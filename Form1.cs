namespace Shiw_number_array
{
    public partial class Form1 : Form
    {
        int[] nums;
        int current_index;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nums = new int[10];
            current_index = 0;
        }

        private void add_butt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt1.Text == "" || txt1.Text == String.Empty)
                {
                    MessageBox.Show("U Idiots Enter Your Number!!!");
                }
                else
                {
                    int num;
                    if (current_index == 10)
                    {
                        MessageBox.Show("You have filled the array!! Press Caculate");
                        return;
                    }
                    num = Convert.ToInt32(txt1.Text);
                    nums[current_index] = num;
                    current_index++;
                    out_lab.Text = $"Your numer is {num} and  there is {current_index} numbres";
                    txt1.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Only Numbers dude");
                txt1.Text = "";
            }

        }

        private void cacu_butt_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }
            MessageBox.Show($"Average is {total / current_index}");
        }

        private void reset_butt_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < nums.Length;i++)
            {
                nums[i] = 0;
            }
            current_index = 0;
            out_lab.Text = "You have been reset.";
        }
    }
}
