using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain;
using Domain.Abstractions.Interfaces;

namespace WinUi.Pages {
public partial class Task3Page : UserControl {
  private readonly Stack<IHouse> _stack = new Stack<IHouse>();

  public Task3Page() {
    InitializeComponent();
  }

  private void Task3Page_Load(object sender, EventArgs e) {
    UpdateStack();
  }

  private void UpdateStack() {
    list_items.Items.Clear();

    foreach (IHouse house in _stack) {
      list_items.Items.Add(house.DisplayInfo());
    }

    lbl_count.Text = $"Количество: {_stack.Count}";
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

  private void btn_push_Click(object sender, EventArgs e) {
    if (!TryCreateHouse(out IHouse house)) {
      return;
    }

    _stack.Push(house);

    UpdateStack();
    ClearInputs();

    lbl_result.Text = "Объект добавлен в стек.";
  }

  private void btn_pop_Click(object sender, EventArgs e) {
    if (_stack.Count == 0) {
      lbl_result.Text = "Стек пуст.";
      return;
    }

    IHouse house = _stack.Pop();

    UpdateStack();

    lbl_result.Text =
      $"Извлечён: {house.DisplayInfo()}";
  }

  private void btn_peek_Click(object sender, EventArgs e) {
    if (_stack.Count == 0) {
      lbl_result.Text = "Стек пуст.";
      return;
    }

    IHouse house = _stack.Peek();

    lbl_result.Text =
      $"Верхний элемент: {house.DisplayInfo()}";
  }

  private void btn_add_range_Click(object sender, EventArgs e) {
    IHouse apartmentBuilding = new ApartmentBuilding {
      Address = "ул. Ленина, 10",
      Area = 1200,
      Floors = 9,
      Apartments = 72
    };

    IHouse privateHouse = new PrivateHouse {
      Address = "ул. Центральная, 15",
      Area = 180,
      Floors = 2,
      HasGarage = true
    };

    IHouse townHouse = new TownHouse {
      Address = "ул. Садовая, 25",
      Area = 250,
      Floors = 2,
      Sections = 4
    };

    _stack.Push(apartmentBuilding);
    _stack.Push(privateHouse);
    _stack.Push(townHouse);

    UpdateStack();

    lbl_result.Text = "Добавлено 3 объекта в стек.";
  }

  private void btn_clear_Click(object sender, EventArgs e) {
    _stack.Clear();

    UpdateStack();

    lbl_result.Text = "Стек очищен.";
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
    check_extra.Checked = false;
  }

  private void text_number_KeyPress(
    object sender,
    KeyPressEventArgs e) {

    if (!char.IsControl(e.KeyChar) &&
        !char.IsDigit(e.KeyChar)) {
      e.Handled = true;
    }
  }
}
}