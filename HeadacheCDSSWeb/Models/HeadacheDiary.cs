//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace HeadacheCDSSWeb.Models
{
    public partial class HeadacheDiary
    {
        public HeadacheDiary()
        {
            this.HDAcompanion = new HashSet<HDAcompanion>();
            this.HDheadacheplace = new HashSet<HDheadacheplace>();
            this.HDHeadacheProdrome = new HashSet<HDHeadacheProdrome>();
            this.HDMitigatingFactors = new HashSet<HDMitigatingFactors>();
            this.HDPrecipitatingFactor = new HashSet<HDPrecipitatingFactor>();
        }
    
        public int ID { get; set; }
        public System.DateTime RecordDate { get; set; }
        public int HeadacheTime { get; set; }
        public string HeadacheType { get; set; }
        public string PatBasicInforId { get; set; }
        public int HeadacheDegree { get; set; }
    
        public virtual ICollection<HDAcompanion> HDAcompanion { get; set; }
        public virtual ICollection<HDheadacheplace> HDheadacheplace { get; set; }
        public virtual ICollection<HDHeadacheProdrome> HDHeadacheProdrome { get; set; }
        public virtual ICollection<HDMitigatingFactors> HDMitigatingFactors { get; set; }
        public virtual ICollection<HDPrecipitatingFactor> HDPrecipitatingFactor { get; set; }
        public virtual PatBasicInfor PatBasicInfor { get; set; }
    }
    
}
