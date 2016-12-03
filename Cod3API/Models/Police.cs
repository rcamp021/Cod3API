//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Police
    {
        public int Id { get; set; }
        public Nullable<int> IncidentNumber { get; set; }
        public string ReportNumber { get; set; }
        public string CallType { get; set; }
        public string Zone { get; set; }
        public string CaseDisposition { get; set; }
        public string Priority { get; set; }
        public string Subdivision { get; set; }
        public Nullable<System.DateTime> CallDateTime { get; set; }
        public Nullable<System.DateTime> EntryDateTime { get; set; }
        public Nullable<System.DateTime> DispatchDateTime { get; set; }
        public Nullable<System.DateTime> EnRouteDateTime { get; set; }
        public Nullable<System.DateTime> OnSceneDateTime { get; set; }
        public Nullable<System.DateTime> CloseDateTime { get; set; }
        public System.Data.Entity.Spatial.DbGeography Location { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
