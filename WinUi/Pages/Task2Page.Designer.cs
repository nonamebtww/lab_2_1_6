namespace WinUi.Pages {
partial class Task2Page {
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

  private System.Windows.Forms.Label lbl_index;
  private System.Windows.Forms.TextBox text_index;

  private System.Windows.Forms.FlowLayoutPanel buttons;

  private System.Windows.Forms.Button btn_add;
  private System.Windows.Forms.Button btn_add_range;
  private System.Windows.Forms.Button btn_binary_search;
  private System.Windows.Forms.Button btn_index_of;
  private System.Windows.Forms.Button btn_insert;
  private System.Windows.Forms.Button btn_remove;
  private System.Windows.Forms.Button btn_remove_at;
  private System.Windows.Forms.Button btn_sort;
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
    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task2Page));
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
    this.lbl_index = new System.Windows.Forms.Label();
    this.text_index = new System.Windows.Forms.TextBox();
    this.buttons = new System.Windows.Forms.FlowLayoutPanel();
    this.btn_add = new System.Windows.Forms.Button();
    this.btn_add_range = new System.Windows.Forms.Button();
    this.btn_binary_search = new System.Windows.Forms.Button();
    this.btn_index_of = new System.Windows.Forms.Button();
    this.btn_insert = new System.Windows.Forms.Button();
    this.btn_remove = new System.Windows.Forms.Button();
    this.btn_remove_at = new System.Windows.Forms.Button();
    this.btn_sort = new System.Windows.Forms.Button();
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
    this.body.Controls.Add(this.lbl_index, 0, 7);
    this.body.Controls.Add(this.text_index, 1, 7);
    this.body.Controls.Add(this.buttons, 0, 8);
    this.body.Controls.Add(this.lbl_count, 0, 9);
    this.body.Controls.Add(this.lbl_result_title, 0, 10);
    this.body.Controls.Add(this.lbl_result, 1, 10);
    this.body.Controls.Add(this.list_items, 0, 11);
    this.body.Dock = System.Windows.Forms.DockStyle.Fill;
    this.body.Location = new System.Drawing.Point(0, 0);
    this.body.Name = "body";
    this.body.Padding = new System.Windows.Forms.Padding(15);
    this.body.RowCount = 12;
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
    this.body.Size = new System.Drawing.Size(855, 599);
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
    this.lbl_title.Size = new System.Drawing.Size(819, 90);
    this.lbl_title.TabIndex = 0;
    this.lbl_title.Text = resources.GetString("lbl_title.Text");
    // 
    // lbl_type
    // 
    this.lbl_type.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_type.AutoSize = true;
    this.lbl_type.Location = new System.Drawing.Point(18, 109);
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
    this.combo_type.Size = new System.Drawing.Size(639, 21);
    this.combo_type.TabIndex = 3;
    this.combo_type.SelectedIndexChanged += new System.EventHandler(this.combo_type_SelectedIndexChanged);
    // 
    // lbl_address
    // 
    this.lbl_address.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_address.AutoSize = true;
    this.lbl_address.Location = new System.Drawing.Point(18, 131);
    this.lbl_address.Name = "lbl_address";
    this.lbl_address.Size = new System.Drawing.Size(41, 13);
    this.lbl_address.TabIndex = 4;
    this.lbl_address.Text = "Адрес:";
    // 
    // text_address
    // 
    this.text_address.Dock = System.Windows.Forms.DockStyle.Fill;
    this.text_address.Location = new System.Drawing.Point(198, 130);
    this.text_address.Name = "text_address";
    this.text_address.Size = new System.Drawing.Size(639, 20);
    this.text_address.TabIndex = 5;
    // 
    // lbl_area
    // 
    this.lbl_area.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_area.AutoSize = true;
    this.lbl_area.Location = new System.Drawing.Point(18, 153);
    this.lbl_area.Name = "lbl_area";
    this.lbl_area.Size = new System.Drawing.Size(57, 13);
    this.lbl_area.TabIndex = 6;
    this.lbl_area.Text = "Площадь:";
    // 
    // text_area
    // 
    this.text_area.Dock = System.Windows.Forms.DockStyle.Fill;
    this.text_area.Location = new System.Drawing.Point(198, 152);
    this.text_area.Name = "text_area";
    this.text_area.Size = new System.Drawing.Size(639, 20);
    this.text_area.TabIndex = 7;
    this.text_area.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_number_KeyPress);
    // 
    // lbl_floors
    // 
    this.lbl_floors.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_floors.AutoSize = true;
    this.lbl_floors.Location = new System.Drawing.Point(18, 175);
    this.lbl_floors.Name = "lbl_floors";
    this.lbl_floors.Size = new System.Drawing.Size(48, 13);
    this.lbl_floors.TabIndex = 8;
    this.lbl_floors.Text = "Этажей:";
    // 
    // text_floors
    // 
    this.text_floors.Dock = System.Windows.Forms.DockStyle.Fill;
    this.text_floors.Location = new System.Drawing.Point(198, 174);
    this.text_floors.Name = "text_floors";
    this.text_floors.Size = new System.Drawing.Size(639, 20);
    this.text_floors.TabIndex = 9;
    this.text_floors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_number_KeyPress);
    // 
    // lbl_extra
    // 
    this.lbl_extra.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_extra.AutoSize = true;
    this.lbl_extra.Location = new System.Drawing.Point(18, 197);
    this.lbl_extra.Name = "lbl_extra";
    this.lbl_extra.Size = new System.Drawing.Size(90, 13);
    this.lbl_extra.TabIndex = 10;
    this.lbl_extra.Text = "Дополнительно:";
    // 
    // text_extra
    // 
    this.text_extra.Dock = System.Windows.Forms.DockStyle.Fill;
    this.text_extra.Location = new System.Drawing.Point(18, 218);
    this.text_extra.Name = "text_extra";
    this.text_extra.Size = new System.Drawing.Size(174, 20);
    this.text_extra.TabIndex = 11;
    this.text_extra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_number_KeyPress);
    // 
    // check_extra
    // 
    this.check_extra.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.check_extra.AutoSize = true;
    this.check_extra.Location = new System.Drawing.Point(198, 196);
    this.check_extra.Name = "check_extra";
    this.check_extra.Size = new System.Drawing.Size(84, 16);
    this.check_extra.TabIndex = 12;
    this.check_extra.Text = "Есть гараж";
    this.check_extra.Visible = false;
    // 
    // lbl_index
    // 
    this.lbl_index.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_index.AutoSize = true;
    this.lbl_index.Location = new System.Drawing.Point(198, 219);
    this.lbl_index.Name = "lbl_index";
    this.lbl_index.Size = new System.Drawing.Size(48, 13);
    this.lbl_index.TabIndex = 13;
    this.lbl_index.Text = "Индекс:";
    // 
    // text_index
    // 
    this.text_index.Dock = System.Windows.Forms.DockStyle.Fill;
    this.text_index.Location = new System.Drawing.Point(18, 240);
    this.text_index.Name = "text_index";
    this.text_index.Size = new System.Drawing.Size(174, 20);
    this.text_index.TabIndex = 14;
    this.text_index.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_index_KeyPress);
    // 
    // buttons
    // 
    this.buttons.AutoScroll = true;
    this.body.SetColumnSpan(this.buttons, 2);
    this.buttons.Controls.Add(this.btn_add);
    this.buttons.Controls.Add(this.btn_add_range);
    this.buttons.Controls.Add(this.btn_binary_search);
    this.buttons.Controls.Add(this.btn_index_of);
    this.buttons.Controls.Add(this.btn_insert);
    this.buttons.Controls.Add(this.btn_remove);
    this.buttons.Controls.Add(this.btn_remove_at);
    this.buttons.Controls.Add(this.btn_sort);
    this.buttons.Controls.Add(this.btn_clear);
    this.buttons.Dock = System.Windows.Forms.DockStyle.Fill;
    this.buttons.Location = new System.Drawing.Point(18, 262);
    this.buttons.Name = "buttons";
    this.buttons.Size = new System.Drawing.Size(819, 62);
    this.buttons.TabIndex = 15;
    // 
    // btn_add
    // 
    this.btn_add.AutoSize = true;
    this.btn_add.Location = new System.Drawing.Point(3, 3);
    this.btn_add.Name = "btn_add";
    this.btn_add.Size = new System.Drawing.Size(75, 23);
    this.btn_add.TabIndex = 0;
    this.btn_add.Text = "Add";
    this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
    // 
    // btn_add_range
    // 
    this.btn_add_range.AutoSize = true;
    this.btn_add_range.Location = new System.Drawing.Point(84, 3);
    this.btn_add_range.Name = "btn_add_range";
    this.btn_add_range.Size = new System.Drawing.Size(75, 23);
    this.btn_add_range.TabIndex = 1;
    this.btn_add_range.Text = "AddRange";
    this.btn_add_range.Click += new System.EventHandler(this.btn_add_range_Click);
    // 
    // btn_binary_search
    // 
    this.btn_binary_search.AutoSize = true;
    this.btn_binary_search.Location = new System.Drawing.Point(165, 3);
    this.btn_binary_search.Name = "btn_binary_search";
    this.btn_binary_search.Size = new System.Drawing.Size(80, 23);
    this.btn_binary_search.TabIndex = 2;
    this.btn_binary_search.Text = "BinarySearch";
    this.btn_binary_search.Click += new System.EventHandler(this.btn_binary_search_Click);
    // 
    // btn_index_of
    // 
    this.btn_index_of.AutoSize = true;
    this.btn_index_of.Location = new System.Drawing.Point(251, 3);
    this.btn_index_of.Name = "btn_index_of";
    this.btn_index_of.Size = new System.Drawing.Size(75, 23);
    this.btn_index_of.TabIndex = 3;
    this.btn_index_of.Text = "IndexOf";
    this.btn_index_of.Click += new System.EventHandler(this.btn_index_of_Click);
    // 
    // btn_insert
    // 
    this.btn_insert.AutoSize = true;
    this.btn_insert.Location = new System.Drawing.Point(332, 3);
    this.btn_insert.Name = "btn_insert";
    this.btn_insert.Size = new System.Drawing.Size(75, 23);
    this.btn_insert.TabIndex = 4;
    this.btn_insert.Text = "Insert";
    this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
    // 
    // btn_remove
    // 
    this.btn_remove.AutoSize = true;
    this.btn_remove.Location = new System.Drawing.Point(413, 3);
    this.btn_remove.Name = "btn_remove";
    this.btn_remove.Size = new System.Drawing.Size(75, 23);
    this.btn_remove.TabIndex = 5;
    this.btn_remove.Text = "Remove";
    this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
    // 
    // btn_remove_at
    // 
    this.btn_remove_at.AutoSize = true;
    this.btn_remove_at.Location = new System.Drawing.Point(494, 3);
    this.btn_remove_at.Name = "btn_remove_at";
    this.btn_remove_at.Size = new System.Drawing.Size(75, 23);
    this.btn_remove_at.TabIndex = 6;
    this.btn_remove_at.Text = "RemoveAt";
    this.btn_remove_at.Click += new System.EventHandler(this.btn_remove_at_Click);
    // 
    // btn_sort
    // 
    this.btn_sort.AutoSize = true;
    this.btn_sort.Location = new System.Drawing.Point(575, 3);
    this.btn_sort.Name = "btn_sort";
    this.btn_sort.Size = new System.Drawing.Size(75, 23);
    this.btn_sort.TabIndex = 7;
    this.btn_sort.Text = "Sort";
    this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
    // 
    // btn_clear
    // 
    this.btn_clear.AutoSize = true;
    this.btn_clear.Location = new System.Drawing.Point(656, 3);
    this.btn_clear.Name = "btn_clear";
    this.btn_clear.Size = new System.Drawing.Size(75, 23);
    this.btn_clear.TabIndex = 8;
    this.btn_clear.Text = "Clear";
    this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
    // 
    // lbl_count
    // 
    this.lbl_count.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_count.AutoSize = true;
    this.body.SetColumnSpan(this.lbl_count, 2);
    this.lbl_count.Location = new System.Drawing.Point(18, 354);
    this.lbl_count.Name = "lbl_count";
    this.lbl_count.Size = new System.Drawing.Size(78, 13);
    this.lbl_count.TabIndex = 16;
    this.lbl_count.Text = "Количество: 0";
    // 
    // lbl_result_title
    // 
    this.lbl_result_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_result_title.AutoSize = true;
    this.lbl_result_title.Location = new System.Drawing.Point(18, 434);
    this.lbl_result_title.Name = "lbl_result_title";
    this.lbl_result_title.Size = new System.Drawing.Size(62, 13);
    this.lbl_result_title.TabIndex = 17;
    this.lbl_result_title.Text = "Результат:";
    // 
    // lbl_result
    // 
    this.lbl_result.Anchor = System.Windows.Forms.AnchorStyles.Left;
    this.lbl_result.AutoSize = true;
    this.lbl_result.Location = new System.Drawing.Point(198, 434);
    this.lbl_result.Name = "lbl_result";
    this.lbl_result.Size = new System.Drawing.Size(45, 13);
    this.lbl_result.TabIndex = 18;
    this.lbl_result.Text = "Готово.";
    // 
    // list_items
    // 
    this.body.SetColumnSpan(this.list_items, 2);
    this.list_items.Dock = System.Windows.Forms.DockStyle.Fill;
    this.list_items.HorizontalScrollbar = true;
    this.list_items.Location = new System.Drawing.Point(18, 489);
    this.list_items.Name = "list_items";
    this.list_items.Size = new System.Drawing.Size(819, 92);
    this.list_items.TabIndex = 19;
    // 
    // Task2Page
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.Controls.Add(this.body);
    this.Name = "Task2Page";
    this.Size = new System.Drawing.Size(855, 599);
    this.Load += new System.EventHandler(this.Task2Page_Load);
    this.body.ResumeLayout(false);
    this.body.PerformLayout();
    this.buttons.ResumeLayout(false);
    this.buttons.PerformLayout();
    this.ResumeLayout(false);
  }
}
}