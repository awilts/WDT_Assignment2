
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CineplexCustomerWebsite.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Event
{

    public int EventID { get; set; }

    public string EventTitle { get; set; }

    public int CineplexID { get; set; }

    public System.DateTime EventDay { get; set; }

    public System.TimeSpan EventTime { get; set; }

    public string ShortDescription { get; set; }

    public string LongDescription { get; set; }

}

}