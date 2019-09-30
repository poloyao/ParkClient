using ParkClient.Model;
using Stylet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ParkClient.Pages
{
    public class RealTimeViewModel : Screen
    {
        public List<CarAccess> Items { get; set; }

        public string Name { get; set; }

        public CarAccess AccessSelectedItem { get; set; }

        public RealTimeViewModel()
        {
            Items = new List<CarAccess>() {
                new CarAccess() { Car_id = 1, Car_number = "1234555", In_time = DateTime.Now },
                new CarAccess() { Car_id = 2, Car_number = "2222222", In_time = DateTime.Now }
            };
            Name = "Video";

            //启动现场实时监测进出车辆数据
        }

        public void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo");
        }
    }
}