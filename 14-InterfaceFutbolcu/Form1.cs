using _14_InterfaceFutbolcu.Abstract;
using _14_InterfaceFutbolcu.Concrete;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Windows.Forms;

namespace _14_InterfaceFutbolcu
{
    public partial class Form1 : Form
    {
        Takim Takim { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kaleci kaleci = new Kaleci()
            {
                AdiSoyadi = "Muslera ",
                Agresiflik = 80,
                Dayaniklilik = 80,
                DogumTarigi = new DateTime(1986, 6, 16),
                Mevki = Abstract.Mevki.Kaleci,
                Milllimi = true,
                Hiz = 80,
                SutGucu = 80

            };
            Defans defans = new Defans()
            {
                AdiSoyadi = "Kazma Recep",
                Agresiflik = 80,
                Dayaniklilik = 80,
                DogumTarigi = new DateTime(1988, 9, 16),
                Mevki = Abstract.Mevki.Defans,
                Milllimi = true,
                Hiz = 80,
                SutGucu = 80
            };
            OrtaSaha ortaSaha = new OrtaSaha()
            {
                AdiSoyadi = "Sergen Yalcin ",
                Agresiflik = 80,
                Dayaniklilik = 80,
                DogumTarigi = new DateTime(1987, 6, 16),
                Mevki = Abstract.Mevki.Kaleci,
                Milllimi = true,
                Hiz = 80,
                SutGucu = 80
            };
            Forvet forvet = new Forvet()
            {
                AdiSoyadi = "Cenk Tosun",
                Agresiflik = 80,
                Dayaniklilik = 80,
                DogumTarigi = new DateTime(1986, 6, 16),
                Mevki = Abstract.Mevki.Kaleci,
                Milllimi = true,
                Hiz = 80,
                SutGucu = 80
            };

            List<BaseFutbolcu> baseFutbolcus = new List<BaseFutbolcu>();
            baseFutbolcus.Add(forvet);
            baseFutbolcus.Add(ortaSaha);
            baseFutbolcus.Add(defans);
            baseFutbolcus.Add(kaleci);
            Takim = new Takim(baseFutbolcus);

            foreach (var futbolcu in baseFutbolcus)
            {
                listBox1.Items.Add(futbolcu);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            BaseFutbolcu gelenFutbolcu =listBox1.SelectedItem as BaseFutbolcu;
            var gelenPropertyler = gelenFutbolcu.GetType().GetProperties();
            foreach (var property in gelenPropertyler)
            {
                Label lbl = new Label();
                lbl.AutoSize = false;
                lbl.Width = flowLayoutPanel1.Width;
                lbl.Text = property.Name + ":"+ property.GetValue(gelenFutbolcu);
                flowLayoutPanel1.Controls.Add(lbl);
                //panel1.Controls.Add(lbl);
            }
            Label lbl2 = new Label();
            lbl2.AutoSize = false;
            lbl2.Width = flowLayoutPanel1.Width;
            lbl2.Text = "***********Bu Futbolcunun Yetenekleri ****************";
            flowLayoutPanel1.Controls.Add(lbl2);
            IFutbolcu gelenYetenekler = listBox1.SelectedItem as IFutbolcu;
            foreach (var metod in gelenYetenekler.GetType().GetMethods())
            {
               
                if (!metod.Name.Contains("get") && 
                    !metod.Name.Contains("set")&& 
                    !metod.Name.Contains("ToString")&& 
                    !metod.Name.Contains("Equals") &&
                    !metod.Name.Contains("GetHashCode") &&
                    !metod.Name.Contains("GetType"))
                {
                Label lbl = new Label();
                lbl.AutoSize = false;
                lbl.Width = flowLayoutPanel1.Width;
                lbl.Text = metod.Name ;
                flowLayoutPanel1.Controls.Add(lbl);
                }
               
            }
            //listBox2.Items.Add(listBox1.SelectedItem.ToString());
        }
    }
}
