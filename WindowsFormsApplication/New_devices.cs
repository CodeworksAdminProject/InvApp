using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    class New_devices
    {
        DAL_GET dal_get = new DAL_GET();
        DAL_SET dalSet = new DAL_SET();
        BLL bll = new BLL();

        public string TypeAC { get; set; }              //+
        public string NumberINV { get; set; }           //+
        public string NameLAN { get; set; }             //+
        public string NameRes { get; set; }             //+
        public string Floor { get; set; }               //+
        public string Room { get; set; }                //+
        public string SN { get; set; }                  //+
        public string Model { get; set; }               //+ 
        public string TypeDevice { get; set; }          //+
        public string JiraTask { get; set; }            //+
        public string Note { get; set; }                //+
        public string Suma { get; set; }                //+
        public int Sumaint { get; set; }                //+
        public string HardwareType { get; set; }        //+
                            
              
        public void AddMAinInDataBase()
        {
            dalSet.SetNewPosition(
                bll.Get_ID("TypeAC", "TypeAC", TypeAC).ToString(),
                bll.Get_ID("TypeDevice", "NameDevice", TypeDevice).ToString(),
                Model,
                SN, 
                bll.Get_ID("NameRes","NameRes", NameRes).ToString(),
                bll.Get_ID("NameLAN", "NameLAN", NameLAN).ToString(), 
                bll.Get_ID("Floor","floorNambe", Floor).ToString(),
                bll.Get_ID("Room", "NameRoom",Room).ToString(),
                NumberINV,
                bll.Get_ID("JiraTask", "JiraTask", JiraTask).ToString()
                );


            bll.BodyMailNew(
                NumberINV,
                NameLAN,
                NameRes,
                Floor, 
                Room,
                TypeDevice, 
                SN, 
                Model, 
                JiraTask);

            dalSet.AddFDB(Environment.UserName, 4, 
                "В комната:" + Room + " приписан к PC: " + NameLAN,
                NumberINV,
                TypeDevice, 
                SN, 
                Model,
                dal_get.get_max_ID("[dbo].[MainTB]")
                );
        }

        public void AddHWStockRoom()
        {
            dalSet.SetNewPosition(
                bll.Get_ID("[TypeHardWare]", "[TypeHardWare]", HardwareType).ToString(),
                Model,
                SN,
                Sumaint,
                NumberINV,
                bll.Get_ID("JiraTask", "JiraTask", JiraTask).ToString()
                );

            bll.new_Hardware_Into_StockRoom(
                NumberINV,
                HardwareType, 
                SN,
                Model,
                JiraTask, 
                "1");

            dalSet.AddFDB(Environment.UserName, 5,
                "Добавлено на склад, 1 шт.", 
                NumberINV,
                HardwareType, 
                SN, 
                Model, 
                dal_get.get_max_ID("[dbo].[HardwareStockRoom]"));
        }
    }
}
