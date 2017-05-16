using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Venues
/// </summary>
public class Venues
{
    public List<Venue> venueList;
    public Venues()
    {
        ManageVenueData mv = new ManageVenueData();
        venueList = mv.GetVenuesFromDatabase();
    }

    public void AddVenue(Venue v)
    {
        venueList.Add(v);
    }

    public List<Venue> GetVenues()
    {
        return venueList;
    }
}