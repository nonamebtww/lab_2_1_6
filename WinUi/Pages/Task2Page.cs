using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain;
using Domain.Abstractions.Interfaces;

namespace WinUi.Pages {
public partial class Task2Page : UserControl {
  private readonly List<IHouse> _houses = new List<IHouse>();

  public Task2Page() {
    InitializeComponent();
  }

  private void Task2Page_Load(object sender, EventArgs e) {
    UpdateList();
  }

  private void UpdateList() {
    list_items.Items.Clear();

    foreach (IHouse house in _houses) {
      list_items.Items.Add(house.DisplayInfo());
    }

    lbl_count.Text = $"Количество: {_houses.Count}";
  }

  private IHouse CreateHouse() {
    switch (combo_type.SelectedIndex) {
      case 0:
        return new ApartmentBuilding {
          Address = text_address.Text,
          Area = ushort.Parse(text_area.Text),
          Floors = ushort.Parse(text_floors.Text),
          Apartments = ushort.Parse(text_extra.Text)
        };

      case 1:
        return new PrivateHouse {
          Address = text_address.Text,
          Area = ushort.Parse(text_area.Text),
          Floors = ushort.Parse(text_floors.Text),
          HasGarage = check_extra.Checked
        };

      case 2:
        return new TownHouse {
          Address = text_address.Text,
          Area = ushort.Parse(text_area.Text),
          Floors = ushort.Parse(text_floors.Text),
          Sections = ushort.Parse(text_extra.Text)
        };

      default:
        return null;
    }
  }

  private bool TryCreateHouse(out IHouse house) {
    house = null;

    if (combo_type.SelectedIndex == -1) {
      lbl_result.Text = "Выберите тип дома.";
      return false;
    }

    if (string.IsNullOrWhiteSpace(text_address.Text)) {
      lbl_result.Text = "Введите адрес.";
      return false;
    }

    if (!ushort.TryParse(text_area.Text, out ushort area) || area == 0) {
      lbl_result.Text = "Введите корректную площадь.";
      return false;
    }

    if (!ushort.TryParse(text_floors.Text, out ushort floors) || floors == 0) {
      lbl_result.Text = "Введите корректное количество этажей.";
      return false;
    }

    if (combo_type.SelectedIndex != 1 &&
        (!ushort.TryParse(text_extra.Text, out ushort extra) || extra == 0)) {
      lbl_result.Text = "Введите корректное дополнительное значение.";
      return false;
    }

    try {
      house = CreateHouse();
      return true;
    }
    catch {
      lbl_result.Text = "Не удалось создать объект.";
      return false;
    }
  }

  private void btn_add_Click(object sender, EventArgs e) {
    if (!TryCreateHouse(out IHouse house)) {
      return;
    }

    _houses.Add(house);
    UpdateList();
    ClearInputs();

    lbl_result.Text = "Объект добавлен.";
  }

  private void btn_add_range_Click(object sender, EventArgs e) {
    List<IHouse> houses = new List<IHouse> {
      new ApartmentBuilding {
        Address = "ул. Ленина, 10",
        Area = 1200,
        Floors = 9,
        Apartments = 72
      },
      new PrivateHouse {
        Address = "ул. Центральная, 15",
        Area = 180,
        Floors = 2,
        HasGarage = true
      },
      new TownHouse {
        Address = "ул. Садовая, 25",
        Area = 250,
        Floors = 2,
        Sections = 4
      }
    };

    _houses.AddRange(houses);
    UpdateList();

    lbl_result.Text = $"Добавлено объектов: {houses.Count}";
  }

  private void btn_binary_search_Click(object sender, EventArgs e) {
    if (!TryCreateHouse(out IHouse house)) {
      return;
    }

    if (_houses.Count == 0) {
      lbl_result.Text = "Список пуст.";
      return;
    }

    int index = _houses.BinarySearch(house);

    if (index >= 0) {
      lbl_result.Text = $"Объект найден. Индекс: {index}";
    }
    else {
      lbl_result.Text = "Объект не найден.";
    }
  }

  private void btn_index_of_Click(object sender, EventArgs e) {
    if (!TryCreateHouse(out IHouse house)) {
      return;
    }

    int index = _houses.IndexOf(house);

    if (index >= 0) {
      lbl_result.Text = $"Первое вхождение. Индекс: {index}";
    }
    else {
      lbl_result.Text = "Объект не найден.";
    }
  }

  private void btn_insert_Click(object sender, EventArgs e) {
    if (!int.TryParse(text_index.Text, out int index)) {
      lbl_result.Text = "Введите корректный индекс.";
      return;
    }

    if (index < 0 || index > _houses.Count) {
      lbl_result.Text = "Индекс находится за пределами списка.";
      return;
    }

    if (!TryCreateHouse(out IHouse house)) {
      return;
    }

    _houses.Insert(index, house);
    UpdateList();
    ClearInputs();

    lbl_result.Text = $"Объект вставлен на позицию {index}.";
  }

  private void btn_remove_Click(object sender, EventArgs e) {
    if (!TryCreateHouse(out IHouse house)) {
      return;
    }

    bool result = _houses.Remove(house);

    if (result) {
      UpdateList();
      lbl_result.Text = "Объект удалён.";
    }
    else {
      lbl_result.Text = "Объект не найден.";
    }
  }

  private void btn_remove_at_Click(object sender, EventArgs e) {
    if (!int.TryParse(text_index.Text, out int index)) {
      lbl_result.Text = "Введите корректный индекс.";
      return;
    }

    if (index < 0 || index >= _houses.Count) {
      lbl_result.Text = "Индекс находится за пределами списка.";
      return;
    }

    _houses.RemoveAt(index);
    UpdateList();

    text_index.Clear();
    lbl_result.Text = $"Объект с индексом {index} удалён.";
  }

  private void btn_sort_Click(object sender, EventArgs e) {
    _houses.Sort();
    UpdateList();

    lbl_result.Text = "Список отсортирован по площади.";
  }

  private void btn_clear_Click(object sender, EventArgs e) {
    _houses.Clear();
    UpdateList();

    lbl_result.Text = "Список очищен.";
  }

  private void combo_type_SelectedIndexChanged(object sender, EventArgs e) {
    switch (combo_type.SelectedIndex) {
      case 0:
        lbl_extra.Text = "Количество квартир:";
        text_extra.Visible = true;
        check_extra.Visible = false;
        break;

      case 1:
        lbl_extra.Text = "Гараж:";
        text_extra.Visible = false;
        check_extra.Visible = true;
        break;

      case 2:
        lbl_extra.Text = "Количество секций:";
        text_extra.Visible = true;
        check_extra.Visible = false;
        break;
    }
  }

  private void ClearInputs() {
    text_address.Clear();
    text_area.Clear();
    text_floors.Clear();
    text_extra.Clear();
    text_index.Clear();
    check_extra.Checked = false;
  }

  private void text_number_KeyPress(object sender, KeyPressEventArgs e) {
    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
      e.Handled = true;
    }
  }

  private void text_index_KeyPress(object sender, KeyPressEventArgs e) {
    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
      e.Handled = true;
    }
  }
}
}