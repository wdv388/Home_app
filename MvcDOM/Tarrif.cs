//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcDOM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarrif
    {
        public int ID { get; set; }
        public decimal CW { get; set; }
        public decimal HW { get; set; }
        public decimal E { get; set; }
        public int HomID { get; set; }
        public decimal upEL150_250 { get; set; }
        public decimal S { get; set; }
    
        public virtual Hom Hom { get; set; }
    }
}
