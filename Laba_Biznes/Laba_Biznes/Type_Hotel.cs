//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laba_Biznes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Type_Hotel
    {
        public int id { get; set; }
        public string Name_type { get; set; }
        public string Description_type { get; set; }
    
        public virtual Tour Tour { get; set; }
    }
}
