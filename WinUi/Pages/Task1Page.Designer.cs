using System.ComponentModel;

namespace WinUi.Pages {
partial class Task1Page {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing) {
    if (disposing && (components != null)) {
      components.Dispose();
    }

    base.Dispose(disposing);
  }

  #region Component Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent() {
    this.body = new System.Windows.Forms.TableLayoutPanel();
    this.lbl_task = new System.Windows.Forms.Label();
    this.lbl_item = new System.Windows.Forms.Label();
    this.text_item = new System.Windows.Forms.TextBox();
    this.lbl_index = new System.Windows.Forms.Label();
    this.text_index = new System.Windows.Forms.TextBox();
    this.btn_add = new System.Windows.Forms.Button();
    this.btn_add_range = new System.Windows.Forms.Button();
    this.btn_binary_search = new System.Windows.Forms.Button();
    this.btn_index_of = new System.Windows.Forms.Button();
    this.btn_insert = new System.Windows.Forms.Button();
    this.btn_remove = new System.Windows.Forms.Button();
    this.btn_remove_at = new System.Windows.Forms.Button();
    this.btn_sort = new System.Windows.Forms.Button();
    this.btn_clear = new System.Windows.Forms.Button();
    this.list_items = new System.Windows.Forms.ListBox();
    this.lbl_result_title = new System.Windows.Forms.Label();
    this.lbl_result = new System.Windows.Forms.Label();
    this.lbl_count = new System.Windows.Forms.Label();

    this.body.SuspendLayout();
    this.SuspendLayout();

    // 
    // body
    // 
    this.body.AutoSize = true;
    this.body.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.body.ColumnCount = 4;
    this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
    this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
    this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
    this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
    this.body.Controls.Add(this.lbl_task, 0, 0);
    this.body.Controls.Add(this.lbl_item, 0, 1);
    this.body.Controls.Add(this.text_item, 1, 1);
    this.body.Controls.Add(this.lbl_index, 2, 1);
    this.body.Controls.Add(this.text_index, 3, 1);
    this.body.Controls.Add(this.btn_add, 0, 2);
    this.body.Controls.Add(this.btn_add_range, 1, 2);
    this.body.Controls.Add(this.btn_binary_search, 2, 2);
    this.body.Controls.Add(this.btn_index_of, 3, 2);
    this.body.Controls.Add(this.btn_insert, 0, 3);
    this.body.Controls.Add(this.btn_remove, 1, 3);
    this.body.Controls.Add(this.btn_remove_at, 2, 3);
    this.body.Controls.Add(this.btn_sort, 3, 3);
    this.body.Controls.Add(this.btn_clear, 0, 4);
    this.body.Controls.Add(this.list_items, 1, 4);
    this.body.SetColumnSpan(this.list_items, 3);
    this.body.Controls.Add(this.lbl_count, 0, 5);
    this.body.Controls.Add(this.lbl_result_title, 1, 5);
    this.body.Controls.Add(this.lbl_result, 2, 5);
    this.body.SetColumnSpan(this.lbl_result, 2);
    this.body.Dock = System.Windows.Forms.DockStyle.Fill;
    this.body.Location = new System.Drawing.Point(0, 0);
    this.body.Name = "body";
    this.body.RowCount = 6;
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
    this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
    this.body.Size = new System.Drawing.Size(628, 360);
    this.body.TabIndex = 0;

    // 
    // lbl_task
    // 
    this.lbl_task.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.body.SetColumnSpan(this.lbl_task, 4);
    this.lbl_task.Location = new System.Drawing.Point(80, 7);
    this.lbl_task.Name = "lbl_task";
    this.lbl_task.Size = new System.Drawing.Size(468, 60);
    this.lbl_task.TabIndex = 0;
    this.lbl_task.Text = "Создать однородную коллекцию List<int> и реализовать основные методы работы с ней.";
    this.lbl_task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

    // 
    // lbl_item
    // 
    this.lbl_item.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_item.AutoSize = true;
    this.lbl_item.Location = new System.Drawing.Point(32, 94);
    this.lbl_item.Name = "lbl_item";
    this.lbl_item.Size = new System.Drawing.Size(92, 13);
    this.lbl_item.TabIndex = 1;
    this.lbl_item.Text = "Элемент";

    // 
    // text_item
    // 
    this.text_item.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_item.Location = new System.Drawing.Point(160, 90);
    this.text_item.Name = "text_item";
    this.text_item.Size = new System.Drawing.Size(151, 20);
    this.text_item.TabIndex = 2;
    this.text_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_item_KeyPress);

    // 
    // lbl_index
    // 
    this.lbl_index.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_index.AutoSize = true;
    this.lbl_index.Location = new System.Drawing.Point(344, 94);
    this.lbl_index.Name = "lbl_index";
    this.lbl_index.Size = new System.Drawing.Size(40, 13);
    this.lbl_index.TabIndex = 3;
    this.lbl_index.Text = "Индекс";

    // 
    // text_index
    // 
    this.text_index.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.text_index.Location = new System.Drawing.Point(475, 90);
    this.text_index.Name = "text_index";
    this.text_index.Size = new System.Drawing.Size(151, 20);
    this.text_index.TabIndex = 4;
    this.text_index.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_index_KeyPress);

    // 
    // btn_add
    // 
    this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.btn_add.Location = new System.Drawing.Point(10, 122);
    this.btn_add.Name = "btn_add";
    this.btn_add.Size = new System.Drawing.Size(135, 28);
    this.btn_add.TabIndex = 5;
    this.btn_add.Text = "Add";
    this.btn_add.UseVisualStyleBackColor = true;
    this.btn_add.Click += new System.EventHandler(this.btn_add_Click);

    // 
    // btn_add_range
    // 
    this.btn_add_range.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.btn_add_range.Location = new System.Drawing.Point(166, 122);
    this.btn_add_range.Name = "btn_add_range";
    this.btn_add_range.Size = new System.Drawing.Size(135, 28);
    this.btn_add_range.TabIndex = 6;
    this.btn_add_range.Text = "AddRange";
    this.btn_add_range.UseVisualStyleBackColor = true;
    this.btn_add_range.Click += new System.EventHandler(this.btn_add_range_Click);

    // 
    // btn_binary_search
    // 
    this.btn_binary_search.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.btn_binary_search.Location = new System.Drawing.Point(322, 122);
    this.btn_binary_search.Name = "btn_binary_search";
    this.btn_binary_search.Size = new System.Drawing.Size(135, 28);
    this.btn_binary_search.TabIndex = 7;
    this.btn_binary_search.Text = "BinarySearch";
    this.btn_binary_search.UseVisualStyleBackColor = true;
    this.btn_binary_search.Click += new System.EventHandler(this.btn_binary_search_Click);

    // 
    // btn_index_of
    // 
    this.btn_index_of.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.btn_index_of.Location = new System.Drawing.Point(478, 122);
    this.btn_index_of.Name = "btn_index_of";
    this.btn_index_of.Size = new System.Drawing.Size(135, 28);
    this.btn_index_of.TabIndex = 8;
    this.btn_index_of.Text = "IndexOf";
    this.btn_index_of.UseVisualStyleBackColor = true;
    this.btn_index_of.Click += new System.EventHandler(this.btn_index_of_Click);

    // 
    // btn_insert
    // 
    this.btn_insert.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.btn_insert.Location = new System.Drawing.Point(10, 162);
    this.btn_insert.Name = "btn_insert";
    this.btn_insert.Size = new System.Drawing.Size(135, 28);
    this.btn_insert.TabIndex = 9;
    this.btn_insert.Text = "Insert";
    this.btn_insert.UseVisualStyleBackColor = true;
    this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);

    // 
    // btn_remove
    // 
    this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.btn_remove.Location = new System.Drawing.Point(166, 162);
    this.btn_remove.Name = "btn_remove";
    this.btn_remove.Size = new System.Drawing.Size(135, 28);
    this.btn_remove.TabIndex = 10;
    this.btn_remove.Text = "Remove";
    this.btn_remove.UseVisualStyleBackColor = true;
    this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);

    // 
    // btn_remove_at
    // 
    this.btn_remove_at.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.btn_remove_at.Location = new System.Drawing.Point(322, 162);
    this.btn_remove_at.Name = "btn_remove_at";
    this.btn_remove_at.Size = new System.Drawing.Size(135, 28);
    this.btn_remove_at.TabIndex = 11;
    this.btn_remove_at.Text = "RemoveAt";
    this.btn_remove_at.UseVisualStyleBackColor = true;
    this.btn_remove_at.Click += new System.EventHandler(this.btn_remove_at_Click);

    // 
    // btn_sort
    // 
    this.btn_sort.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.btn_sort.Location = new System.Drawing.Point(478, 162);
    this.btn_sort.Name = "btn_sort";
    this.btn_sort.Size = new System.Drawing.Size(135, 28);
    this.btn_sort.TabIndex = 12;
    this.btn_sort.Text = "Sort";
    this.btn_sort.UseVisualStyleBackColor = true;
    this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);

    // 
    // btn_clear
    // 
    this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.btn_clear.Location = new System.Drawing.Point(10, 208);
    this.btn_clear.Name = "btn_clear";
    this.btn_clear.Size = new System.Drawing.Size(135, 28);
    this.btn_clear.TabIndex = 13;
    this.btn_clear.Text = "Очистить";
    this.btn_clear.UseVisualStyleBackColor = true;
    this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);

    // 
    // list_items
    // 
    this.list_items.Dock = System.Windows.Forms.DockStyle.Fill;
    this.list_items.FormattingEnabled = true;
    this.list_items.Location = new System.Drawing.Point(160, 195);
    this.list_items.Name = "list_items";
    this.list_items.Size = new System.Drawing.Size(465, 76);
    this.list_items.TabIndex = 14;

    // 
    // lbl_count
    // 
    this.lbl_count.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_count.AutoSize = true;
    this.lbl_count.Location = new System.Drawing.Point(34, 318);
    this.lbl_count.Name = "lbl_count";
    this.lbl_count.Size = new System.Drawing.Size(87, 13);
    this.lbl_count.TabIndex = 15;
    this.lbl_count.Text = "Количество: 0";

    // 
    // lbl_result_title
    // 
    this.lbl_result_title.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_result_title.AutoSize = true;
    this.lbl_result_title.Location = new System.Drawing.Point(191, 318);
    this.lbl_result_title.Name = "lbl_result_title";
    this.lbl_result_title.Size = new System.Drawing.Size(58, 13);
    this.lbl_result_title.TabIndex = 16;
    this.lbl_result_title.Text = "Результат";

    // 
    // lbl_result
    // 
    this.lbl_result.Anchor = System.Windows.Forms.AnchorStyles.None;
    this.lbl_result.AutoEllipsis = true;
    this.lbl_result.Location = new System.Drawing.Point(317, 304);
    this.lbl_result.Name = "lbl_result";
    this.lbl_result.Size = new System.Drawing.Size(308, 40);
    this.lbl_result.TabIndex = 17;
    this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

    // 
    // Task1Page
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.AutoSize = true;
    this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.Controls.Add(this.body);
    this.MinimumSize = new System.Drawing.Size(400, 225);
    this.Name = "Task1Page";
    this.Size = new System.Drawing.Size(628, 360);
    this.Load += new System.EventHandler(this.Task1Page_Load);

    this.body.ResumeLayout(false);
    this.body.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private System.Windows.Forms.TableLayoutPanel body;
  private System.Windows.Forms.Label lbl_task;
  private System.Windows.Forms.Label lbl_item;
  private System.Windows.Forms.TextBox text_item;
  private System.Windows.Forms.Label lbl_index;
  private System.Windows.Forms.TextBox text_index;
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

  #endregion
}
}