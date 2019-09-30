using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ParkClient.Pages;

namespace ParkClient.API
{
    public class PageManager
    {
        public static Page PageEmpty = new PageEmpty();

        public static Page RealTime = new RealTimeView()
        {
            DataContext = new Pages.RealTimeViewModel()
        };
    }
}