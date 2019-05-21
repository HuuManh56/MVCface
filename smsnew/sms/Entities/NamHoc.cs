namespace sms.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NamHoc")]
    public partial class NamHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NamHoc()
        {
            //HocKies = new HashSet<HocKy>();
        }

        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KetThuc { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<HocKy> HocKies { get; set; }
    }
}
