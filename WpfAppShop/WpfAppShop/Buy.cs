//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAppShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buy
    {
        public int ID_buy { get; set; }
        public int ID_tovar { get; set; }
        public string Amount { get; set; }
        public int ID_worker { get; set; }
        public System.DateTime Date { get; set; }
        public string Price { get; set; }
    
        public virtual Tovar Tovar { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
