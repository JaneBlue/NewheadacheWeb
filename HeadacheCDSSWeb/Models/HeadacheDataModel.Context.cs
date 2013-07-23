﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace HeadacheCDSSWeb.Models
{
    public partial class HeadacheModelContainer : DbContext
    {
        public HeadacheModelContainer()
            : base("name=HeadacheModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DoctorAccount> DoctorAccountSet { get; set; }
        public DbSet<PatBasicInfor> PatBasicInforSet { get; set; }
        public DbSet<VisitRecord> VisitRecordSet { get; set; }
        public DbSet<PrimaryHeadacheOverView> PrimaryHeadacheOverViewSet { get; set; }
        public DbSet<Lifestyle> LifestyleSet { get; set; }
        public DbSet<HeadachePlace> HeadachePlaceSet { get; set; }
        public DbSet<HeadacheAccompany> HeadacheAccompanySet { get; set; }
        public DbSet<HeadacheProdrome> HeadacheProdromeSet { get; set; }
        public DbSet<PreviousDrug> PreviousDrugSet { get; set; }
        public DbSet<PreviousExam> PreviousExamSet { get; set; }
        public DbSet<HeadacheFamilyMember> HeadacheFamilyMemberSet { get; set; }
        public DbSet<OtherFamilyDisease> OtherFamilyDiseaseSet { get; set; }
        public DbSet<MedicationAdvice> MedicationAdviceSet { get; set; }
        public DbSet<PrecipitatingFactor> PrecipitatingFactorSet { get; set; }
        public DbSet<MitigatingFactors> MitigatingFactorsSet { get; set; }
        public DbSet<SecondaryHeadacheSymptom> SecondaryHeadacheSymptomSet { get; set; }
        public DbSet<PremonitorySymptom> PremonitorySymptom集 { get; set; }
        public DbSet<PHQuestionaire> PHQuestionaireSet { get; set; }
        public DbSet<GADQuestionaire> GADQuestionaireSet { get; set; }
        public DbSet<DisabilityEvaluation> DisabilityEvaluationSet { get; set; }
        public DbSet<SleepStatus> SleepStatusSet { get; set; }
    }
}
