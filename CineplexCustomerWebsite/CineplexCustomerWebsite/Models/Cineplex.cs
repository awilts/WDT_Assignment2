
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
    
public partial class Cineplex
{

    public Cineplex()
    {

        this.CineplexMovie = new HashSet<CineplexMovie>();

    }


    public int CineplexID { get; set; }

    public string Location { get; set; }

    public string ShortDescription { get; set; }

    public string LongDescription { get; set; }

    public string ImageUrl { get; set; }



    public virtual ICollection<CineplexMovie> CineplexMovie { get; set; }

}

}