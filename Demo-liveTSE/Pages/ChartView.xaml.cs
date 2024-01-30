using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;


namespace Demo_liveTSE.Pages ;

    public partial class ChartView : ContentPage
    {
        static List<ChartEntry> chartData1 = new List<ChartEntry>();
        static List<ChartEntry> chartData2 = new List<ChartEntry>();
        static List<ChartEntry> chartData3 = new List<ChartEntry>();

        static Random random = new Random();

        private static void AddData(List<ChartEntry> chartData)
        {
            int a = random.Next(-10, 10);
            for (int i = 0; i < 101; i++)
            {

                ChartEntry entry = null;
                if (a > 0)
                {
                    entry = new ChartEntry(random.Next(100*a + 5*i - 50, 100*a + 5*i + 50));

                }
                else
                {
                    entry = new ChartEntry(random.Next(100*a - 5*i - 50, 100*a - 5*i + 50));

                }

                if (i % 10 == 0)
                {
                    entry.Label = $"{6 + i / 10}:30:00";
                }

                chartData.Add(entry);
            }
        }

        private static void ResetData()
        {
            chartData1 = new List<ChartEntry>();
            chartData2 = new List<ChartEntry>();
            chartData3 = new List<ChartEntry>();
        }

        public ChartView()
        {
            InitializeComponent();
            AddData(chartData1);
            AddData(chartData2);
            AddData(chartData3);
            var cs1 = new ChartSerie
            {
                Entries = chartData1,
                Color = SKColor.Parse("#18c947")
            };
            var cs2 = new ChartSerie
            {
                Entries = chartData2,
                Color = SKColor.Parse("#ed001c")
            };
            var cs3 = new ChartSerie
            {
                Entries = chartData3,
                Color = SKColor.Parse("#0020ed")
            };
            
            ChartView1.Chart = new LineChart
            {
                Series = new []{cs1, cs2, cs3},
                ShowYAxisLines = true,
                ShowYAxisText = true,
                LineMode = LineMode.Straight,
                PointMode = PointMode.None,
                IsAnimated = true,
                LabelTextSize = 30,
                SerieLabelTextSize = 30
            };
        
            ResetData();

        }
    }