using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictKeys = new Dictionary<string, string>()
                {
                    {"OrderId","订单号"},
                    {"OrderStatus","订单状态"},
                    {"OrderPrice","订单总金额"},
                    {"OrderPayAmount","支付金额"},
                    {"OrderArrearsPrice","欠费金额"},
                    {"BatchId","批次号"},
                    {"OprStatusDesc","处理状态"},
                    {"OprNo","操作人工号"},
                    {"OprName","操作人姓名"},
                    {"StrOprTime","操作时间"}
                };//{"OrderId":"订单号","OrderStatus":"订单状态","OrderPrice":"订单总金额","OrderPayAmount":"支付金额","OrderArrearsPrice":"欠费金额","BatchId":"批次号","OprStatusDesc":"处理状态","OprNo":"操作人工号","OprName":"操作人姓名","StrOprTime":"操作时间"}

            var serialDict = JsonConvert.SerializeObject(dictKeys);
            Console.WriteLine(serialDict);
            var DeserialDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(serialDict);
            foreach (var item in DeserialDict)
            {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            }
            var dt = DealTradeDate(Convert.ToDateTime("2020-01-01 0:0:00"), Convert.ToDateTime("2020-01-01"));
            Console.WriteLine(JsonConvert.SerializeObject(dt));

            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe", "http://demomanage.1hai.cn/OrderInfo/Index?phoneNo=13585885928");
            Console.ReadLine();
        }

        private static DateTime DealTradeDate(DateTime tradeDate, DateTime accountDate)
        {
            if (tradeDate == DateTime.MinValue || accountDate == DateTime.MinValue) return DateTime.Now;
            if (tradeDate < DateTime.Now) return tradeDate;
            if (tradeDate > accountDate) return tradeDate.AddYears(-1);
            var dateStr = DateTime.Now.Year.ToString() + "0101";
            if (accountDate.ToString("yyyyMMdd") == dateStr) return tradeDate.AddYears(-1);
            return tradeDate;
        }
    }
}
