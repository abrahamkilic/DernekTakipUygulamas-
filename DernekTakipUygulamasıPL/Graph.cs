using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using BL;
using EL;

namespace DernekTakipUygulamasıPL
{
    public partial class Graph : Form
    {


        public Graph()
        {
            InitializeComponent();
            InitializeGraph();

            
        }

        private void InitializeGraph()
        {

            Controls.Add(zedGraphControl1);

            GraphPane graphPane = zedGraphControl1.GraphPane;
            graphPane.Title.Text = "Aidat Gelirleri Grafiği";
            graphPane.XAxis.Title.Text = "Ay";
            graphPane.YAxis.Title.Text = "Miktar";
            graphPane.XAxis.MajorGrid.IsVisible = true;
            graphPane.YAxis.MajorGrid.IsVisible = true;

        }

        private void BtnYear_Click(object sender, EventArgs e)
        {
            List<decimal> yearlyPaymentTotals = BLGraph.GetYearlyPaymentTotals();
            // Temizleme: Mevcut grafiği sil
            GraphPane graphPane = zedGraphControl1.GraphPane;
            graphPane.CurveList.Clear();

            // Yıllık ödeme miktarlarını alın
           

            // Yılları temsil eden etiketler
            List<string> yearlyLabels = BLGraph.GetYearlyData(); // Örnek olarak yılları tekrar alabilirsiniz

            // Yıllık ödeme miktarlarını grafik üzerine ekleyin
            BarItem yearlyBar = CreateBar("Yıllık", yearlyPaymentTotals.Select(x => (double)x).ToList(), System.Drawing.Color.Red);

            // X eksenindeki etiketleri yıl isimleriyle güncelle
            string[] yearLabels = yearlyLabels.ToArray();
            graphPane.XAxis.Scale.TextLabels = yearLabels;
            graphPane.XAxis.Type = AxisType.Text;

            // Eksen isimlerini güncelleyin
            graphPane.XAxis.Title.Text = "Yıl";

            // Eksenleri güncelleyin ve grafiği tekrar çizin
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();


        }

        

        private BarItem CreateBar(string label, List<double> data, System.Drawing.Color color)
        {
            GraphPane graphPane = zedGraphControl1.GraphPane;
            BarItem bar = graphPane.AddBar(label, null, data.ToArray(), color);
            bar.Bar.Fill = new Fill(color);

            return bar;
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            // ComboBox'a yılları ekleyin
            for (int year = DateTime.Now.Year; year >= 2000; year--) // Belirli bir aralık, burada 2000'den itibaren güncel yıla kadar
            {
                comboBoxYears.Items.Add(year);
            }

            // İlk yılı seçili olarak ayarlayabilirsiniz
            comboBoxYears.SelectedIndex = 0;
        }

        private void BtnAylik_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxYears.SelectedItem != null)
            {
                DateTime selectedYear = new DateTime(Convert.ToInt32(comboBoxYears.SelectedItem), 1, 1);

                List<double> monthlyData = BLGraph.GetMonthlyData(selectedYear);

                GraphPane graphPane = zedGraphControl1.GraphPane;
                graphPane.CurveList.Clear();

                // Aylık verileri grafik üzerine ekleyin
                BarItem monthlyBar = CreateBar("Aylık", monthlyData, System.Drawing.Color.Blue);

                // X eksenindeki etiketleri ay isimleriyle güncelle
                string[] monthLabels = new string[] { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };

                graphPane.XAxis.Scale.TextLabels = monthLabels;
                graphPane.XAxis.Type = AxisType.Text;

                // Eksen isimlerini güncelleyin
                zedGraphControl1.AxisChange();

                // Grafik yeniden çizim
                zedGraphControl1.Invalidate();
            }
            else
            {
                MessageBox.Show("Lütfen bir yıl seçin!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<(string City, int MemberCount)> memberStats = BLGraph.GetMemberStatsByCities();

            GraphPane graphPane = zedGraphControl1.GraphPane; // Mevcut zedGraphControl1 kontrolünün GraphPane'ini kullanıyoruz
            graphPane.CurveList.Clear();
            // Grafik ayarlarını yapabilirsin: başlık, eksenlerin adları, renkler vb.

            BarItem bar = graphPane.AddBar("Üye Sayısı", null, memberStats.Select(stat => Convert.ToDouble(stat.MemberCount)).ToArray(), System.Drawing.Color.Blue);
            bar.Bar.Fill = new Fill(System.Drawing.Color.Blue); // Çubuk rengini ayarla

            string[] labels = memberStats.Select(stat => stat.City).ToArray();
            graphPane.XAxis.Scale.TextLabels = labels;
            graphPane.XAxis.Type = AxisType.Text;
            bar.Bar.Fill = new Fill(System.Drawing.Color.LightBlue);
            bar.Bar.Border.IsVisible = true;
            bar.Bar.Border.Width = 1.0f;
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }
    }
}
