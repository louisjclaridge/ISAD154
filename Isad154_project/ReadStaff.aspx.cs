using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json;
using Isad154_project.Classes;

namespace Isad154_project
{
    public partial class ReadStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void readStaff()
        {
            using (StreamReader s = new StreamReader(@"C:/Users/logan/Documents/GitHub/ISAD154/Isad154_project/App_Data/staff.json"))
            {
                string json = s.ReadToEnd();
                List<Staff> items = JsonConvert.DeserializeObject<List<Staff>>(json);
            }
        }
        public static List<Staff> getallStaff()
        {
            using (StreamReader s = new StreamReader(@"C:/Users/logan/Documents/GitHub/ISAD154/Isad154_project/App_Data/staff.json"))
            {
                string json = s.ReadToEnd();
                List<Staff> items = JsonConvert.DeserializeObject<List<Staff>>(json);
                return items;
            }
        }
        public void outputStaff()
        {
            lstStaff.Items.Clear();
            foreach (Staff t in getallStaff())
            {
                lstStaff.Items.Add(t.getStaffInfo());
            }
        }
    }
}