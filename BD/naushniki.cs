//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class naushniki
    {
        public int id_naushnikov { get; set; }
        public string Name { get; set; }
        public string Signal_transmission_method { get; set; }
        public Nullable<int> id_color { get; set; }
        public Nullable<int> id_micro_ushi { get; set; }
        public Nullable<int> id_proizvoditel { get; set; }
        public Nullable<int> id_type_N { get; set; }
        public Nullable<int> id_garantii { get; set; }

        public virtual Color Color { get; set; }
        public virtual Garantiya Garantiya { get; set; }
        public virtual Micro_ushi Micro_ushi { get; set; }
        public virtual Naushniki_type Naushniki_type { get; set; }
        public virtual proizvoditel proizvoditel { get; set; }


    }
}
