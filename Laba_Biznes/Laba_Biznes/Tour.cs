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
    
    public partial class Tour
    {
        public int id { get; set; }
        public Nullable<int> Ticket_count { get; set; }
        public string Name_tour { get; set; }
        public string Description_tour { get; set; }
        public int Image_id { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<bool> Is_Actual { get; set; }


        public string ActualText
        {
            get { return ((bool)Is_Actual) ? "Активен" : "Завершен"; }
        }

        public virtual Hotel Hotel { get; set; }
        public virtual ImageTour ImageTour { get; set; }
        public virtual Type_Hotel Type_Hotel { get; set; }
    }
}
