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
    
    public partial class keyboard
    {
        public int id_keyboard { get; set; }
        public string Name { get; set; }
        public Nullable<int> id_Key_illumination_color { get; set; }
        public Nullable<int> id_color { get; set; }
        public Nullable<int> id_proizvoditel { get; set; }
        public Nullable<int> id_type_K { get; set; }
        public Nullable<int> id_garantii { get; set; }
    
        public virtual Color Color { get; set; }
        public virtual Garantiya Garantiya { get; set; }
        public virtual Key_illumination_color Key_illumination_color { get; set; }
        public virtual keyboard_type keyboard_type { get; set; }
        public virtual proizvoditel proizvoditel { get; set; }
    }
}
