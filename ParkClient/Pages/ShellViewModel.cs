using System;
using System.Windows.Controls;
using ParkClient.API;
using ParkClient.Model;
using Stylet;

namespace ParkClient.Pages
{
    public class ShellViewModel : Screen
    {
        public Page CurrentPage { get; set; } = PageManager.PageEmpty;

        public ShellViewModel()
        {
            CurrentPage = PageManager.PageEmpty;
        }

        public void SelectMenu(string value)
        {
            try
            {
                var data = (LeftMenu)Enum.Parse(typeof(LeftMenu), value);
                if (data == LeftMenu.RealTime)
                    CurrentPage = PageManager.RealTime;
                else if (data == LeftMenu.Empty)
                    CurrentPage = PageManager.PageEmpty;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //SetAndNotify
            }
        }
    }
}