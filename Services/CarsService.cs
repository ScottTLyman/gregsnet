using gregsnet.DB;
using gregsnet.Models;

namespace gregsnet.Services;

public class CarsService
{
  internal List<Car> GetAll()
  {
    return FakeDB.Cars;
  }

  internal Car GetById(string id)
  {
    Car found = FakeDB.Cars.Find(c => c.Id == id);
    if (found == null)
    {
      throw new Exception("Invalid Id");
    }
    return found;
  }

  internal Car Create(Car newCar)
  {
    FakeDB.Cars.Add(newCar);
    return newCar;
  }

  internal Car Update(Car updates)
  {
    Car original = GetById(updates.Id);
    original.Make = updates.Make ?? original.Make;
    original.Model = updates.Model ?? original.Model;
    return original;
  }

  internal void Delete(string id)
  {
    Car found = GetById(id);
    FakeDB.Cars.Remove(found);
  }
}