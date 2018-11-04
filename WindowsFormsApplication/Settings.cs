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

namespace WindowsFormsApplication
{
    public partial class Settings : Form
    {
        int flag;

        public Settings()
        {
            InitializeComponent();

            checkBox_print_img.Checked =Properties.Settings.Default.print_img ;
            checkBox_prin_labe_HW_PC.Checked = Properties.Settings.Default.prin_labe_HW_PC ;


            textBox_SqlServer.Text = Properties.Settings.Default.SqlServer;
            textBox_SqlPort.Text = Properties.Settings.Default.SqlPort;
            textBox_Mail.Text = Properties.Settings.Default.Email;
            textBox_LogatipPath.Text = Properties.Settings.Default.ImgPath;
            textBox_NameDB.Text = Properties.Settings.Default.SqlDataBase;
            comboBox_navigation.SelectedIndex = Properties.Settings.Default.int_navigation;
            comboBox__print_BarKod.SelectedIndex = Properties.Settings.Default.int_barcod;            

            comboBox_print_name_or_model.SelectedIndex = Properties.Settings.Default.print_name_or_model;

            //главное окно 
            mainForms_mainTB_ID.Checked = Properties.Settings.Default.mainForms_mainTB_ID;
            mainForms_mainTB_date.Checked = Properties.Settings.Default.mainForms_mainTB_date;
            mainForms_mainTB_TypeAC.Checked = Properties.Settings.Default.mainForms_mainTB_TypeAC;
            mainForms_mainTB_InvNum.Checked = Properties.Settings.Default.mainForms_mainTB_InvNum;
            mainForms_mainTB_LanName.Checked = Properties.Settings.Default.mainForms_mainTB_LanName;
            mainForms_mainTB_ResName.Checked = Properties.Settings.Default.mainForms_mainTB_ResName;
            mainForms_mainTB_Room.Checked = Properties.Settings.Default.mainForms_mainTB_Room;
            mainForms_mainTB_Floor.Checked = Properties.Settings.Default.mainForms_mainTB_Floor;
            mainForms_mainTB_TypeDiv.Checked = Properties.Settings.Default.mainForms_mainTB_TypeDiv;
            mainForms_mainTB_SN.Checked = Properties.Settings.Default.mainForms_mainTB_SN;
            mainForms_mainTB_Model.Checked = Properties.Settings.Default.mainForms_mainTB_Model;
            mainForms_mainTB_JiraTask.Checked = Properties.Settings.Default.mainForms_mainTB_JiraTask;
            mainForms_mainTB_note.Checked = Properties.Settings.Default.mainForms_mainTB_note;
            
            mainForms_hardware_date.Checked = Properties.Settings.Default.mainForms_hardware_date;
            mainForms_hardware_InvNum.Checked = Properties.Settings.Default.mainForms_hardware_InvNum;
            mainForms_hardware_LanName.Checked = Properties.Settings.Default.mainForms_hardware_LanName;
            mainForms_hardware_ResName.Checked = Properties.Settings.Default.mainForms_hardware_ResName;
            mainForms_hardware_Room.Checked = Properties.Settings.Default.mainForms_hardware_Room;
            mainForms_hardware_Floor.Checked = Properties.Settings.Default.mainForms_hardware_Floor;
            mainForms_hardware_TypeDiv.Checked = Properties.Settings.Default.mainForms_hardware_TypeDiv;
            mainForms_hardware_SN.Checked = Properties.Settings.Default.mainForms_hardware_SN;
            mainForms_hardware_Model.Checked = Properties.Settings.Default.mainForms_hardware_Model;
            mainForms_hardware_JiraTask.Checked = Properties.Settings.Default.mainForms_hardware_JiraTask;
            mainForms_hardware_note.Checked = Properties.Settings.Default.mainForms_hardware_note;

            mainForms_stockroom_ID.Checked = Properties.Settings.Default.mainForms_stockroom_ID;
            mainForms_stockroom_date.Checked = Properties.Settings.Default.mainForms_stockroom_date;            
            mainForms_stockroom_InvNum.Checked = Properties.Settings.Default.mainForms_stockroom_InvNum;
            mainForms_stockroom_Quantity.Checked = Properties.Settings.Default.mainForms_stockroom_Quantity;
            mainForms_stockroom_TypeDiv.Checked = Properties.Settings.Default.mainForms_stockroom_TypeDiv;
            mainForms_stockroom_SN.Checked = Properties.Settings.Default.mainForms_stockroom_SN;
            mainForms_stockroom_Model.Checked = Properties.Settings.Default.mainForms_stockroom_Model;
            mainForms_stockroom_WrittenOff.Checked = Properties.Settings.Default.mainForms_stockroom_WrittenOff;
            mainForms_stockroom_JiraTask.Checked = Properties.Settings.Default.mainForms_stockroom_JiraTask;
            mainForms_stockroom_note.Checked = Properties.Settings.Default.mainForms_stockroom_note;

            //перемещение 
            setDataBase_mainTB_ID.Checked = Properties.Settings.Default.setDataBase_mainTB_ID;
            setDataBase_mainTB_date.Checked = Properties.Settings.Default.setDataBase_mainTB_date;
            setDataBase_mainTB_TypeAC.Checked = Properties.Settings.Default.setDataBase_mainTB_TypeAC;
            setDataBase_mainTB_InvNum.Checked = Properties.Settings.Default.setDataBase_mainTB_InvNum;
            setDataBase_mainTB_LanName.Checked = Properties.Settings.Default.setDataBase_mainTB_LanName;
            setDataBase_mainTB_ResName.Checked = Properties.Settings.Default.setDataBase_mainTB_ResName;
            setDataBase_mainTB_Room.Checked = Properties.Settings.Default.setDataBase_mainTB_Room;
            setDataBase_mainTB_Floor.Checked = Properties.Settings.Default.setDataBase_mainTB_Floor;
            setDataBase_mainTB_TypeDiv.Checked = Properties.Settings.Default.setDataBase_mainTB_TypeDiv;
            setDataBase_mainTB_SN.Checked = Properties.Settings.Default.setDataBase_mainTB_SN;
            setDataBase_mainTB_Model.Checked = Properties.Settings.Default.setDataBase_mainTB_Model;
            setDataBase_mainTB_WrittenOff.Checked = Properties.Settings.Default.setDataBase_mainTB_WrittenOff;
            setDataBase_mainTB_JiraTask.Checked = Properties.Settings.Default.setDataBase_mainTB_JiraTask;
            setDataBase_mainTB_Reason.Checked = Properties.Settings.Default.setDataBase_mainTB_Reason;

            // изменение 
            changeFormTwo_mainTB_ID.Checked = Properties.Settings.Default.changeFormTwo_mainTB_ID;
            changeFormTwo_mainTB_date.Checked = Properties.Settings.Default.changeFormTwo_mainTB_date;
            changeFormTwo_mainTB_TypeAC.Checked = Properties.Settings.Default.changeFormTwo_mainTB_TypeAC;
            changeFormTwo_mainTB_InvNum.Checked = Properties.Settings.Default.changeFormTwo_mainTB_InvNum;
            changeFormTwo_mainTB_LanName.Checked = Properties.Settings.Default.changeFormTwo_mainTB_LanName;
            changeFormTwo_mainTB_ResName.Checked = Properties.Settings.Default.changeFormTwo_mainTB_ResName;
            changeFormTwo_mainTB_Room.Checked = Properties.Settings.Default.changeFormTwo_mainTB_Room;
            changeFormTwo_mainTB_Floor.Checked = Properties.Settings.Default.changeFormTwo_mainTB_Floor;
            changeFormTwo_mainTB_TypeDiv.Checked = Properties.Settings.Default.changeFormTwo_mainTB_TypeDiv;
            changeFormTwo_mainTB_SN.Checked = Properties.Settings.Default.changeFormTwo_mainTB_SN;
            changeFormTwo_mainTB_Model.Checked = Properties.Settings.Default.changeFormTwo_mainTB_Model;
            changeFormTwo_mainTB_WrittenOff.Checked = Properties.Settings.Default.changeFormTwo_mainTB_WrittenOff;
            changeFormTwo_mainTB_JiraTask.Checked = Properties.Settings.Default.changeFormTwo_mainTB_JiraTask;
            changeFormTwo_mainTB_Reason.Checked = Properties.Settings.Default.changeFormTwo_mainTB_Reason;
            changeFormTwo_mainTB_note.Checked = Properties.Settings.Default.changeFormTwo_mainTB_note;

            ChangeFormTwo_hardware_date.Checked = Properties.Settings.Default.ChangeFormTwo_hardware_ID;
            ChangeFormTwo_hardware_date.Checked = Properties.Settings.Default.ChangeFormTwo_hardware_date;
            ChangeFormTwo_hardware_InvNum.Checked = Properties.Settings.Default.ChangeFormTwo_hardware_InvNum;
            ChangeFormTwo_hardware_LanName.Checked = Properties.Settings.Default.ChangeFormTwo_hardware_LanName;
            ChangeFormTwo_hardware_ResName.Checked = Properties.Settings.Default.ChangeFormTwo_hardware_ResName;
            ChangeFormTwo_hardware_Room.Checked = Properties.Settings.Default.ChangeFormTwo_hardware_Room;
            ChangeFormTwo_hardware_Floor.Checked = Properties.Settings.Default.ChangeFormTwo_hardware_Floor;
            ChangeFormTwo_hardware_TypeDiv.Checked = Properties.Settings.Default.ChangeFormTwo_hardware_TypeDiv;
            ChangeFormTwo_hardware_SN.Checked = Properties.Settings.Default.ChangeFormTwo_hardware_SN;
            ChangeFormTwo_hardware_Model.Checked = Properties.Settings.Default.ChangeFormTwo_hardware_Model;
            ChangeFormTwo_hardware_WrittenOff.Checked = Properties.Settings.Default.ChangeFormTwo_hardware_WrittenOff;
            ChangeFormTwo_hardware_JiraTask.Checked = Properties.Settings.Default.ChangeFormTwo_hardware_JiraTask;
            ChangeFormTwo_hardware_Reason.Checked = Properties.Settings.Default.ChangeFormTwo_hardware_Reason;
            ChangeFormTwo_hardware_Note.Checked = Properties.Settings.Default.ChangeFormTwo_hardware_Note;

            ChangeFormTwo_stockroom_ID.Checked = Properties.Settings.Default.ChangeFormTwo_stockroom_ID;
            ChangeFormTwo_stockroom_date.Checked = Properties.Settings.Default.ChangeFormTwo_stockroom_date;
            ChangeFormTwo_stockroom_InvNum.Checked = Properties.Settings.Default.ChangeFormTwo_stockroom_InvNum;
            ChangeFormTwo_stockroom_Quantity.Checked = Properties.Settings.Default.ChangeFormTwo_stockroom_Quantity;
            ChangeFormTwo_stockroom_TypeDiv.Checked = Properties.Settings.Default.ChangeFormTwo_stockroom_TypeDiv;
            ChangeFormTwo_stockroom_SN.Checked = Properties.Settings.Default.ChangeFormTwo_stockroom_SN;
            ChangeFormTwo_stockroom_Model.Checked = Properties.Settings.Default.ChangeFormTwo_stockroom_Model;
            ChangeFormTwo_stockroom_WrittenOff.Checked = Properties.Settings.Default.ChangeFormTwo_stockroom_WrittenOff;
            ChangeFormTwo_stockroom_JiraTask.Checked = Properties.Settings.Default.ChangeFormTwo_stockroom_JiraTask;
            ChangeFormTwo_stockroom_Reason.Checked = Properties.Settings.Default.ChangeFormTwo_stockroom_Reason;
            ChangeFormTwo_stockroom_Note.Checked = Properties.Settings.Default.ChangeFormTwo_stockroom_Note;


            // поиск 
            Search_mainTB_ID.Checked = Properties.Settings.Default.Search_mainTB_ID;
            Search_mainTB_date.Checked = Properties.Settings.Default.Search_mainTB_date;
            Search_mainTB_TypeAC.Checked = Properties.Settings.Default.Search_mainTB_TypeAC;
            Search_mainTB_InvNum.Checked = Properties.Settings.Default.Search_mainTB_InvNum;
            Search_mainTB_LanName.Checked = Properties.Settings.Default.Search_mainTB_LanName;
            Search_mainTB_ResName.Checked = Properties.Settings.Default.Search_mainTB_ResName;
            Search_mainTB_Room.Checked = Properties.Settings.Default.Search_mainTB_Room;
            Search_mainTB_Floor.Checked = Properties.Settings.Default.Search_mainTB_Floor;
            Search_mainTB_TypeDiv.Checked = Properties.Settings.Default.Search_mainTB_TypeDiv;
            Search_mainTB_SN.Checked = Properties.Settings.Default.Search_mainTB_SN;
            Search_mainTB_Model.Checked = Properties.Settings.Default.Search_mainTB_Model;
            Search_mainTB_WrittenOff.Checked = Properties.Settings.Default.Search_mainTB_WrittenOff;
            Search_mainTB_JiraTask.Checked = Properties.Settings.Default.Search_mainTB_JiraTask;
            Search_mainTB_Reason.Checked = Properties.Settings.Default.Search_mainTB_Reason;

            Search_hardware_ID.Checked = Properties.Settings.Default.Search_hardware_ID;
            Search_hardware_date.Checked = Properties.Settings.Default.Search_hardware_date;
            Search_hardware_InvNum.Checked = Properties.Settings.Default.Search_hardware_InvNum;
            Search_hardware_LanName.Checked = Properties.Settings.Default.Search_hardware_LanName;
            Search_hardware_ResName.Checked = Properties.Settings.Default.Search_hardware_ResName;
            Search_hardware_Room.Checked = Properties.Settings.Default.Search_hardware_Room;
            Search_hardware_Floor.Checked = Properties.Settings.Default.Search_hardware_Floor;
            Search_hardware_TypeDiv.Checked = Properties.Settings.Default.Search_hardware_TypeDiv;
            Search_hardware_SN.Checked = Properties.Settings.Default.Search_hardware_SN;
            Search_hardware_Model.Checked = Properties.Settings.Default.Search_hardware_Model;
            Search_hardware_WrittenOff.Checked = Properties.Settings.Default.Search_hardware_WrittenOff;
            Search_hardware_JiraTask.Checked = Properties.Settings.Default.Search_hardware_JiraTask;
            Search_hardware_Reason.Checked = Properties.Settings.Default.Search_hardware_Reason;

            Search_stockroom_ID.Checked = Properties.Settings.Default.Search_stockroom_ID;
            Search_stockroom_date.Checked = Properties.Settings.Default.Search_stockroom_date;
            Search_stockroom_InvNum.Checked = Properties.Settings.Default.Search_stockroom_InvNum;
            Search_stockroom_Quantity.Checked = Properties.Settings.Default.Search_stockroom_Quantity;
            Search_stockroom_TypeDiv.Checked = Properties.Settings.Default.Search_stockroom_TypeDiv;
            Search_stockroom_SN.Checked = Properties.Settings.Default.Search_stockroom_SN;
            Search_stockroom_Model.Checked = Properties.Settings.Default.Search_stockroom_Model;
            Search_stockroom_WrittenOff.Checked = Properties.Settings.Default.Search_stockroom_WrittenOff;
            Search_stockroom_JiraTask.Checked = Properties.Settings.Default.Search_stockroom_JiraTask;
            Search_stockroom_Reason.Checked = Properties.Settings.Default.Search_stockroom_Reason;






            if (Properties.Settings.Default.ImgPath != "")
                 pictureBox_Image.Image = Image.FromFile(Properties.Settings.Default.ImgPath);

                 button_Data_Base_Click(null, null);       

        }

        private void button_NewImaje_Click(object sender, EventArgs e)
        {
            //окно выбара файла   (window select file img )
            OpenFileDialog newFile = new OpenFileDialog();
            newFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            newFile.FilterIndex = 1;
            newFile.RestoreDirectory = true;
            try
            {
                if(newFile.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_Image.Image = Image.FromFile(newFile.FileName);
                    textBox_LogatipPath.Text = newFile.FileName;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }

        }

        private void button_Save_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.print_img = checkBox_print_img.Checked;
            Properties.Settings.Default.prin_labe_HW_PC = checkBox_prin_labe_HW_PC.Checked;

            Properties.Settings.Default.SqlServer = textBox_SqlServer.Text ;
            Properties.Settings.Default.SqlPort = textBox_SqlPort.Text;
            Properties.Settings.Default.Email =textBox_Mail.Text ;
            Properties.Settings.Default.ImgPath= textBox_LogatipPath.Text;
            Properties.Settings.Default.SqlDataBase = textBox_NameDB.Text;
            Properties.Settings.Default.Save();            
            Properties.Settings.Default.int_navigation = comboBox_navigation.SelectedIndex;
            Properties.Settings.Default.int_barcod = comboBox__print_BarKod.SelectedIndex;
            Properties.Settings.Default.print_name_or_model = comboBox_print_name_or_model.SelectedIndex;

            Properties.Settings.Default.mainForms_stockroom_ID = mainForms_stockroom_ID.Checked;
            Properties.Settings.Default.mainForms_stockroom_date = mainForms_stockroom_date.Checked;
            Properties.Settings.Default.mainForms_stockroom_InvNum = mainForms_stockroom_InvNum.Checked;
            Properties.Settings.Default.mainForms_stockroom_Quantity = mainForms_stockroom_Quantity.Checked;
            Properties.Settings.Default.mainForms_stockroom_TypeDiv = mainForms_stockroom_TypeDiv.Checked;
            Properties.Settings.Default.mainForms_stockroom_SN = mainForms_stockroom_SN.Checked;
            Properties.Settings.Default.mainForms_stockroom_Model = mainForms_stockroom_Model.Checked;
            Properties.Settings.Default.mainForms_stockroom_WrittenOff = mainForms_stockroom_WrittenOff.Checked;
            Properties.Settings.Default.mainForms_stockroom_JiraTask = mainForms_stockroom_JiraTask.Checked;
            Properties.Settings.Default.mainForms_stockroom_Reason = mainForms_stockroom_Reason.Checked;
            Properties.Settings.Default.mainForms_stockroom_note = mainForms_stockroom_note.Checked;

            Properties.Settings.Default.mainForms_mainTB_ID = mainForms_mainTB_ID.Checked;
            Properties.Settings.Default.mainForms_mainTB_date = mainForms_mainTB_date.Checked;
            Properties.Settings.Default.mainForms_mainTB_TypeAC = mainForms_mainTB_TypeAC.Checked;
            Properties.Settings.Default.mainForms_mainTB_InvNum = mainForms_mainTB_InvNum.Checked;
            Properties.Settings.Default.mainForms_mainTB_LanName = mainForms_mainTB_LanName.Checked;
            Properties.Settings.Default.mainForms_mainTB_ResName = mainForms_mainTB_ResName.Checked;
            Properties.Settings.Default.mainForms_mainTB_Room = mainForms_mainTB_Room.Checked;
            Properties.Settings.Default.mainForms_mainTB_Floor = mainForms_mainTB_Floor.Checked;
            Properties.Settings.Default.mainForms_mainTB_TypeDiv = mainForms_mainTB_TypeDiv.Checked;
            Properties.Settings.Default.mainForms_mainTB_SN = mainForms_mainTB_SN.Checked;
            Properties.Settings.Default.mainForms_mainTB_Model = mainForms_mainTB_Model.Checked;
            Properties.Settings.Default.mainForms_mainTB_JiraTask = mainForms_mainTB_JiraTask.Checked;
            Properties.Settings.Default.mainForms_mainTB_Reason = mainForms_mainTB_note.Checked;


            Properties.Settings.Default.mainForms_hardware_ID = mainForms_hardware_ID.Checked;
            Properties.Settings.Default.mainForms_hardware_date = mainForms_hardware_date.Checked;
            Properties.Settings.Default.mainForms_hardware_InvNum = mainForms_hardware_InvNum.Checked;
            Properties.Settings.Default.mainForms_hardware_LanName = mainForms_hardware_LanName.Checked;
            Properties.Settings.Default.mainForms_hardware_ResName = mainForms_hardware_ResName.Checked;
            Properties.Settings.Default.mainForms_hardware_Room = mainForms_hardware_Room.Checked;
            Properties.Settings.Default.mainForms_hardware_Floor = mainForms_hardware_Floor.Checked;
            Properties.Settings.Default.mainForms_hardware_TypeDiv = mainForms_hardware_TypeDiv.Checked;
            Properties.Settings.Default.mainForms_hardware_SN = mainForms_hardware_SN.Checked;
            Properties.Settings.Default.mainForms_hardware_Model = mainForms_hardware_Model.Checked;
            Properties.Settings.Default.mainForms_hardware_JiraTask = mainForms_hardware_JiraTask.Checked;
            Properties.Settings.Default.mainForms_hardware_Reason = mainForms_hardware_note.Checked;

            Properties.Settings.Default.setDataBase_mainTB_ID = setDataBase_mainTB_ID.Checked;
            Properties.Settings.Default.setDataBase_mainTB_date = setDataBase_mainTB_date.Checked;
            Properties.Settings.Default.setDataBase_mainTB_TypeAC = setDataBase_mainTB_TypeAC.Checked;
            Properties.Settings.Default.setDataBase_mainTB_InvNum = setDataBase_mainTB_InvNum.Checked;
            Properties.Settings.Default.setDataBase_mainTB_LanName = setDataBase_mainTB_LanName.Checked;
            Properties.Settings.Default.setDataBase_mainTB_ResName = setDataBase_mainTB_ResName.Checked;
            Properties.Settings.Default.setDataBase_mainTB_Room = setDataBase_mainTB_Room.Checked;
            Properties.Settings.Default.setDataBase_mainTB_Floor = setDataBase_mainTB_Floor.Checked;
            Properties.Settings.Default.setDataBase_mainTB_TypeDiv = setDataBase_mainTB_TypeDiv.Checked;
            Properties.Settings.Default.setDataBase_mainTB_SN = setDataBase_mainTB_SN.Checked;
            Properties.Settings.Default.setDataBase_mainTB_Model = setDataBase_mainTB_Model.Checked;
            Properties.Settings.Default.setDataBase_mainTB_WrittenOff = setDataBase_mainTB_WrittenOff.Checked;
            Properties.Settings.Default.setDataBase_mainTB_JiraTask = setDataBase_mainTB_JiraTask.Checked;
            Properties.Settings.Default.setDataBase_mainTB_Reason = setDataBase_mainTB_Reason.Checked;
            Properties.Settings.Default.setDataBase_mainTB_note = setDataBase_mainTB_note.Checked;

            Properties.Settings.Default.changeFormTwo_mainTB_ID = changeFormTwo_mainTB_ID.Checked;
            Properties.Settings.Default.changeFormTwo_mainTB_date = changeFormTwo_mainTB_date.Checked;
            Properties.Settings.Default.changeFormTwo_mainTB_TypeAC = changeFormTwo_mainTB_TypeAC.Checked;
            Properties.Settings.Default.changeFormTwo_mainTB_InvNum = changeFormTwo_mainTB_InvNum.Checked;
            Properties.Settings.Default.changeFormTwo_mainTB_LanName = changeFormTwo_mainTB_LanName.Checked;
            Properties.Settings.Default.changeFormTwo_mainTB_ResName = changeFormTwo_mainTB_ResName.Checked;
            Properties.Settings.Default.changeFormTwo_mainTB_Room = changeFormTwo_mainTB_Room.Checked;
            Properties.Settings.Default.changeFormTwo_mainTB_Floor = changeFormTwo_mainTB_Floor.Checked;
            Properties.Settings.Default.changeFormTwo_mainTB_TypeDiv = changeFormTwo_mainTB_TypeDiv.Checked;
            Properties.Settings.Default.changeFormTwo_mainTB_SN = changeFormTwo_mainTB_SN.Checked;
            Properties.Settings.Default.changeFormTwo_mainTB_Model = changeFormTwo_mainTB_Model.Checked;
            Properties.Settings.Default.changeFormTwo_mainTB_WrittenOff = changeFormTwo_mainTB_WrittenOff.Checked;
            Properties.Settings.Default.changeFormTwo_mainTB_JiraTask = changeFormTwo_mainTB_JiraTask.Checked;
            Properties.Settings.Default.changeFormTwo_mainTB_Reason = changeFormTwo_mainTB_Reason.Checked;
            Properties.Settings.Default.changeFormTwo_mainTB_note = changeFormTwo_mainTB_note.Checked;

            Properties.Settings.Default.Search_hardware_ID = Search_hardware_ID.Checked;
            Properties.Settings.Default.Search_hardware_date = Search_hardware_date.Checked;            
            Properties.Settings.Default.Search_hardware_InvNum = Search_hardware_InvNum.Checked;
            Properties.Settings.Default.Search_hardware_LanName = Search_hardware_LanName.Checked;
            Properties.Settings.Default.Search_hardware_ResName = Search_hardware_ResName.Checked;
            Properties.Settings.Default.Search_hardware_Room = Search_hardware_Room.Checked;
            Properties.Settings.Default.Search_hardware_Floor = Search_hardware_Floor.Checked;
            Properties.Settings.Default.Search_hardware_TypeDiv = Search_hardware_TypeDiv.Checked;
            Properties.Settings.Default.Search_hardware_SN = Search_hardware_SN.Checked;
            Properties.Settings.Default.Search_hardware_Model = Search_hardware_Model.Checked;
            Properties.Settings.Default.Search_hardware_WrittenOff = Search_hardware_WrittenOff.Checked;
            Properties.Settings.Default.Search_hardware_JiraTask = Search_hardware_JiraTask.Checked;
            Properties.Settings.Default.Search_hardware_Reason = Search_hardware_Reason.Checked;
            Properties.Settings.Default.Search_hardware_note = Search_hardware_note.Checked;

            Properties.Settings.Default.Search_mainTB_ID = Search_mainTB_ID.Checked;
            Properties.Settings.Default.Search_mainTB_date = Search_mainTB_date.Checked;
            Properties.Settings.Default.Search_mainTB_TypeAC = Search_mainTB_TypeAC.Checked;
            Properties.Settings.Default.Search_mainTB_InvNum = Search_mainTB_InvNum.Checked;
            Properties.Settings.Default.Search_mainTB_LanName = Search_mainTB_LanName.Checked;
            Properties.Settings.Default.Search_mainTB_ResName = Search_mainTB_ResName.Checked;
            Properties.Settings.Default.Search_mainTB_Room = Search_mainTB_Room.Checked;
            Properties.Settings.Default.Search_mainTB_Floor = Search_mainTB_Floor.Checked;
            Properties.Settings.Default.Search_mainTB_TypeDiv = Search_mainTB_TypeDiv.Checked;
            Properties.Settings.Default.Search_mainTB_SN = Search_mainTB_SN.Checked;
            Properties.Settings.Default.Search_mainTB_Model = Search_mainTB_Model.Checked;
            Properties.Settings.Default.Search_mainTB_WrittenOff = Search_mainTB_WrittenOff.Checked;
            Properties.Settings.Default.Search_mainTB_JiraTask = Search_mainTB_JiraTask.Checked;
            Properties.Settings.Default.Search_mainTB_Reason = Search_mainTB_Reason.Checked;
            Properties.Settings.Default.Search_mainTB_note = Search_mainTB_note.Checked;

            Properties.Settings.Default.Search_stockroom_ID = Search_stockroom_ID.Checked;
            Properties.Settings.Default.Search_stockroom_date = Search_stockroom_date.Checked;
            Properties.Settings.Default.Search_stockroom_InvNum = Search_stockroom_InvNum.Checked;
            Properties.Settings.Default.Search_stockroom_Quantity = Search_stockroom_Quantity.Checked;
            Properties.Settings.Default.Search_stockroom_TypeDiv = Search_stockroom_TypeDiv.Checked;
            Properties.Settings.Default.Search_stockroom_SN = Search_stockroom_SN.Checked;
            Properties.Settings.Default.Search_stockroom_Model = Search_stockroom_Model.Checked;
            Properties.Settings.Default.Search_stockroom_WrittenOff = Search_stockroom_WrittenOff.Checked;
            Properties.Settings.Default.Search_stockroom_JiraTask = Search_stockroom_JiraTask.Checked;
            Properties.Settings.Default.Search_stockroom_Reason = Search_stockroom_Reason.Checked;
            Properties.Settings.Default.Search_stockroom_note = Search_stockroom_note.Checked;
            
            Properties.Settings.Default.ChangeFormTwo_stockroom_ID = ChangeFormTwo_stockroom_ID.Checked;
            Properties.Settings.Default.ChangeFormTwo_stockroom_date = ChangeFormTwo_stockroom_date.Checked;
            Properties.Settings.Default.ChangeFormTwo_stockroom_InvNum = ChangeFormTwo_stockroom_InvNum.Checked;
            Properties.Settings.Default.ChangeFormTwo_stockroom_Quantity = ChangeFormTwo_stockroom_Quantity.Checked;
            Properties.Settings.Default.ChangeFormTwo_stockroom_TypeDiv = ChangeFormTwo_stockroom_TypeDiv.Checked;
            Properties.Settings.Default.ChangeFormTwo_stockroom_SN = ChangeFormTwo_stockroom_SN.Checked;
            Properties.Settings.Default.ChangeFormTwo_stockroom_Model = ChangeFormTwo_stockroom_Model.Checked;
            Properties.Settings.Default.ChangeFormTwo_stockroom_WrittenOff = ChangeFormTwo_stockroom_WrittenOff.Checked;
            Properties.Settings.Default.ChangeFormTwo_stockroom_JiraTask = ChangeFormTwo_stockroom_JiraTask.Checked;
            Properties.Settings.Default.ChangeFormTwo_stockroom_Reason = ChangeFormTwo_stockroom_Reason.Checked;
            Properties.Settings.Default.ChangeFormTwo_stockroom_Note = ChangeFormTwo_stockroom_Note.Checked;

            Properties.Settings.Default.ChangeFormTwo_hardware_ID = ChangeFormTwo_hardware_ID.Checked;
            Properties.Settings.Default.ChangeFormTwo_hardware_date = ChangeFormTwo_hardware_date.Checked;
            Properties.Settings.Default.ChangeFormTwo_hardware_InvNum = ChangeFormTwo_hardware_InvNum.Checked;
            Properties.Settings.Default.ChangeFormTwo_hardware_LanName = ChangeFormTwo_hardware_LanName.Checked;
            Properties.Settings.Default.ChangeFormTwo_hardware_ResName = ChangeFormTwo_hardware_ResName.Checked;
            Properties.Settings.Default.ChangeFormTwo_hardware_Room = ChangeFormTwo_hardware_Room.Checked;
            Properties.Settings.Default.ChangeFormTwo_hardware_Floor = ChangeFormTwo_hardware_Floor.Checked;
            Properties.Settings.Default.ChangeFormTwo_hardware_TypeDiv = ChangeFormTwo_hardware_TypeDiv.Checked;
            Properties.Settings.Default.ChangeFormTwo_hardware_SN = ChangeFormTwo_hardware_SN.Checked;
            Properties.Settings.Default.ChangeFormTwo_hardware_Model = ChangeFormTwo_hardware_Model.Checked;
            Properties.Settings.Default.ChangeFormTwo_hardware_WrittenOff = ChangeFormTwo_hardware_WrittenOff.Checked;
            Properties.Settings.Default.ChangeFormTwo_hardware_JiraTask = ChangeFormTwo_hardware_JiraTask.Checked;
            Properties.Settings.Default.ChangeFormTwo_hardware_Reason = ChangeFormTwo_hardware_Reason.Checked;
            Properties.Settings.Default.ChangeFormTwo_hardware_Note = ChangeFormTwo_hardware_Note.Checked;

            Properties.Settings.Default.Save();

            this.Close();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (flag == 1)
            {
                button_View.ForeColor= button_mail.ForeColor = button_Navigation.ForeColor = button_Print.ForeColor = Color.MidnightBlue;
                button_View.BackColor = button_mail.BackColor = button_Navigation.BackColor = button_Print.BackColor = Color.White;
            }
            else if (flag == 2)
            {
                button_View.ForeColor = button_Data_Base.ForeColor = button_Navigation.ForeColor = button_Print.ForeColor = Color.MidnightBlue;
                button_View.BackColor = button_Data_Base.BackColor = button_Navigation.BackColor = button_Print.BackColor = Color.White;
            }
            else if (flag == 3)
            {
                button_View.ForeColor = button_mail.ForeColor = button_Data_Base.ForeColor = button_Print.ForeColor = Color.MidnightBlue;
                button_View.BackColor = button_mail.BackColor = button_Data_Base.BackColor = button_Print.BackColor = Color.White;
            }
            else if (flag == 4)
            {
                button_View.ForeColor = button_mail.ForeColor = button_Navigation.ForeColor = button_Data_Base.ForeColor = Color.MidnightBlue;
                button_View.BackColor = button_mail.BackColor = button_Navigation.BackColor = button_Data_Base.BackColor = Color.White;
            }
            else if (flag == 5)
            {
                button_Data_Base.ForeColor = button_mail.ForeColor = button_Navigation.ForeColor = button_Print.ForeColor = Color.MidnightBlue;
                button_Data_Base.BackColor = button_mail.BackColor = button_Navigation.BackColor = button_Print.BackColor = Color.White;
            }

            else
            {
                button_View.ForeColor = button_Data_Base.ForeColor = button_mail.ForeColor = button_Navigation.ForeColor = button_Print.ForeColor = Color.MidnightBlue;
                button_View.BackColor = button_Data_Base.BackColor = button_mail.BackColor = button_Navigation.BackColor = button_Print.BackColor = Color.White;
            }

            button.ForeColor = Color.Black;
            button.BackColor = Color.LightGray;
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void button_Data_Base_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button_mail.ForeColor =  button_Navigation.ForeColor = button_Print.ForeColor = Color.MidnightBlue;
            button_mail.BackColor =  button_Navigation.BackColor = button_Print.BackColor = Color.White;
            panel_data_base.Visible = true;
            panel_View.Visible = panel_navigation.Visible = panel_print.Visible = panel_settengs_mail.Visible = false;
            button_Data_Base.ForeColor = Color.Black;
            button_Data_Base.BackColor = Color.LightGray;
            flag = 1;

        }


        private void button_mail_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button_Data_Base.ForeColor = button_Navigation.ForeColor = button_Print.ForeColor = Color.MidnightBlue;
            button_Data_Base.BackColor = button_Navigation.BackColor = button_Print.BackColor = Color.White;
            panel_settengs_mail.Visible = true;
            panel_View.Visible = panel_data_base.Visible = panel_navigation.Visible = panel_print.Visible =  false;
            button.ForeColor = Color.Black;
            button.BackColor = Color.LightGray;
            flag = 2;
        }

        private void button_Navigation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button_mail.ForeColor = button_Data_Base.ForeColor = button_Print.ForeColor = Color.MidnightBlue;
            button_mail.BackColor = button_Data_Base.BackColor = button_Print.BackColor = Color.White;
            panel_navigation.Visible = true;
            panel_View.Visible = panel_data_base.Visible = panel_settengs_mail.Visible = panel_print.Visible = false;
            button.ForeColor = Color.Black;
            button.BackColor = Color.LightGray;
            flag = 3;
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button_mail.ForeColor = button_Navigation.ForeColor = button_mail.ForeColor = Color.MidnightBlue;
            button_mail.BackColor = button_Navigation.BackColor = button_mail.BackColor = Color.White;
            panel_print.Visible =  true;
            panel_View.Visible = panel_data_base.Visible = panel_settengs_mail.Visible = panel_navigation.Visible = false;
            button.ForeColor = Color.Black;
            button.BackColor = Color.LightGray;
            flag = 4;
           
        }

        private void button_Data_Base_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (flag == 1)
            {
                button_mail.ForeColor = button_Navigation.ForeColor = button_Print.ForeColor = Color.MidnightBlue;
                button_mail.BackColor = button_Navigation.BackColor = button_Print.BackColor = Color.White;

            }
            else if (flag == 2)
            {
                button_Data_Base.ForeColor = button_Navigation.ForeColor = button_Print.ForeColor = Color.MidnightBlue;
                button_Data_Base.BackColor = button_Navigation.BackColor = button_Print.BackColor = Color.White;

            }
            else if (flag == 3)
            {
                button_mail.ForeColor = button_Data_Base.ForeColor = button_Print.ForeColor = Color.MidnightBlue;
                button_mail.BackColor = button_Data_Base.BackColor = button_Print.BackColor = Color.White;

            }
            else if (flag == 4)
            {
                button_mail.ForeColor = button_Navigation.ForeColor = button_mail.ForeColor = Color.MidnightBlue;
                button_mail.BackColor = button_Navigation.BackColor = button_mail.BackColor = Color.White;
 
            }
            else if (flag == 5)
            {
                button_Data_Base.ForeColor = button_mail.ForeColor = button_Navigation.ForeColor = button_Print.ForeColor = Color.MidnightBlue;
                button_Data_Base.BackColor = button_mail.BackColor = button_Navigation.BackColor = button_Print.BackColor = Color.White;
            }          
            else
            {
                button_View.ForeColor = button_Data_Base.ForeColor = button_mail.ForeColor = button_Navigation.ForeColor = button_Print.ForeColor = Color.MidnightBlue;
                button_View.BackColor = button_Data_Base.BackColor = button_mail.BackColor = button_Navigation.BackColor = button_Print.BackColor = Color.White;
                button.ForeColor = Color.MidnightBlue;
                button.BackColor = Color.White;
            }            
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_View_Click(object sender, EventArgs e)        {
            
            button_Data_Base.ForeColor = button_mail.ForeColor = button_Navigation.ForeColor = button_Print.ForeColor = Color.MidnightBlue;
            button_Data_Base.BackColor = button_mail.BackColor = button_Navigation.BackColor = button_Print.BackColor = Color.White;
            panel_View.Visible = true;
            panel_print.Visible = panel_data_base.Visible = panel_settengs_mail.Visible = panel_navigation.Visible = false;
            button_View.ForeColor = Color.Black;
            button_View.BackColor = Color.LightGray;
            flag = 5;
        }
    }
}

