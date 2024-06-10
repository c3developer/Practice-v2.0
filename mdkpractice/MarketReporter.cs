// цех участок(идукционная печь) время(начало конец и выбор дня)
// напряжение (мин макс среднее) В таблице 3 столбца время hh.mm.ss ток 
using System.Data;
namespace mdkpractice
{
    //Генератор данных
    public class MakeReporter
    {
        public MarketReport GetReport()
        {
            return new MarketReport
            {
                Workshop = new Workshop
                {
                    ShopName = "ТПЦ-2",
                    Sector = "Индукционная Печь",
                    StartDate = new DateTime(2024, 6, 7),
                    EndDate = DateTime.Today
                },
                History = new[]
                {
                new HistoryItem {Tension = 23, Timer = new DateTime(2024 ,10, 6, 11, 24, 30)},
                new HistoryItem {Tension = 24, Timer =new DateTime (2024 ,10, 6, 11, 24, 45)} 
                }
            };
        }
    }
}

