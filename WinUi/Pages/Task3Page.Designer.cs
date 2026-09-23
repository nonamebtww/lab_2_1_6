namespace WinUi.Pages {
partial class Task3Page {
  private System.ComponentModel.IContainer components = null;

  private System.Windows.Forms.TableLayoutPanel body;

  private System.Windows.Forms.Label lbl_title;

  private System.Windows.Forms.Label lbl_type;
  private System.Windows.Forms.ComboBox combo_type;

  private System.Windows.Forms.Label lbl_address;
  private System.Windows.Forms.TextBox text_address;

  private System.Windows.Forms.Label lbl_area;
  private System.Windows.Forms.TextBox text_area;

  private System.Windows.Forms.Label lbl_floors;
  private System.Windows.Forms.TextBox text_floors;

  private System.Windows.Forms.Label lbl_extra;
  private System.Windows.Forms.TextBox text_extra;
  private System.Windows.Forms.CheckBox check_extra;

  private System.Windows.Forms.FlowLayoutPanel buttons;

  private System.Windows.Forms.Button btn_push;
  private System.Windows.Forms.Button btn_pop;
  private System.Windows.Forms.Button btn_peek;
  private System.Windows.Forms.Button btn_add_range;
  private System.Windows.Forms.Button btn_clear;

  private System.Windows.Forms.ListBox list_items;

  private System.Windows.Forms.Label lbl_count;
  private System.Windows.Forms.Label lbl_result_title;
  private System.Windows.Forms.Label lbl_result;

  protected override void Dispose(bool disposing) {
    if (disposing && (components != null)) {
      components.Dispose();
    }

    base.Dispose(disposing);
  }

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent() {
    this.body = new System.Windows.Forms.TableLayoutPanel();
    this.lbl_title = new System.Windows.Forms.Label();
    this.lbl_type = new System.Windows.Forms.Label();
    this.combo_type = new System.Windows.Forms.ComboBox();
    this.lbl_address = new System.Windows.Forms.Label();
    this.text_address = new System.Windows.Forms.TextBox();
    this.lbl_area = new System.Windows.Forms.Label();
    this.text_area = new System.Windows.Forms.TextBox();
    this.lbl_floors = new System.Windows.Forms.Label();
    this.text_floors = new System.Windows.Forms.TextBox();
    this.lbl_extra = new System.Windows.Forms.Label();
    this.text_extra = new System.Windows.Forms.TextBox();
    this.check_extra = new System.Windows.Forms.CheckBox();
    this.buttons = new System.Windows.Forms.FlowLayoutPanel();
    this.btn_push = new System.Windows.Forms.Button();
    this.btn_pop = new System.Windows.Forms.Button();
    this.btn_peek = new System.Windows.Forms.Button();
    this.btn_add_range = new System.Windows.Forms.Button();
    this.btn_clear = new System.Windows.Forms.Button();
    this.lbl_count = new System.Windows.Forms.Label();
    this.lbl_result_title = new System.Windows.Forms.Label();
    this.lbl_result = new System.Windows.Forms.Label();
    this.list_items = new System.Windows.Forms.ListBox();
    this.body.SuspendLayout();
    this.buttons.SuspendLayout();
    this.SuspendLayout();
    // 
    // body
    // 
    this.body.ColumnCount = 2;
    this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
    this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
    this.body.Controls.Add(this.lbl_title, 0, 0);
    this.body.Controls.Add(this.lbl_type, 0, 2);
    this.body.Controls.Add(this.combo_type, 1, 2);
    this.body.Controls.Add(this.lbl_address, 0, 3);
    this.body.Controls.Add(this.text_address, 1, 3);
    this.body.Controls.Add(this.lbl_area, 0, 4);
    this.body.Controls.Add(this.text_area, 1, 4);
    this.body.Controls.Add(this.lbl_floors, 0, 5);
    this.body.Controls.Add(this.text_floors, 1, 5);
    this.body.Controls.Add(this.lbl_extra, 0, 6);
    this.body.Controls.Add(this.text_extra, 1, 6);
    this.body.Controls.Add(this.check_extra, 1, 6);
    this.body.Controls.Add(this.buttons, 0, 7);
    this.body.Controls.Add(this.lbl_count, 0, 8);
    this.body.Controls.Add(this.lbl_result_title, 0, 9);
    this.body.Controls.Add(this.lbl_result, 1, 9);
    this.body.Controls.Add(this.list_items, 0, 10);
    this.body.Dock = System.Windows.Forms.DockStyle.Fill;
    this.body.Location = new System.Drawing.Point(0, 0);
    this.body.Name = "body";
    this.body.Padding = new System.Windows.Forms.Padding(15);
    this.body.RowCount = 10;
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
    this.body.Size = new System.Drawing.Size(820, 594);
    this.body.TabIndex = 0;
    // 
    // lbl_title
    // 
    this.lbl_title.AutoSize = true;
    this.body.SetColumnSpan(this.lbl_title, 2);
    this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
    this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.lbl_title.Location = new System.Drawing.Point(18, 15);
    this.lbl_title.Name = "lbl_title";
    this.body.SetRowSpan(this.lbl_title, 2);
    this.lbl_title.Size = new System.Drawing.Size(784, 90);
    this.lbl_title.TabIndex = 0;
    this.lbl_title.Text = "Создать приложение, демонстрирующее функции ввода-вывода заданой коле-\r\nекции в с" + "оответствии с вариантом.\r\n\r\nStack\r\n\r\nОсновные данные ввода-вывода берутся в соот" + "ветствии с вариантом из зада-\r\nния 2";
    // 
    // lbl_type
    // 
    this.lbl_type.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_type.AutoSize = true;
    this.lbl_type.Location = new System.Drawing.Point(18, 110);
    this.lbl_type.Name = "lbl_type";
    this.lbl_type.Size = new System.Drawing.Size(58, 13);
    this.lbl_type.TabIndex = 2;
    this.lbl_type.Text = "Тип дома:";
    // 
    // combo_type
    // 
    this.combo_type.Dock = System.Windows.Forms.DockStyle.Fill;
    this.combo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    this.combo_type.Items.AddRange(new object[] {
      "Многоквартирный дом", "Частный дом", "Таунхаус"
    });
    this.combo_type.Location = new System.Drawing.Point(198, 108);
    this.combo_type.Name = "combo_type";
    this.combo_type.Size = new System.Drawing.Size(604, 21);
    this.combo_type.TabIndex = 3;
    this.combo_type.SelectedIndexChanged += new System.EventHandler(this.combo_type_SelectedIndexChanged);
    // 
    // lbl_address
    // 
    this.lbl_address.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_address.AutoSize = true;
    this.lbl_address.Location = new System.Drawing.Point(18, 133);
    this.lbl_address.Name = "lbl_address";
    this.lbl_address.Size = new System.Drawing.Size(41, 13);
    this.lbl_address.TabIndex = 4;
    this.lbl_address.Text = "Адрес:";
    // 
    // text_address
    // 
    this.text_address.Dock = System.Windows.Forms.DockStyle.Fill;
    this.text_address.Location = new System.Drawing.Point(198, 131);
    this.text_address.Name = "text_address";
    this.text_address.Size = new System.Drawing.Size(604, 20);
    this.text_address.TabIndex = 5;
    // 
    // lbl_area
    // 
    this.lbl_area.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_area.AutoSize = true;
    this.lbl_area.Location = new System.Drawing.Point(18, 156);
    this.lbl_area.Name = "lbl_area";
    this.lbl_area.Size = new System.Drawing.Size(57, 13);
    this.lbl_area.TabIndex = 6;
    this.lbl_area.Text = "Площадь:";
    // 
    // text_area
    // 
    this.text_area.Dock = System.Windows.Forms.DockStyle.Fill;
    this.text_area.Location = new System.Drawing.Point(198, 154);
    this.text_area.Name = "text_area";
    this.text_area.Size = new System.Drawing.Size(604, 20);
    this.text_area.TabIndex = 7;
    this.text_area.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_number_KeyPress);
    // 
    // lbl_floors
    // 
    this.lbl_floors.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_floors.AutoSize = true;
    this.lbl_floors.Location = new System.Drawing.Point(18, 179);
    this.lbl_floors.Name = "lbl_floors";
    this.lbl_floors.Size = new System.Drawing.Size(48, 13);
    this.lbl_floors.TabIndex = 8;
    this.lbl_floors.Text = "Этажей:";
    // 
    // text_floors
    // 
    this.text_floors.Dock = System.Windows.Forms.DockStyle.Fill;
    this.text_floors.Location = new System.Drawing.Point(198, 177);
    this.text_floors.Name = "text_floors";
    this.text_floors.Size = new System.Drawing.Size(604, 20);
    this.text_floors.TabIndex = 9;
    this.text_floors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_number_KeyPress);
    // 
    // lbl_extra
    // 
    this.lbl_extra.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_extra.AutoSize = true;
    this.lbl_extra.Location = new System.Drawing.Point(18, 202);
    this.lbl_extra.Name = "lbl_extra";
    this.lbl_extra.Size = new System.Drawing.Size(90, 13);
    this.lbl_extra.TabIndex = 10;
    this.lbl_extra.Text = "Дополнительно:";
    // 
    // text_extra
    // 
    this.text_extra.Dock = System.Windows.Forms.DockStyle.Fill;
    this.text_extra.Location = new System.Drawing.Point(18, 223);
    this.text_extra.Name = "text_extra";
    this.text_extra.Size = new System.Drawing.Size(174, 20);
    this.text_extra.TabIndex = 11;
    this.text_extra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_number_KeyPress);
    // 
    // check_extra
    // 
    this.check_extra.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.check_extra.AutoSize = true;
    this.check_extra.Location = new System.Drawing.Point(198, 200);
    this.check_extra.Name = "check_extra";
    this.check_extra.Size = new System.Drawing.Size(84, 17);
    this.check_extra.TabIndex = 12;
    this.check_extra.Text = "Есть гараж";
    this.check_extra.Visible = false;
    // 
    // buttons
    // 
    this.buttons.AutoScroll = true;
    this.body.SetColumnSpan(this.buttons, 2);
    this.buttons.Controls.Add(this.btn_push);
    this.buttons.Controls.Add(this.btn_pop);
    this.buttons.Controls.Add(this.btn_peek);
    this.buttons.Controls.Add(this.btn_add_range);
    this.buttons.Controls.Add(this.btn_clear);
    this.buttons.Dock = System.Windows.Forms.DockStyle.Fill;
    this.buttons.Location = new System.Drawing.Point(18, 246);
    this.buttons.Name = "buttons";
    this.buttons.Size = new System.Drawing.Size(784, 65);
    this.buttons.TabIndex = 13;
    // 
    // btn_push
    // 
    this.btn_push.AutoSize = true;
    this.btn_push.Location = new System.Drawing.Point(3, 3);
    this.btn_push.Name = "btn_push";
    this.btn_push.Size = new System.Drawing.Size(75, 23);
    this.btn_push.TabIndex = 0;
    this.btn_push.Text = "Push";
    this.btn_push.Click += new System.EventHandler(this.btn_push_Click);
    // 
    // btn_pop
    // 
    this.btn_pop.AutoSize = true;
    this.btn_pop.Location = new System.Drawing.Point(84, 3);
    this.btn_pop.Name = "btn_pop";
    this.btn_pop.Size = new System.Drawing.Size(75, 23);
    this.btn_pop.TabIndex = 1;
    this.btn_pop.Text = "Pop";
    this.btn_pop.Click += new System.EventHandler(this.btn_pop_Click);
    // 
    // btn_peek
    // 
    this.btn_peek.AutoSize = true;
    this.btn_peek.Location = new System.Drawing.Point(165, 3);
    this.btn_peek.Name = "btn_peek";
    this.btn_peek.Size = new System.Drawing.Size(75, 23);
    this.btn_peek.TabIndex = 2;
    this.btn_peek.Text = "Peek";
    this.btn_peek.Click += new System.EventHandler(this.btn_peek_Click);
    // 
    // btn_add_range
    // 
    this.btn_add_range.AutoSize = true;
    this.btn_add_range.Location = new System.Drawing.Point(246, 3);
    this.btn_add_range.Name = "btn_add_range";
    this.btn_add_range.Size = new System.Drawing.Size(121, 23);
    this.btn_add_range.TabIndex = 3;
    this.btn_add_range.Text = "Добавить 3 объекта";
    this.btn_add_range.Click += new System.EventHandler(this.btn_add_range_Click);
    // 
    // btn_clear
    // 
    this.btn_clear.AutoSize = true;
    this.btn_clear.Location = new System.Drawing.Point(373, 3);
    this.btn_clear.Name = "btn_clear";
    this.btn_clear.Size = new System.Drawing.Size(75, 23);
    this.btn_clear.TabIndex = 4;
    this.btn_clear.Text = "Clear";
    this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
    // 
    // lbl_count
    // 
    this.lbl_count.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_count.AutoSize = true;
    this.body.SetColumnSpan(this.lbl_count, 2);
    this.lbl_count.Location = new System.Drawing.Point(18, 343);
    this.lbl_count.Name = "lbl_count";
    this.lbl_count.Size = new System.Drawing.Size(78, 13);
    this.lbl_count.TabIndex = 14;
    this.lbl_count.Text = "Количество: 0";
    // 
    // lbl_result_title
    // 
    this.lbl_result_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_result_title.AutoSize = true;
    this.lbl_result_title.Location = new System.Drawing.Point(18, 425);
    this.lbl_result_title.Name = "lbl_result_title";
    this.lbl_result_title.Size = new System.Drawing.Size(62, 13);
    this.lbl_result_title.TabIndex = 15;
    this.lbl_result_title.Text = "Результат:";
    // 
    // lbl_result
    // 
    this.lbl_result.Location = new System.Drawing.Point(198, 385);
    this.lbl_result.Name = "lbl_result";
    this.lbl_result.Size = new System.Drawing.Size(100, 23);
    this.lbl_result.TabIndex = 16;
    // 
    // list_items
    // 
    this.body.SetColumnSpan(this.list_items, 2);
    this.list_items.Dock = System.Windows.Forms.DockStyle.Fill;
    this.list_items.Location = new System.Drawing.Point(18, 482);
    this.list_items.Name = "list_items";
    this.list_items.Size = new System.Drawing.Size(784, 94);
    this.list_items.TabIndex = 17;
    // 
    // Task3Page
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.Controls.Add(this.body);
    this.Name = "Task3Page";
    this.Size = new System.Drawing.Size(820, 594);
    this.Load += new System.EventHandler(this.Task3Page_Load);
    this.body.ResumeLayout(false);
    this.body.PerformLayout();
    this.buttons.ResumeLayout(false);
    this.buttons.PerformLayout();
    this.ResumeLayout(false);
  }
}
}