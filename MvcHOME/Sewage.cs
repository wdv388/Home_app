//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcHOME
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Sewage
    {
        public int ID { get; set; }
        public int S1 { get; set; }
        public int S0 { get; set; }
        public int ST { get; set; }
        public int SP { get; set; }
        public int SD { get; set; }
        [DisplayFormat(DataFormatString = "{0:0.0000}")]
        public decimal Sum { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime Data { get; set; }
        public int HomID { get; set; }
    
        public virtual Hom Hom { get; set; }
    }
}