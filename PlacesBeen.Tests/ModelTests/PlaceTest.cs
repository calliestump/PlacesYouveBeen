using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesBeen.Models;
using System;

namespace PlacesBeen.TestTools
{
  [TestClass]
  public class PlaceTest :IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }
    
    
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("cityName", "travelPartner");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
    [TestMethod]
    public void GetPlace_ReturnPlace_String()
    {
      string cityName = "Portland";
      string travelPartner = "Steve";
      Place newPlace = new Place(cityName, travelPartner);
      string cityNameResult = newPlace.CityName;
      string travelPartnerResult = newPlace.TravelPartner;
      Assert.AreEqual(cityName, cityNameResult);
      Assert.AreEqual(travelPartner, travelPartnerResult);
    }

    [TestMethod]
    public void GetAll_RetunsEmptyList_PlaceList()
    {
      List<Place> newPlace = new List<Place> { };
      List<Place> result = Place.GetAll();

      // Assert
      CollectionAssert.AreEqual(newPlace, result);
    }
    [TestMethod]
    public void GetAll_ReturnPlace_PlaceList()
    {
      string place01 = "Portland";
      string place02 = "Jackson";
      string partner01 = "Steve";
      string partner02 = "Brooke";
      Place newPlace1 = new Place(place01, partner01);
      Place newPlace2 = new Place(place02, partner02);
      List<Place> newList = new List<Place> { newPlace1, newPlace2 };
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    // [TestMethod]
    // public void GetId_ItemsMadeWithAnIdAndReturned_Int()
    // {
    //   string cityName = "Portland";
    //   Place newPlace = new Place(cityName);
      
    //   int result = newPlace.Id;

    //   Assert.AreEqual(1, result);
    // }

    // [TestMethod]
    // public void Find_ReturnsCorrectPlace_Place()
    // {
    //   string cityName1 = "Portland";
    //   string cityName2 = "Jackson";
    //   Place newPlace1 = new Place(cityName1);
    //   Place newPlace2 = new Place(cityName2);

    //   Place result = Place.Find(2);

    //   Assert.AreEqual(newPlace2, result);
    // }
  }
}