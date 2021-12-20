//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parks
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plants
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plants()
        {
            this.WorkSchedule = new HashSet<WorkSchedule>();
            this.Zones = new HashSet<Zones>();
        }
    
        public int ID_plant { get; set; }
        public string plant_name { get; set; }
        public string plant_age { get; set; }
        public Nullable<System.DateTime> planting_date { get; set; }
        public int ID_species { get; set; }
        public int ID_watering { get; set; }
    
        public virtual PlantSpecies PlantSpecies { get; set; }
        public virtual WateringMode WateringMode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkSchedule> WorkSchedule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zones> Zones { get; set; }
    }
}