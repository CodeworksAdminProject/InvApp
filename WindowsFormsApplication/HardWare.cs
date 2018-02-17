using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class HardWare : Form
    {
        DAL_GET getDAL = new DAL_GET();
        
        public HardWare()
        {
            InitializeComponent();           
            dataGridView_HardWare.DataSource = getDAL.GetHardWare(MainFrorm.index); 
            dataGridView_HardWare.Columns["ID"].Visible = false;
            dataGridView_HardWare.Columns["SN"].Visible = false;
            dataGridView_HardWare.Columns["TypeHardWare"].HeaderCell.Value = "Наименование:";
            //dataGridView_HardWare.Columns["TypeHardWare"].HeaderCell.
            dataGridView_HardWare.Columns["Model"].HeaderCell.Value = "Модель устройства:";
        }
    }
}
