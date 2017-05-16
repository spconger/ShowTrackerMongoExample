using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;

/// <summary>
/// Summary description for ManageVenueData
/// </summary>
public class ManageVenueData
{
    public ManageVenueData()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void AddVenueToDatabase()
    {

    }

    public List<Venue> GetVenuesFromDatabase()
    {
        MongoClient client = new MongoClient();
        var db=client.GetDatabase("showTracker");
        var collection = db.GetCollection<BsonDocument>("venue");
        var document = collection.Find(new BsonDocument()).ToList();

        List<Venue> venues = new List<Venue>();
        foreach(BsonDocument v in document)
        {
            Venue ven = new Venue();
            ven.VenueKey = CleanData(v.GetElement("_id").ToString());
            ven.Address = CleanData(v.GetElement("address").ToString());
            ven.City = CleanData(v.GetElement("city").ToString());
            ven.zipcode = CleanData(v.GetElement("zipcode").ToString());
            ven.Email= CleanData(v.GetElement("email").ToString());
            ven.URL= CleanData(v.GetElement("url").ToString());
            //ven.Restriction= v.GetElement("restriction").ToString();

            venues.Add(ven);
        }
        return venues;
    }

    private string CleanData(string s)
    {
        int i = s.IndexOf("=");
        s = s.Substring(i + 1);
        return s;
    }
}