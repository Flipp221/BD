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
    using System.Windows.Input;

    public partial class Mouse
    {
        internal static Cursor OverrideCursor;

        public int id_mouse { get; set; }
        public string Name { get; set; }
        public string Min_DPI { get; set; }
        public string Max_DPI { get; set; }
        public Nullable<int> id_Key_illumination_color { get; set; }
        public Nullable<int> id_proizvoditel { get; set; }
        public Nullable<int> id_type_M { get; set; }
        public Nullable<int> id_garantii { get; set; }
    
        public virtual Garantiya Garantiya { get; set; }
        public virtual Key_illumination_color Key_illumination_color { get; set; }
        public virtual Mouse_type Mouse_type { get; set; }
        public virtual proizvoditel proizvoditel { get; set; }
    }
}