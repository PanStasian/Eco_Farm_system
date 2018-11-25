using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco_Farm_system
{
    public partial class Form1 : Form
    {
        private bool connect = false;
        DataGridViewRow row = new DataGridViewRow();

        public Form1()
        {
            InitializeComponent();
        }

        private void positionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.positionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ecoFarmDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ecoFarmDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.ecoFarmDataSet.Employees);
            // TODO: This line of code loads data into the 'ecoFarmDataSet.Position' table. You can move, or remove it, as needed.
            this.positionTableAdapter.Fill(this.ecoFarmDataSet.Position);

        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (connect)
            {
                connect = false;
            }
            else
            {
                connect = true;
                employeesDataGridView.DataSource = employeesBindingSource;
            }
           // if (connect == false)
           // {
           //     row = positionDataGridView.SelectedRows[0];
           //     employeesDataGridView.DataSource = ((DataRowView)positionDataGridView.SelectedRows[0].DataBoundItem).Row.GetChildRows("Position_Employees").CopyToDataTable();
           //     connect = true;
           // }
           // else
           //     if (positionDataGridView.SelectedRows[0] != row)
           //     {
           //         employeesDataGridView.DataSource = ((DataRowView)positionDataGridView.SelectedRows[0].DataBoundItem).Row.GetChildRows("Position_Employees").CopyToDataTable();
           //         row = positionDataGridView.SelectedRows[0];
           //     }
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
           employeesDataGridView.DataSource = employeesBindingSource;
           connect = false;
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveFirst();
            //employeesDataGridView.ClearSelection();
            //employeesDataGridView.CurrentCell = employeesDataGridView.Rows[0].Cells[0];
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveLast();
            //int last = employeesDataGridView.Rows.Count - 2;
            //employeesDataGridView.CurrentCell = employeesDataGridView.Rows[last].Cells[0];
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MovePrevious();
            //int last = employeesDataGridView.Rows.Count - 2;
            //int prvs = employeesDataGridView.CurrentRow.Index - 1;
            //if (prvs >= 0)
            //{
            //    employeesDataGridView.CurrentCell = employeesDataGridView.Rows[prvs].Cells[employeesDataGridView.CurrentCell.ColumnIndex];
            //}
            //if (prvs < 0)
            //{
            //    employeesDataGridView.CurrentCell = employeesDataGridView.Rows[last].Cells[0];
            //}
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveNext();
            //int next = employeesDataGridView.CurrentRow.Index + 1;
            //if (next < employeesDataGridView.RowCount)
            //{
            //    employeesDataGridView.CurrentCell = employeesDataGridView.Rows[next].Cells[employeesDataGridView.CurrentCell.ColumnIndex];
            //}
            //if (next == employeesDataGridView.RowCount)
            //{
            //    employeesDataGridView.CurrentCell = employeesDataGridView.Rows[0].Cells[0];
            //}
        }

        private void SortPos_Click(object sender, EventArgs e)
        {
            positionBindingSource.Sort=SortPosBy.SelectedText.ToString();
            //positionDataGridView.Sort(positionDataGridView.Columns[SortPosBy.SelectedIndex], ListSortDirection.Ascending);
        }

        private void FilterPos_Click(object sender, EventArgs e)
        {
            string filter = FilterField.SelectedText;
            positionBindingSource.Filter = filter + " ='" + FilterPosBy.Text + "'";
        }

        private void SearchPosBtn_Click(object sender, EventArgs e)
        {
            string searchable = SearchPosBy.Text;
            string find_in = SearchPosField.SelectedText;
            positionBindingSource.Position = positionBindingSource.Find(find_in, searchable);
        }

        private void SortEmp_Click(object sender, EventArgs e)
        {
            employeesDataGridView.Sort(employeesDataGridView.Columns[SortEmpBy.SelectedIndex], ListSortDirection.Ascending);
        }

        private void FilterEmp_Click(object sender, EventArgs e)
        {
            string filter = FilterEmpField.SelectedItem.ToString();
            employeesBindingSource.Filter = filter + " ='" + FilterEmpBy.Text + "'";
        }

        private void SearchEmp_Click(object sender, EventArgs e)
        {
            string searchable = SearchEmpBy.Text;
            string find_in = SearchEmpField.SelectedItem.ToString();
            employeesBindingSource.Position = employeesBindingSource.Find(find_in, searchable);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SaveEmp_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Update(ecoFarmDataSet);
        }

        private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           //EmpNumbTXT.Text = employeesDataGridView.SelectedRows[0].Cells[0].Value.ToString();
           //NameTXT.Text = employeesDataGridView.SelectedRows[0].Cells[1].Value.ToString();
           //PhoneTXT.Text = employeesDataGridView.SelectedRows[0].Cells[2].Value.ToString();
           //AdressTXT.Text = employeesDataGridView.SelectedRows[0].Cells[3].Value.ToString();
           //PositionCodeTXT.Text = employeesDataGridView.SelectedRows[0].Cells[4].Value.ToString();
           //PassportNumTXT.Text = employeesDataGridView.SelectedRows[0].Cells[5].Value.ToString();
           //PassportSeriesTXT.Text = employeesDataGridView.SelectedRows[0].Cells[6].Value.ToString();
           //BirthDateTXT.Text = employeesDataGridView.SelectedRows[0].Cells[7].Value.ToString();          
        }

        private void DeleteEmp_Click(object sender, EventArgs e)
        {
            if (this.employeesDataGridView.SelectedRows.Count > 0)
            {
                employeesDataGridView.Rows.RemoveAt(this.employeesDataGridView.SelectedRows[0].Index);
            }
        }

        private void ClrFilter_Click(object sender, EventArgs e)
        {
            employeesBindingSource.RemoveFilter();
            positionBindingSource.RemoveFilter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        

        private void positionDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (connect==true)
                if (((DataRowView)positionDataGridView.SelectedRows[0].DataBoundItem).Row.GetChildRows("Position_Employees").Length > 0)
                    employeesDataGridView.DataSource = ((DataRowView)positionDataGridView.SelectedRows[0].DataBoundItem).Row.GetChildRows("Position_Employees").CopyToDataTable();
                else
                {
                    employeesDataGridView.DataSource = string.Empty;
                }
        }

        private void positionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Col_Pos_Click(object sender, EventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.DarkGreen;
            foreach (DataGridViewColumn column in positionDataGridView.Columns)
            {
                if (column.HeaderText.Equals(Col_Field_Pos.SelectedItem.ToString()))
                {
                    column.DefaultCellStyle = style;
                }
            }
        }

        private void Col_Emp_Click(object sender, EventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.DarkGreen;
            foreach (DataGridViewColumn column in employeesDataGridView.Columns)
            {
                if (column.HeaderText.Equals(Col_Field_Emp.SelectedItem.ToString()))
                {
                    column.DefaultCellStyle = style;
                }
            }
        }
    }
}
