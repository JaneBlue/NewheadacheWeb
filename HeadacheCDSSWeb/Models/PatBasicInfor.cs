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
    public partial class PatBasicInfor
    {
        public PatBasicInfor()
        {
            this.VisitRecord = new HashSet<VisitRecord>();
            this.PreviousDrug = new HashSet<PreviousDrug>();
            this.PreviousExam = new HashSet<PreviousExam>();
            this.HeadacheFamilyMember = new HashSet<HeadacheFamilyMember>();
            this.OtherFamilyDisease = new HashSet<OtherFamilyDisease>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public string Education { get; set; }
        public string Job { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Identity { get; set; }
        public string ChiefDoctor { get; set; }
        public int DoctorAccountId { get; set; }
        public Nullable<bool> SimilarFamily { get; set; }
    
        public virtual DoctorAccount DoctorAccount { get; set; }
        public virtual ICollection<VisitRecord> VisitRecord { get; set; }
        public virtual ICollection<PreviousDrug> PreviousDrug { get; set; }
        public virtual ICollection<PreviousExam> PreviousExam { get; set; }
        public virtual ICollection<HeadacheFamilyMember> HeadacheFamilyMember { get; set; }
        public virtual ICollection<OtherFamilyDisease> OtherFamilyDisease { get; set; }
        public virtual Lifestyle Lifestyle { get; set; }
    }
    
}
