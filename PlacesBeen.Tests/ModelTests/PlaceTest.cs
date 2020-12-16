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
      Place newPlace = new Place();
      Assert.AreEqual(typeof(Place), newPlace.GetType());
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