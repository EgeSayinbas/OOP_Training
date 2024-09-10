using _10_PolimorfizmWindow.CepTelefonlari;

namespace _10_PolimorfizmWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia();
            nokia.CallSound();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IPhone phone = new IPhone();
            phone.CallSound();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();
            samsung.CallSound();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BasePhone phone = new BasePhone();  
            phone.CallSound();
        }
    }
}
