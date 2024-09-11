namespace _22_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            listBox1.Items.Add("Listbox1 Mouse Enter");
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            listBox1.Items.Add("Listbox1 Mouse Hover");
        }
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("Listbox1 Mouse Down");
        }
        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("Listbox1 Mouse Up");
        }
        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //listBox1.Items.Add($"Listbox1 Mouse Move X:{e.X.ToString()}" +
               // $"Listbox1 Mouse Move Y: {e.Y.ToString()}" );
        }

        
    }
}
