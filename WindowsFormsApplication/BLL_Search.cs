using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using System.Reflection;
using System.Drawing.Imaging;

using System.Collections;

namespace WindowsFormsApplication
{
    internal class BLL_Search
    {
        DAL_GET dal = new DAL_GET();
        DAL_SEARCH dalSearch = new DAL_SEARCH();

        internal void Update_Grid(DataGridView dataGridView, string tableName)
        {
            if (dataGridView.Rows.Count != 0)
            {

                if (tableName == "MainTB")
                {
                    dataGridView.Columns["ID"].Visible = Properties.Settings.Default.mainForms_mainTB_ID;
                    dataGridView.Columns["ID"].HeaderCell.Value = "ID";

                    dataGridView.Columns["dateCreated"].Visible = Properties.Settings.Default.mainForms_mainTB_date;
                    dataGridView.Columns["dateCreated"].HeaderCell.Value = "Дата";

                    dataGridView.Columns["TypeAC"].Visible = Properties.Settings.Default.mainForms_mainTB_TypeAC;
                    dataGridView.Columns["TypeAC"].HeaderCell.Value = "Вид учёта";

                    dataGridView.Columns["NumberINV"].Visible = Properties.Settings.Default.mainForms_mainTB_InvNum;
                    dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";

                    dataGridView.Columns["NameLAN"].Visible = Properties.Settings.Default.mainForms_mainTB_LanName;
                    dataGridView.Columns["NameLAN"].HeaderCell.Value = "Имя в сети (ПК)";

                    dataGridView.Columns["NameRes"].Visible = Properties.Settings.Default.mainForms_mainTB_ResName;
                    dataGridView.Columns["NameRes"].HeaderCell.Value = "Ответственный ";

                    dataGridView.Columns["floorNambe"].Visible = Properties.Settings.Default.mainForms_mainTB_Floor;
                    dataGridView.Columns["floorNambe"].HeaderCell.Value = "Этаж";

                    dataGridView.Columns["NameRoom"].Visible = Properties.Settings.Default.mainForms_mainTB_Room;
                    dataGridView.Columns["NameRoom"].HeaderCell.Value = "Комната";

                    dataGridView.Columns["NameDevice"].Visible = Properties.Settings.Default.mainForms_mainTB_TypeDiv;
                    dataGridView.Columns["NameDevice"].HeaderCell.Value = "Тип устройства";

                    dataGridView.Columns["Model"].Visible = Properties.Settings.Default.mainForms_mainTB_Model;
                    dataGridView.Columns["Model"].HeaderCell.Value = "Модель";

                    dataGridView.Columns["SN"].Visible = Properties.Settings.Default.mainForms_mainTB_SN;
                    dataGridView.Columns["SN"].HeaderCell.Value = "Серийный номер";

                    dataGridView.Columns["JiraTask"].Visible = Properties.Settings.Default.mainForms_mainTB_JiraTask;
                    dataGridView.Columns["JiraTask"].HeaderCell.Value = "Задача в JIRA";

                    dataGridView.Columns["WrittenOff"].Visible = Properties.Settings.Default.mainForms_mainTB_WrittenOff;
                    dataGridView.Columns["WrittenOff"].HeaderCell.Value = "Списано";

                    dataGridView.Columns["ReasonWriteOff"].Visible = Properties.Settings.Default.mainForms_mainTB_Reason;
                    dataGridView.Columns["ReasonWriteOff"].HeaderCell.Value = "Причина списания ";

                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);

                }

                else if (tableName == "HardWare")
                {
                    dataGridView.Columns["ID"].Visible = Properties.Settings.Default.mainForms_hardware_ID;
                    dataGridView.Columns["ID"].HeaderCell.Value = "ID";

                    dataGridView.Columns["dateCreated"].Visible = Properties.Settings.Default.mainForms_hardware_date;
                    dataGridView.Columns["dateCreated"].HeaderCell.Value = "Дата";

                    dataGridView.Columns["NumberINV"].Visible = Properties.Settings.Default.mainForms_hardware_InvNum;
                    dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";

                    dataGridView.Columns["NameLAN"].Visible = Properties.Settings.Default.mainForms_hardware_LanName;
                    dataGridView.Columns["NameLAN"].HeaderCell.Value = "Имя в сети (ПК)";

                    dataGridView.Columns["NameRes"].Visible = Properties.Settings.Default.mainForms_hardware_ResName;
                    dataGridView.Columns["NameRes"].HeaderCell.Value = "Ответственный ";

                    dataGridView.Columns["floorNambe"].Visible = Properties.Settings.Default.mainForms_hardware_Floor;
                    dataGridView.Columns["floorNambe"].HeaderCell.Value = "Этаж";

                    dataGridView.Columns["NameRoom"].Visible = Properties.Settings.Default.mainForms_hardware_Room;
                    dataGridView.Columns["NameRoom"].HeaderCell.Value = "Комната";

                    dataGridView.Columns["TypeHardWare"].Visible = Properties.Settings.Default.mainForms_hardware_TypeDiv;
                    dataGridView.Columns["TypeHardWare"].HeaderCell.Value = "Тип устройства";

                    dataGridView.Columns["Model"].Visible = Properties.Settings.Default.mainForms_hardware_Model;
                    dataGridView.Columns["Model"].HeaderCell.Value = "Модель";

                    dataGridView.Columns["SN"].Visible = Properties.Settings.Default.mainForms_hardware_SN;
                    dataGridView.Columns["SN"].HeaderCell.Value = "Серийный номер";

                    dataGridView.Columns["JiraTask"].Visible = Properties.Settings.Default.mainForms_hardware_JiraTask;
                    dataGridView.Columns["JiraTask"].HeaderCell.Value = "Задача в JIRA";

                    dataGridView.Columns["WrittenOff"].Visible = Properties.Settings.Default.mainForms_hardware_WrittenOff;
                    dataGridView.Columns["WrittenOff"].HeaderCell.Value = "Списано";

                    dataGridView.Columns["ReasonWriteOff"].Visible = Properties.Settings.Default.mainForms_hardware_Reason;
                    dataGridView.Columns["ReasonWriteOff"].HeaderCell.Value = "Причина списания ";

                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);

                }

                else if (tableName == "HardwareStockRoom")
                {
                    dataGridView.Columns["ID"].Visible = Properties.Settings.Default.mainForms_stockroom_ID;
                    dataGridView.Columns["ID"].HeaderCell.Value = "ID";

                    dataGridView.Columns["dateCreated"].Visible = Properties.Settings.Default.mainForms_stockroom_date;
                    dataGridView.Columns["dateCreated"].HeaderCell.Value = "Дата";

                    dataGridView.Columns["NumberINV"].Visible = Properties.Settings.Default.mainForms_stockroom_InvNum;
                    dataGridView.Columns["NumberINV"].HeaderCell.Value = "Инвентарный номер";

                    dataGridView.Columns["quantity"].Visible = Properties.Settings.Default.mainForms_stockroom_Quantity;
                    dataGridView.Columns["quantity"].HeaderCell.Value = "Количество";

                    dataGridView.Columns["TypeHardWare"].Visible = Properties.Settings.Default.mainForms_stockroom_TypeDiv;
                    dataGridView.Columns["TypeHardWare"].HeaderCell.Value = "Тип устройства";

                    dataGridView.Columns["Model"].Visible = Properties.Settings.Default.mainForms_stockroom_Model;
                    dataGridView.Columns["Model"].HeaderCell.Value = "Модель";

                    dataGridView.Columns["SN"].Visible = Properties.Settings.Default.mainForms_stockroom_SN;
                    dataGridView.Columns["SN"].HeaderCell.Value = "Серийный номер";

                    dataGridView.Columns["JiraTask"].Visible = Properties.Settings.Default.mainForms_stockroom_JiraTask;
                    dataGridView.Columns["JiraTask"].HeaderCell.Value = "Задача в JIRA";

                    dataGridView.Columns["WrittenOff"].Visible = Properties.Settings.Default.mainForms_stockroom_WrittenOff;
                    dataGridView.Columns["WrittenOff"].HeaderCell.Value = "Списано";

                    dataGridView.Columns["ReasonWriteOff"].Visible = Properties.Settings.Default.mainForms_stockroom_Reason;
                    dataGridView.Columns["ReasonWriteOff"].HeaderCell.Value = "Причина списания ";

                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold | FontStyle.Italic);

                }

            }
        }

        internal void DataComboBox(ComboBox comboBox, string Table, string Colums )
        {
            DataTable list = new DataTable();
            list = dalSearch.Get_Data_in_combobox(Table, Colums);
            System.Collections.ArrayList lst = new System.Collections.ArrayList();
            
            lst.Add("Для всех");
            foreach (DataRow row in list.Rows)
            {
                lst.Add(row[0].ToString());
            }

            comboBox.DataSource = lst;
            
        }

        internal void DataComboBox(ComboBox comboBox)
        {
            DataTable list = new DataTable();
            list = dalSearch.Get_PC_name_Hardware();

            System.Collections.ArrayList lst = new System.Collections.ArrayList();

            lst.Add("Для всех");
            foreach (DataRow row in list.Rows)
            {
                lst.Add(row[0].ToString());
            }

            comboBox.DataSource = lst;
        }
    }
}