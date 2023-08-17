using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoSApp.Entities.Enums
{
    public enum PaymentType
    {
        [Description("Nakit")]
        Cash = 0,
        [Description("Kredi Kartı")]
        CreditCard = 1,
        [Description("Banka Havale/EFT")]
        BankTransfer = 2,
        [Description("Yemek Kartı")]
        MealCard = 3,
        [Description("Trendyol Hızlı Market")]
        TrendyolHizliMarket = 4
    }
}
