//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountigConsumable
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventarization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventarization()
        {
            this.MaterialInInventarization = new HashSet<MaterialInInventarization>();
        }
    
        public int id { get; set; }
        public int FK_Worker { get; set; }
        public int FK_Warehouse { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Warehouse Warehouse { get; set; }
        public virtual Worker Worker { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialInInventarization> MaterialInInventarization { get; set; }
    }
}
