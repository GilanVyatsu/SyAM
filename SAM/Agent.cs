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
    
    public partial class Agent
    {
        public int id { get; set; }
        public string Deal { get; set; }
        public string Share { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Supply Supply { get; set; }
    }
}
