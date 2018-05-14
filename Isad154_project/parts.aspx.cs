using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Newtonsoft.Json;
using System.Web.UI.WebControls;
using System.IO;

namespace Isad154_project
{
	public partial class parts : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
           

            OutputParts();

        }
        private void OutputParts()
        {

            //lstBoxCommodity.Items.Clear();

            List<Parts> newW = Parts.getParts();

            foreach (Parts a in Parts.getParts())
            {
                lstBoxCommodity.Items.Add(a.getCommodityPartsDisplayFormat());
                lstBoxSpecialised.Items.Add(a.getSpecialisedPartsDisplayFormula());
                lstBoxReturns.Items.Add(a.getReturnsPartsDisplayFormula());

            }
        }
        


       
    }
}