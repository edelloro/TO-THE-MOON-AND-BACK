using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MoonAndBackCalculatorApplication.Engine;

public partial class View : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCalculate_Click(object sender, EventArgs e)
    {

        constantModel model = new constantModel();
        IconstantEngine engine = null;
        engine = model.GetconstantEngine();
        CalculatorResultModel rc = null;
        rc = engine.Calculate();
        txtResult.Text = "Value for PI " + rc.PI + "\n" +
                         "Calculation Time " + rc.CalculationTime.ToString() + " millisecond(s)" + "\n" + 
                         "Moon Volume " + rc.MoonVolume.ToString(); 


    }
}