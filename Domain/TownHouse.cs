using Domain.Abstractions;

namespace Domain {
public class TownHouse : HouseBase {
  public ushort Sections { get; set; } = 1;
  
  public override string DisplayInfo() {
    return $"Таунхаус: {Address}, площадь {Area}, {Floors} этажей, {Sections} секций";
  }
}
}