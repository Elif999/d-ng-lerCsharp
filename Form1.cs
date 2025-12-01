namespace WinFormsApp27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*þöylede yapabiliriz uzun yol ama yinede bil 
     int sayi = Convert.ToInt32(textBox1.Text);
          int bitiþ = Convert.ToInt32(textBox2.Text);
          for (int i=sayi;i<=bitiþ;i++)
          {
              MessageBox.Show(i.ToString());
          }
          for (int j = bitiþ; j == bitiþ; j++)
          {
              MessageBox.Show(j.ToString());
          }
          MessageBox.Show("döngü" + bitiþ + " kez çalýþtý");

      */
        private void button1_Click(object sender, EventArgs e)
        {
            int baslangýc = Convert.ToInt32(textBox1.Text);
            int bitiþ = Convert.ToInt32(textBox2.Text);
            for (int i = baslangýc; i <= bitiþ; i++)
            {
                MessageBox.Show(i.ToString());
            }
            
        }
  
    
      
    }
}
/*
 Tabii ki! Verdiðiniz kod parçasý, bir Windows Forms uygulamasýnda bir butona týklandýðýnda 
kullanýcýdan alýnan iki sayý arasýnda (baþlangýç ve bitiþ) her bir sayýyý bir mesaj kutusunda gösteren 
bir iþlevi yerine getiriyor. Þimdi kodun mantýðýný adým adým açýklayayým.

Kodun Tamamý:
private void button1_Click(object sender, EventArgs e)
{
    int baslangýc = Convert.ToInt32(textBox1.Text);
    int bitiþ = Convert.ToInt32(textBox2.Text);
    for (int i = baslangýc; i <= bitiþ; i++)
    {
        MessageBox.Show(i.ToString());
    }
}
Adým Adým Açýklama

Kullanýcý Girdilerini Alma:
int baslangýc = Convert.ToInt32(textBox1.Text);
int bitiþ = Convert.ToInt32(textBox2.Text);
Bu satýrlar, kullanýcýdan alýnan deðerleri textBox1 ve textBox2 adlý metin kutularýndan alýr.
textBox1'den alýnan deðer baslangýc deðiþkenine atanýr ve textBox2'den alýnan deðer bitiþ deðiþkenine atanýr.
Convert.ToInt32(...) ifadesi, metin kutusundan alýnan string deðerini tam sayýya (int) dönüþtürür.

Döngü ile Sayýlarý Gösterme:
for (int i = baslangýc; i <= bitiþ; i++)
{
    MessageBox.Show(i.ToString());
}
for döngüsü, i deðiþkenini baslangýc deðerinden baþlatýr ve bitiþ deðerine kadar (bitiþ dahil) devam eder.
i <= bitiþ ifadesi, döngünün i deðeri bitiþ deðerine eþit veya daha küçük olduðu sürece devam etmesini saðlar.
Her döngü adýmýnda, i deðeri bir mesaj kutusunda (MessageBox.Show(...)) gösterilir. 
i.ToString() ifadesi, i deðerini string (metin) formatýna dönüþtürerek mesaj kutusuna eklenmesini saðlar.

Örnek
Eðer kullanýcý textBox1'e 3 ve textBox2'ye 7 sayýsýný girerse:
Ýlk döngü adýmýnda (i = 3): Mesaj kutusunda 3 gösterilir.
Ýkinci döngü adýmýnda (i = 4): Mesaj kutusunda 4 gösterilir.
Üçüncü döngü adýmýnda (i = 5): Mesaj kutusunda 5 gösterilir.
Dördüncü döngü adýmýnda (i = 6): Mesaj kutusunda 6 gösterilir.
Beþinci döngü adýmýnda (i = 7): Mesaj kutusunda 7 gösterilir.
Sonuç
Kullanýcý textBox1'e 3 ve textBox2'ye 7 girdiðinde,
program 3'ten 7'ye kadar (her biri için ayrý bir mesaj kutusu açarak) þu sayýlarý gösterir: 3, 4, 5, 6, 7.
Özet
Bu kod,kullanýcýdan alýnan iki sayý arasýnda(baþlangýç ve bitiþ) her bir sayýyý bir mesaj kutusunda gösterir.
Kullanýcý button1 butonuna týkladýðýnda bu iþlem gerçekleþir.
Eðer baþka bir konuda daha fazla bilgi isterseniz, lütfen belirtin!
*/