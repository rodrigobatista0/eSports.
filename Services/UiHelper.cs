using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSports.Services
{
    public static class UiHelper
    {
        public static void PrepareGrid(DataGridView grid)
        {
            grid.Columns.Clear();
            grid.Rows.Clear();
            grid.AutoGenerateColumns = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.RowHeadersVisible = false;
        }

        public static void AddColumn(DataGridView grid, string name, string header, int width)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = name;
            column.HeaderText = header;
            column.Width = width;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            grid.Columns.Add(column);
        }

        // ultima coluna: ocupa o espaco que sobra
        public static void AddFillColumn(DataGridView grid, string name, string header)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = name;
            column.HeaderText = header;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            grid.Columns.Add(column);
        }

        // Adiciona uma linha e guarda o objeto na Tag para depois sabermos qual foi escolhido
        public static void AddRow(DataGridView grid, object tag, params object[] values)
        {
            int index = grid.Rows.Add(values);
            grid.Rows[index].Tag = tag;
        }

        // Devolve o objeto da linha escolhida (ou null se nao houver nenhuma)
        public static object SelectedTag(DataGridView grid)
        {
            if (grid.SelectedRows.Count == 0)
                return null;

            return grid.SelectedRows[0].Tag;
        }

        public static void SetNumber(NumericUpDown box, int value)
        {
            decimal number = value;

            if (number < box.Minimum)
                number = box.Minimum;

            if (number > box.Maximum)
                number = box.Maximum;

            box.Value = number;
        }

        public static void SelectFirst(ComboBox combo)
        {
            if (combo.Items.Count > 0)
                combo.SelectedIndex = 0;
        }
    }
}