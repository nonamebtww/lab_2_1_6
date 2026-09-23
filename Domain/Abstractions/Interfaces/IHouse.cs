using System;

namespace Domain.Abstractions.Interfaces {
public interface IHouse : IEquatable<IHouse>, IComparable<IHouse> {
  string Address { get; set; }
  ushort Area { get; set; }
  ushort Floors { get; set; }

  string DisplayInfo();
}
}