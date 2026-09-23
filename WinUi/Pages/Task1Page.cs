using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinUi.Pages {
public partial class Task1Page : UserControl {
  private readonly List<int> _list = new List<int>();

  public Task1Page() {
    InitializeComponent();
  }

  private void Task1Page_Load(object sender, EventArgs e) {
    UpdateList();
  }

  private void UpdateList() {
    list_items.Items.Clear();

    foreach (int item in _list) {
      list_items.Items.Add(item);
    }

    lbl_count.Text = $"Количество: {_list.Count}";
  }

  private bool TryGetInt(out int value) {
    return int.TryParse(text_item.Text, out value);
  }

  private void btn_add_Click(object sender, EventArgs e) {
    if (!TryGetInt(out int item)) {
      lbl_result.Text = "Введите целое число.";
      return;
    }

    _list.Add(item);

    text_item.Clear();
    UpdateList();

    lbl_result.Text = "Элемент добавлен.";
  }

  private void btn_add_range_Click(object sender, EventArgs e) {
    if (string.IsNullOrWhiteSpace(text_item.Text)) {
      lbl_result.Text = "Введите элементы через пробел.";
      return;
    }

    string[] values = text_item.Text
      .Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

    List<int> items = new List<int>();

    foreach (string value in values) {
      if (!int.TryParse(value, out int item)) {
        lbl_result.Text = $"Некорректное значение: {value}";
        return;
      }

      items.Add(item);
    }

    _list.AddRange(items);

    text_item.Clear();
    UpdateList();

    lbl_result.Text = $"Добавлено элементов: {items.Count}";
  }

  private void btn_binary_search_Click(object sender, EventArgs e) {
    if (!TryGetInt(out int item)) {
      lbl_result.Text = "Введите целое число.";
      return;
    }

    if (_list.Count == 0) {
      lbl_result.Text = "Список пуст.";
      return;
    }

    int index = _list.BinarySearch(item);

    if (index >= 0) {
      lbl_result.Text = $"Элемент найден. Индекс: {index}";
    }
    else {
      lbl_result.Text = "Элемент не найден.";
    }
  }

  private void btn_index_of_Click(object sender, EventArgs e) {
    if (!TryGetInt(out int item)) {
      lbl_result.Text = "Введите целое число.";
      return;
    }

    int index = _list.IndexOf(item);

    if (index >= 0) {
      lbl_result.Text = $"Первое вхождение. Индекс: {index}";
    }
    else {
      lbl_result.Text = "Элемент не найден.";
    }
  }

  private void btn_insert_Click(object sender, EventArgs e) {
    if (!int.TryParse(text_index.Text, out int index)) {
      lbl_result.Text = "Введите корректный индекс.";
      return;
    }

    if (!TryGetInt(out int item)) {
      lbl_result.Text = "Введите целое число.";
      return;
    }

    if (index < 0 || index > _list.Count) {
      lbl_result.Text = "Индекс находится за пределами списка.";
      return;
    }

    _list.Insert(index, item);

    text_item.Clear();
    text_index.Clear();

    UpdateList();

    lbl_result.Text = $"Элемент вставлен на позицию {index}.";
  }

  private void btn_remove_Click(object sender, EventArgs e) {
    if (!TryGetInt(out int item)) {
      lbl_result.Text = "Введите целое число.";
      return;
    }

    bool result = _list.Remove(item);

    if (result) {
      lbl_result.Text = "Элемент удалён.";
      UpdateList();
    }
    else {
      lbl_result.Text = "Элемент не найден.";
    }
  }

  private void btn_remove_at_Click(object sender, EventArgs e) {
    if (!int.TryParse(text_index.Text, out int index)) {
      lbl_result.Text = "Введите корректный индекс.";
      return;
    }

    if (index < 0 || index >= _list.Count) {
      lbl_result.Text = "Индекс находится за пределами списка.";
      return;
    }

    _list.RemoveAt(index);

    text_index.Clear();

    UpdateList();

    lbl_result.Text = $"Элемент с индексом {index} удалён.";
  }

  private void btn_sort_Click(object sender, EventArgs e) {
    _list.Sort();

    UpdateList();

    lbl_result.Text = "Список отсортирован.";
  }

  private void btn_clear_Click(object sender, EventArgs e) {
    _list.Clear();

    UpdateList();

    lbl_result.Text = "Список очищен.";
  }

  private void text_item_KeyPress(object sender, KeyPressEventArgs e) {
    if (!char.IsControl(e.KeyChar) &&
        !char.IsDigit(e.KeyChar) &&
        e.KeyChar != '-') {
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