//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nurieva_kurs
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public int id { get; set; }
        public int idUser { get; set; }
        public int idFlower { get; set; }
        public int count { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
    
        public virtual Flower Flower { get; set; }
        public virtual User User { get; set; }
    }
}