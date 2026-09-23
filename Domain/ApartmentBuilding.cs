using Domain.Abstractions;

namespace Domain {
public class ApartmentBuilding : HouseBase {
  public ushort Apartments { get; set; } = 1;
  
  public override string DisplayInfo() {
    return $"Многоквартирный дом: {Address}, площадь {Area}, {Floors} этажей, квартир {Apartments}";
  }
}
}