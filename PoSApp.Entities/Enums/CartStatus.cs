using System.ComponentModel;

namespace PoSApp.Entities.Enums
{
    public enum CartStatus
    {
        [Description("Bekliyor")]
        Pending = 0,
        [Description("Ödeme Yapıldı")]
        Payed = 1,
        [Description("İptal Edildi")]
        Canceled = 2
    }
}
