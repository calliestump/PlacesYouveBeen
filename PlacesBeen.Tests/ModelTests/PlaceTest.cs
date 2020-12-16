using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesBeen.Models;
using System;

namespace PlacesBeen.TestTools
{
  [TestClass]
  public class PlaceTest
  {
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("cityName");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
    [TestMethod]
    public void GetPlace_ReturnPlace_String()
    {
      string cityName = "Portland";
      Place newPlace = new Place(cityName);
      string result = newPlace.CityName;
      Assert.AreEqual("Seattle", result);
    }
  }
}

// public class PlaceTest : IDisposable
// {
//   public void Dispose()
//   {
//     Place.ClearAll();
//   }
// }