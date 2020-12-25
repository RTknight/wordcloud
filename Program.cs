using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using SpiderWeb;
namespace test1234
{
    using wordcloud = WordCloud.WordCloud;
    class Analysis
    { 
        static public void WordCLD(List<string> wordc, List<int> fre)
        {
            wordcloud wc = new wordcloud(1000, 720);
            var ima = wc.Draw(wordc, fre);
            var newFilename = @"E:\词云.jpg";
            ima.Save(newFilename, ImageFormat.Jpeg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordc = new List<string>();
            List<int> fre = new List<int>();
            for (int i=0; i<=5; i++)
            {
                string a;
                a = Console.ReadLine();
                wordc.Add(a);
                fre.Add(i);
            }
            Analysis.WordCLD(wordc, fre);
        }
    }
}
