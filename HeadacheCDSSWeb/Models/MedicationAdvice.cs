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
    public partial class MedicationAdvice
    {
        public int Id { get; set; }
        public string DrugApplication { get; set; }
        public string DrugCategory { get; set; }
        public string DrugName { get; set; }
        public string DrugDose { get; set; }
        public int VisitRecordId { get; set; }
    
        public virtual VisitRecord VisitRecord { get; set; }
    }
    
}
