﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cod3API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class cod3Entities : DbContext
    {
        public cod3Entities()
            : base("name=cod3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Em> Ems { get; set; }
        public virtual DbSet<Police> Police { get; set; }
    
        public virtual ObjectResult<GetEms_Result1> GetEms(string latitude, string longitude, Nullable<int> meters)
        {
            var latitudeParameter = latitude != null ?
                new ObjectParameter("latitude", latitude) :
                new ObjectParameter("latitude", typeof(string));
    
            var longitudeParameter = longitude != null ?
                new ObjectParameter("longitude", longitude) :
                new ObjectParameter("longitude", typeof(string));
    
            var metersParameter = meters.HasValue ?
                new ObjectParameter("meters", meters) :
                new ObjectParameter("meters", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEms_Result1>("GetEms", latitudeParameter, longitudeParameter, metersParameter);
        }
    
        public virtual ObjectResult<GetPolice_Result> GetPolice(string latitude, string longitude, Nullable<int> meters)
        {
            var latitudeParameter = latitude != null ?
                new ObjectParameter("latitude", latitude) :
                new ObjectParameter("latitude", typeof(string));
    
            var longitudeParameter = longitude != null ?
                new ObjectParameter("longitude", longitude) :
                new ObjectParameter("longitude", typeof(string));
    
            var metersParameter = meters.HasValue ?
                new ObjectParameter("meters", meters) :
                new ObjectParameter("meters", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPolice_Result>("GetPolice", latitudeParameter, longitudeParameter, metersParameter);
        }
    }
}
