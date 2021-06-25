using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeOdevi
{
    public partial class Form1 : Form
    {
        Domates domates = new Domates();
        Salatalik salatalik = new Salatalik();
        Gazete gazete = new Gazete();
        Dergi dergi = new Dergi();
        Bardak bardak = new Bardak();
        CamSise camSise = new CamSise();
        KolaKutusu kola = new KolaKutusu();
        SalcaKutusu salca = new SalcaKutusu();
        CamAtik camAtik = new CamAtik();
        OrganikAtik organikAtik = new OrganikAtik();
        KagitAtik kagitAtik = new KagitAtik();
        MetalAtik metalAtik = new MetalAtik();

        private List<string> _metalAtik = new List<string>();
        private List<string> _camAtik = new List<string>();
        private List<string> _organikAtik = new List<string>();
        private List<string> _kagitAtik = new List<string>();
        
        int süre;
        int puan;
        //Picture boxa resim atamak için dosyaların isimlerini bu dizide tutuyoruz
        string[] resimler = {"domates","salatalik","kola","bardak","dergi","camsise","gazete", "salca" };
        public Form1()
        {
            InitializeComponent();
            _metalAtik.Add("kola");
            _metalAtik.Add("salca");
            _kagitAtik.Add("dergi");
            _kagitAtik.Add("gazete");
            _camAtik.Add("bardak");
            _camAtik.Add("camsise");
            _organikAtik.Add("domates");
            _organikAtik.Add("salatalik");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void yeniOyunButton_Click(object sender, EventArgs e)
        {
            organikAtikButton.Enabled = true;
            metalButton.Enabled = true;
            camButton.Enabled = true;
            kagıtButton.Enabled = true;
            organikAtıkBosaltButton.Enabled = true;
            metalBosaltButton.Enabled = true;
            kagitBosaltButton.Enabled = true;
            camBosaltButton.Enabled = true;
            yeniOyunButton.Enabled = false;
            puanLabel.Text = "0";
            puan = 0;
            ResimDegisti();
            süre = 60;
            timer1.Enabled = true;
        }
        //Atikların hacimine göre puanı arttırıyor ve puan labelına yazdırıyor
        public void PuanArttir(Atik atik)
        {
            puan += atik.Hacim;
            puanLabel.Text = puan.ToString();
        }
        //Picturebox a random resim atıyor
        public void ResimDegisti()
        {
            Random r = new Random();
            int rastgele = r.Next(0, resimler.Length);
            pictureBox1.ImageLocation = resimler[rastgele] + ".png";
        }
        private void OrganikAtikButton_Click(object sender, EventArgs e)
        {
            //Pictureboxdan resmin ismini çekiyor,"png"kısmını substring ile kesiyoruz,listbox ta aratıyoruz
            var arananAtik = pictureBox1.ImageLocation.ToString();
            arananAtik = arananAtik.Substring(0, arananAtik.Length - 4);
            var siraNo = _organikAtik.IndexOf(arananAtik);
            //Resim eğer listede var ise siraNo değişkenine resmin oldugu indexi atıyor yok ise -1 atanıyor
            if (siraNo > -1 )
            {
                //Aranan atik listedeki hangi atığın olduğunu sorguluyor ve yeterli hacim var mı diye sorgulanıyor
                if (arananAtik == domates.Ad && organikAtik.Ekle(domates))
                {
                    //Listbox a yazdırma,resim değiştirme,puanı güncelleme,dolu hacmi güncelle,progress barı ilerletme işlemleri yapılıyor
                    organikAtikListBox.Items.Add(domates.ToString());
                    ResimDegisti();
                    PuanArttir(domates);
                    organikAtik.DoluHacim += domates.Hacim;
                    organikAtikBar.Value = Convert.ToInt32(organikAtik.DolulukOrani);
                }
                else if (arananAtik == salatalik.Ad && organikAtik.Ekle(salatalik))
                {
                    organikAtikListBox.Items.Add(salatalik.ToString());
                    ResimDegisti();
                    PuanArttir(salatalik);
                    organikAtik.DoluHacim += salatalik.Hacim;
                    organikAtikBar.Value = Convert.ToInt32(organikAtik.DolulukOrani);
                }
            }
        }
        private void kagıtButton_Click(object sender, EventArgs e)
        {
            //Pictureboxdan resmin ismini çekiyor,"png"kısmını substring ile kesiyoruz,listbox ta aratıyoruz
            var arananAtik = pictureBox1.ImageLocation.ToString();
            arananAtik=arananAtik.Substring(0, arananAtik.Length - 4);
            var siraNo = _kagitAtik.IndexOf(arananAtik);
            //Resim eğer listede var ise siraNo değişkenine resmin oldugu indexi atıyor yok ise -1 atanıyor
            if (siraNo > -1)
            {
                //Aranan atik listedeki hangi atığın olduğunu sorguluyor ve yeterli hacim var mı diye sorgulanıyor
                if (arananAtik == gazete.Ad && kagitAtik.Ekle(gazete))
                {
                    //Listbox a yazdırma,resim değiştirme,puanı güncelleme,dolu hacmi güncelle,progress barı ilerletme işlemleri yapılıyor
                    kagitListBox.Items.Add(gazete.ToString());
                    ResimDegisti();
                    PuanArttir(gazete); 
                    kagitAtik.DoluHacim += gazete.Hacim;
                    kagitBar.Value =Convert.ToInt32(kagitAtik.DolulukOrani);
                }
                else if (arananAtik == dergi.Ad && kagitAtik.Ekle(dergi))
                {
                    kagitListBox.Items.Add(dergi.ToString());
                    ResimDegisti();
                    PuanArttir(dergi);
                    kagitAtik.DoluHacim += dergi.Hacim;
                    kagitBar.Value =Convert.ToInt32(kagitAtik.DolulukOrani);
                }
            }
        }
        private void camButton_Click(object sender, EventArgs e)
        {
            //Pictureboxdan resmin ismini çekiyor,"png"kısmını substring ile kesiyoruz,listbox ta aratıyoruz
            var arananAtik = pictureBox1.ImageLocation.ToString();
            arananAtik = arananAtik.Substring(0, arananAtik.Length - 4);
            var siraNo = _camAtik.IndexOf(arananAtik);
            //Resim eğer listede var ise siraNo değişkenine resmin oldugu indexi atıyor yok ise -1 atanıyor
            if (siraNo > -1)
            {
                //Aranan atik listedeki hangi atığın olduğunu sorguluyor ve yeterli hacim var mı diye sorgulanıyor
                if (arananAtik == bardak.Ad && camAtik.Ekle(bardak))
                {
                    //Listbox a yazdırma,resim değiştirme,puanı güncelleme,dolu hacmi güncelle,progress barı ilerletme işlemleri yapılıyor
                    camListBox.Items.Add(bardak.ToString());
                    ResimDegisti();
                    PuanArttir(bardak);
                    camAtik.DoluHacim += bardak.Hacim;
                    camBar.Value =Convert.ToInt32(camAtik.DolulukOrani);
                }
                else if (arananAtik == camSise.Ad && camAtik.Ekle(camSise) == true)
                {
                    camListBox.Items.Add(camSise.ToString());
                    ResimDegisti();
                    PuanArttir(camSise);
                    camAtik.DoluHacim += camSise.Hacim;
                    camBar.Value =Convert.ToInt32(camAtik.DolulukOrani);
                }
            }
        }
        private void metalButton_Click(object sender, EventArgs e)
        {
            //Pictureboxdan resmin ismini çekiyor,"png"kısmını substring ile kesiyoruz,listbox ta aratıyoruz
            var arananAtik = pictureBox1.ImageLocation.ToString();
            arananAtik = arananAtik.Substring(0, arananAtik.Length - 4);
            var siraNo = _metalAtik.IndexOf(arananAtik);
            //Resim eğer listede var ise siraNo değişkenine resmin oldugu indexi atıyor yok ise -1 atanıyor
            if (siraNo > -1)
            {
                //Aranan atik listedeki hangi atığın olduğunu sorguluyor  ve yeterli hacim var mı diye sorgulanıyor
                if (arananAtik == kola.Ad && metalAtik.Ekle(kola))
                {
                    //Listbox a yazdırma,resim değiştirme,puanı güncelleme,dolu hacmi güncelle,progress barı ilerletme işlemleri yapılıyor
                    metalListBox.Items.Add(kola.ToString());
                    ResimDegisti();
                    PuanArttir(kola);
                    metalAtik.DoluHacim += kola.Hacim;
                    metalBar.Value = Convert.ToInt32(metalAtik.DolulukOrani);
                }
                else if (arananAtik == salca.Ad && metalAtik.Ekle(salca)==true)
                {
                    metalListBox.Items.Add(salca.ToString());
                    ResimDegisti();
                    PuanArttir(salca);
                    metalAtik.DoluHacim += salca.Hacim;
                    metalBar.Value =Convert.ToInt32(metalAtik.DolulukOrani);
                }
            }
        }
        //Süreyi tutmamızı sağlıyor
        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            süreLabel.Text = süre.ToString();
            if (süre == 0)
            {
                timer1.Enabled = false;
                yeniOyunButton.Enabled = true;
                organikAtikButton.Enabled = false;
                metalButton.Enabled = false;
                camButton.Enabled = false;
                kagıtButton.Enabled = false;
                organikAtıkBosaltButton.Enabled = false;
                metalBosaltButton.Enabled = false;
                kagitBosaltButton.Enabled = false;
                camBosaltButton.Enabled = false;
            }
        }
        //Atık kutusu boşaltıldığında puan güncelleniyor,süre güncelleniyor ve atığın dolu hacmi sıfırlanıyor
        public void AtikKutusuBosalt(AtikKutusu atikKutusu)
        {
            puan += atikKutusu.BosaltmaPuani;
            puanLabel.Text = puan.ToString();
            süre += 3;
            atikKutusu.DoluHacim = 0;
        }
        private void organikAtıkBosaltButton_Click(object sender, EventArgs e)
        {
            //Atık kutusunun doluluk oranı sorgulanıyor
            if (organikAtik.Bosalt())
            {
                //Atik kutusunun progressbarı sıfırlanıyor,listbox temizleniyor ve AtikKutusuBosalt fonku çalışıyor
                organikAtikBar.Value = 0;
                organikAtikListBox.Items.Clear();
                AtikKutusuBosalt(organikAtik);
            }
        }
        private void kagitBosaltButton_Click(object sender, EventArgs e)
        {
            //Atık kutusunun doluluk oranı sorgulanıyor
            if (kagitAtik.Bosalt())
            {
                //Atik kutusunun progressbarı sıfırlanıyor,listbox temizleniyor ve AtikKutusuBosalt fonku çalışıyor
                kagitBar.Value = 0;
                kagitListBox.Items.Clear();
                AtikKutusuBosalt(kagitAtik);
            }
        }
        private void camBosaltButton_Click(object sender, EventArgs e)
        {
            //Atık kutusunun doluluk oranı sorgulanıyor
            if (camAtik.Bosalt())
            {
                //Atik kutusunun progressbarı sıfırlanıyor,listbox temizleniyor ve AtikKutusuBosalt fonku çalışıyor
                camBar.Value = 0;
                camListBox.Items.Clear();
                AtikKutusuBosalt(camAtik);
            }
        }
        private void metalBosaltButton_Click(object sender, EventArgs e)
        {
            //Atık kutusunun doluluk oranı sorgulanıyor
            if (metalAtik.Bosalt())
            {
                //Atik kutusunun progressbarı sıfırlanıyor,listbox temizleniyor ve AtikKutusuBosalt fonku çalışıyor
                metalBar.Value = 0;
                metalListBox.Items.Clear();
                AtikKutusuBosalt(metalAtik);
            }
        }
        private void cikisButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
