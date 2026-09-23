using Domain.Abstractions;

namespace Domain {
public class PrivateHouse : HouseBase {
  public bool HasGarage { get; set; } = false;
  
  public override string DisplayInfo() {
    return $"Частный дом: {Address}, площадь {Area}, {Floors} этажей, есть гараж {(HasGarage ? "да" : "нет")}";
  }
}
}