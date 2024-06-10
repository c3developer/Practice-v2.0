using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdkpractice
{
    public class MarketReport
    {
        public Workshop Workshop { get; set; }
        public HistoryItem[] History { get; set; }
    }
    // Переменные для шапки
    public class Workshop
    {
        public String ShopName { get; set; }// цех
        public String Sector { get; set; }// участок
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    //Переменные для таблицы
    public class HistoryItem
    {
        public decimal Tension { get; set; }
        public DateTime Timer { get; set; }
    }
}
