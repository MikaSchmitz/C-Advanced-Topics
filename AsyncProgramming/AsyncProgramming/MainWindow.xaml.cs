using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncProgramming
{
    /// <summary>
    /// 
    /// Use async for improving responsiveness of software
    /// Async allow processes to run on other threads so that the rest of the process can continue
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            dynamic url = "http://msdn.microsoft.com";

            //call async void task
            DownloadHtmlAsync(url);

            //call async return task
            var getHtmlTask = GetHtmlAsync(url);

            MessageBox.Show("Waiting for the task to complete.");

            var html = await getHtmlTask;
            
            MessageBox.Show(html.Substring(0, 30));
        }



        //non-async
        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"E:/Coding/result.html"))
            {
                streamWriter.Write(html);
            }
        }



        //async (async uses Task both generic and non-generic(void))
        //this async returns void
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            //await lets the compiler know that this method will be costly and running async
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"E:/Coding/result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }



        //this async returns a value
        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}
