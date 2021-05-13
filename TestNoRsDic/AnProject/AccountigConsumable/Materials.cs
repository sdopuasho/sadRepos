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
    
    public partial class Materials
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materials()
        {
            this.MaterialCard = new HashSet<MaterialCard>();
            this.MaterialInInventarization = new HashSet<MaterialInInventarization>();
        }
    
        public int id { get; set; }
        public string MaterialName { get; set; }
        public int FK_Manufacturer { get; set; }
        public int FK_MaterialGroup { get; set; }
        public int FK_Unit { get; set; }
    
        public virtual Manufacturer Manufacturer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialCard> MaterialCard { get; set; }
        public virtual MaterialGroup MaterialGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialInInventarization> MaterialInInventarization { get; set; }
        public virtual Unit Unit { get; set; }
    }
}