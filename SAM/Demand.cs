//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Demand
    {
        public int id { get; set; }
        public string Address { get; set; }
        public string MinPrice { get; set; }
        public string MaxPrice { get; set; }
        public string Catalog { get; set; }
    
        public virtual Catalog Catalog1 { get; set; }
    }
}
