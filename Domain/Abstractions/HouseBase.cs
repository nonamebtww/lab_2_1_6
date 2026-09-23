using System;
using Domain.Abstractions.Interfaces;

namespace Domain.Abstractions {
public abstract class HouseBase : IHouse {
  public string Address { get; set; } = string.Empty;
  public ushort Area { get; set; } = 10;
  public ushort Floors { get; set; } = 1;
  
  public abstract string DisplayInfo();
  
  //
  public bool Equals(IHouse other) {
    if (other == null) {
      return false;
    }
    
    if (ReferenceEquals(this, other)) {
      return true;
    }
    
    return Address == other.Address && Area == other.Area && Floors == other.Floors;
  }

  public int CompareTo(IHouse other) {
    if (other == null) {
      return 1;
    }
    
    return string.Compare(
      Address,
      other.Address,
      StringComparison.OrdinalIgnoreCase
    );
  }
}
}