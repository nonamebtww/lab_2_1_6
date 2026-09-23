using System.Collections.Generic;
using Domain;
using Domain.Abstractions.Interfaces;

namespace Console {
internal class Program {

  #region Task 1

  private static void Add(List<int> list) {
    list.Add(ReadInt("Введите элемент: "));
    System.Console.WriteLine("Элемент добавлен.");
  }

  private static void AddRange(List<int> list) {
    System.Console.WriteLine("Введите элементы через пробел:");

    foreach (var i in (System.Console.ReadLine() ?? string.Empty).Split(' ')) {
      if (!int.TryParse(i, out var item)) {
        System.Console.WriteLine($"Не удалось добавить: {i}");
        continue;
      }
      
      list.Add(item);
    }

    System.Console.WriteLine("Элементы добавлены.");
  }

  private static void BinarySearch(List<int> list) {
    var index = list.BinarySearch(
      ReadInt("Введите элемент для поиска: ")
    );

    System.Console.WriteLine(index >= 0 ? $"Элемент найден. Индекс: {index}" : "Элемент не найден.");
  }

  private static void IndexOf(List<int> list) {
    var index = list.IndexOf(
      ReadInt("Введите элемент для поиска: ")
    );

    System.Console.WriteLine(index >= 0 ? $"Первое вхождение находится по индексу: {index}" : "Элемент не найден.");
  }

  private static void Insert(List<int> list) {
    var index = ReadInt("Введите индекс: ");
    var item = ReadInt("Введите элемент: ");

    if (index < 0 || index > list.Count) {
      System.Console.WriteLine("Некорректный индекс.");
      return;
    }

    list.Insert(index, item);

    System.Console.WriteLine("Элемент вставлен.");
  }

  private static void Remove(List<int> list) {
    var result = list.Remove(
      ReadInt("Введите элемент для удаления: ")
    );

    System.Console.WriteLine(result ? "Элемент удалён." : "Элемент не найден.");
  }

  private static void RemoveAt(List<int> list) {
    int index = ReadInt("Введите индекс: ");

    if (index < 0 || index >= list.Count) {
      System.Console.WriteLine("Некорректный индекс.");
      return;
    }

    list.RemoveAt(index);

    System.Console.WriteLine("Элемент удалён.");
  }

  private static void Sort(List<int> list) {
    list.Sort();

    System.Console.WriteLine("Список отсортирован.");
  }

  private static void PrintList(List<int> list) {
    System.Console.WriteLine("\nТекущий список:");

    if (list.Count == 0) {
      System.Console.WriteLine("Список пуст.");
      return;
    }

    for (int i = 0; i < list.Count; i++) {
      System.Console.WriteLine($"[{i}] {list[i]}");
    }
  }

  private static void ShowMenuTask1() {
    var list = new List<int>();
    
    while (true) {
      System.Console.Clear();
      
      System.Console.Write(
        "Действия:\n" +
        "1. Add - добавить элемент\n" +
        "2. AddRange - добавить коллекцию\n" +
        "3. BinarySearch - бинарный поиск\n" +
        "4. IndexOf - поиск первого вхождения\n" +
        "5. Insert - вставить элемент\n" +
        "6. Remove - удалить элемент\n" +
        "7. RemoveAt - удалить по индексу\n" +
        "8. Sort - сортировка\n" +
        "9. Вывести список\n" +
        "0. Выход\n" +
        "Выберите действие: "
      );

      switch (System.Console.ReadLine()) {
        case "1":
          Add(list);
          break;
        case "2":
          AddRange(list);
          break;
        case "3":
          BinarySearch(list);
          break;
        case "4":
          IndexOf(list);
          break;
        case "5":
          Insert(list);
          break;
        case "6":
          Remove(list);
          break;
        case "7":
          RemoveAt(list);
          break;
        case "8":
          Sort(list);
          break;
        case "9":
          PrintList(list);
          break;
        case "0":
          System.Console.WriteLine("Программа завершена.");
          return;
        default:
          System.Console.WriteLine("Введено неверное действие!");
          break;
      }
    }
  }

  #endregion

  #region Task 2

  private static void Add(List<IHouse> houses) {
    houses.Add(CreateHouse());

    System.Console.WriteLine("Дом добавлен.");
  }

  private static void AddRange(List<IHouse> houses) {
    var count = ReadInt("Введите количество домов: ");

    for (var i = 0; i < count; i++) {
      System.Console.WriteLine($"\n===== Дом {i + 1} =====");
      houses.Add(CreateHouse());
    }

    System.Console.WriteLine("\nКоллекция домов добавлена.");
  }

  private static void BinarySearch(List<IHouse> houses) {
    var house = new PrivateHouse {
      Area = ReadUShort("Введите площадь дома для поиска: ")
    };

    var index = houses.BinarySearch(house);

    if (index >= 0) {
      System.Console.WriteLine($"Дом найден. Индекс: {index}");
      System.Console.WriteLine(houses[index].DisplayInfo());
    }
    else {
      System.Console.WriteLine("Дом с такой площадью не найден.");
    }
  }

  private static void IndexOf(List<IHouse> houses) {
    System.Console.WriteLine("Введите данные дома для поиска:");
    var index = houses.IndexOf(CreateHouse());

    if (index >= 0) {
      System.Console.WriteLine($"Дом найден. Индекс: {index}");
    }
    else {
      System.Console.WriteLine("Такой дом не найден.");
    }
  }

  private static void Insert(List<IHouse> houses) {
    var index = ReadInt("Введите индекс: ");

    if (index < 0 || index > houses.Count) {
      System.Console.WriteLine("Некорректный индекс.");
      return;
    }

    houses.Insert(index, CreateHouse());
    System.Console.WriteLine("Дом вставлен.");
  }

  private static void Remove(List<IHouse> houses) {
    System.Console.WriteLine("Введите данные дома для удаления:");

    if (houses.Remove(CreateHouse())) {
      System.Console.WriteLine("Дом удалён.");
    }
    else {
      System.Console.WriteLine("Такой дом не найден.");
    }
  }

  private static void RemoveAt(List<IHouse> houses) {
    var index = ReadInt("Введите индекс: ");

    if (index < 0 || index >= houses.Count) {
      System.Console.WriteLine("Некорректный индекс.");
      return;
    }

    houses.RemoveAt(index);
    System.Console.WriteLine("Дом удалён.");
  }

  private static void Sort(List<IHouse> houses) {
    houses.Sort();

    System.Console.WriteLine("Список домов отсортирован по площади.");
  }

  private static IHouse CreateHouse() {
    while (true) {
      System.Console.Write(
        "\nВыберите тип дома:\n" +
        "1. Многоквартирный дом\n" +
        "2. Частный дом\n" +
        "3. Таунхаус\n" +
        "Ваш выбор: "
      );

      switch (System.Console.ReadLine()) {
        case "1":
          return CreateApartmentBuilding();
        case "2":
          return CreatePrivateHouse();
        case "3":
          return CreateTownHouse();
        default:
          System.Console.WriteLine("Неизвестный тип дома.");
          continue;
      }
    }
  }

  private static ApartmentBuilding CreateApartmentBuilding() {
    var house = new ApartmentBuilding();

    System.Console.Write("Введите адрес: ");
    house.Address = System.Console.ReadLine();
    house.Area = ReadUShort("Введите площадь: ");
    house.Floors = ReadUShort("Введите количество этажей: ");
    house.Apartments = ReadUShort("Введите количество квартир: ");

    return house;
  }

  private static PrivateHouse CreatePrivateHouse() {
    PrivateHouse house = new PrivateHouse();

    System.Console.Write("Введите адрес: ");
    house.Address = System.Console.ReadLine();
    house.Area = ReadUShort("Введите площадь: ");
    house.Floors = ReadUShort("Введите количество этажей: ");

    System.Console.Write("Есть гараж? (1 - да, 0 - нет): ");
    house.HasGarage = System.Console.ReadLine() == "1";

    return house;
  }

  private static TownHouse CreateTownHouse() {
    TownHouse house = new TownHouse();

    System.Console.Write("Введите адрес: ");
    house.Address = System.Console.ReadLine();
    house.Area = ReadUShort("Введите площадь: ");
    house.Floors = ReadUShort("Введите количество этажей: ");
    house.Sections = ReadUShort("Введите количество секций: ");

    return house;
  }

  private static void PrintList(List<IHouse> houses) {
    System.Console.WriteLine("\n===== СПИСОК ДОМОВ =====");

    if (houses.Count == 0) {
      System.Console.WriteLine("Список пуст.");
      return;
    }

    for (int i = 0; i < houses.Count; i++) {
      System.Console.WriteLine($"[{i}] {houses[i].DisplayInfo()}");
    }
  }

  private static void ShowMenuTask2() {
    var list = new List<IHouse>();

    while (true) {
      System.Console.Clear();
      
      System.Console.Write(
        "Действия:\n" +
        "1. Add - добавить элемент\n" +
        "2. AddRange - добавить коллекцию\n" +
        "3. BinarySearch - бинарный поиск\n" +
        "4. IndexOf - поиск первого вхождения\n" +
        "5. Insert - вставить элемент\n" +
        "6. Remove - удалить элемент\n" +
        "7. RemoveAt - удалить по индексу\n" +
        "8. Sort - сортировка\n" +
        "9. Вывести список\n" +
        "0. Выход\n" +
        "Выберите действие: "
      );

      switch (System.Console.ReadLine()) {
        case "1":
          Add(list);
          break;
        case "2":
          AddRange(list);
          break;
        case "3":
          BinarySearch(list);
          break;
        case "4":
          IndexOf(list);
          break;
        case "5":
          Insert(list);
          break;
        case "6":
          Remove(list);
          break;
        case "7":
          RemoveAt(list);
          break;
        case "8":
          Sort(list);
          break;
        case "9":
          PrintList(list);
          break;
        case "0":
          return;
        default:
          System.Console.WriteLine("Введено неверное действие!");
          break;
      }
    }
  }
  
  #endregion
  
  #region Task 3

  private static void Push(Stack<IHouse> stack) {
    stack.Push(CreateHouse());

    System.Console.WriteLine("Дом добавлен в стек.");
  }
  
  private static void Pop(Stack<IHouse> stack) {
    if (stack.Count == 0) {
      System.Console.WriteLine("Стек пуст.");
      return;
    }

    var house = stack.Pop();

    System.Console.WriteLine("Из стека извлечён:");
    System.Console.WriteLine(house.DisplayInfo());
  }

  private static void Peek(Stack<IHouse> stack) {
    if (stack.Count == 0) {
      System.Console.WriteLine("Стек пуст.");
      return;
    }

    var house = stack.Peek();

    System.Console.WriteLine("Верхний элемент стека:");
    System.Console.WriteLine(house.DisplayInfo());
  }

  private static void PrintStack(Stack<IHouse> stack) {
    System.Console.WriteLine("\n===== STACK<IHOUSE> =====");

    if (stack.Count == 0) {
      System.Console.WriteLine("Стек пуст.");
      return;
    }

    var houses = stack.ToArray();

    for (var i = 0; i < houses.Length; i++) {
      System.Console.WriteLine($"[{i}] {houses[i].DisplayInfo()}");
    }
  }

  private static void ShowMenuTask3() {
    var stack = new Stack<IHouse>();

    while (true) {
      System.Console.Clear();
      
      System.Console.Write(
        "Действия:\n" +
        "1. Push - добавить дом в стек\n" +
        "2. Pop - извлечь дом из стека\n" +
        "3. Peek - посмотреть верхний элемент\n" +
        "4. Вывести стек\n" +
        "0. Выход\n" +
        "Выберите действие: "
      );

      switch (System.Console.ReadLine()) {
        case "1":
          Push(stack);
          break;
        case "2":
          Pop(stack);
          break;
        case "3":
          Peek(stack);
          break;
        case "4":
          PrintStack(stack);
          break;
        case "0":
          return;
        default:
          System.Console.WriteLine("Введено неверное действие!");
          break;
      }
    }
  }

  #endregion
  
  static void Main(string[] args) {
    while (true) {
      System.Console.Clear();
      
      System.Console.Write(
        "Задания:\n" +
        "1. Задание 1 - List<int>\n" +
        "2. Задание 2 - List<IHouse>\n" +
        "3. Задание 3 - Stack<IHouse>\n" +
        "0. Выход\n" +
        "Выберите задание: "
      );

      switch (System.Console.ReadLine()) {
        case "1":
          ShowMenuTask1();
          break;
        case "2":
          ShowMenuTask2();
          break;
        case "3":
          ShowMenuTask3();
          break;
        case "0":
          return;
        default:
          System.Console.WriteLine("Введено неверное задание!");
          break;
      }
    }
  }

  #region Helpers

  private static int ReadInt(string message) {
    while (true) {
      System.Console.Write(message);
      if (int.TryParse(System.Console.ReadLine(), out var result)) {
        return result;
      }
      
      System.Console.WriteLine("Введено неверное значение!");
    }
  }

  private static ushort ReadUShort(string message) {
    while (true) {
      System.Console.Write(message);
      if (ushort.TryParse(System.Console.ReadLine(), out var result)) {
        return result;
      }
      
      System.Console.WriteLine("Введено неверное значение!");
    }
  }

  #endregion
}
}