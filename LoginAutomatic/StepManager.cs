using LoginAutomatic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Converters;

namespace LoginAutomatic
{
    public partial class StepManager : Form
    {
        public StepManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void StepManager_Load(object sender, EventArgs e)
        {
            LoadStepsFromConfig();
        }

        private void LoadStepsFromConfig()
        {
            var _json1 = StepsHelper.GetAppConfig("step1");
            var _json2 = StepsHelper.GetAppConfig("step2");

            if (!string.IsNullOrWhiteSpace(_json1))
            {
                StepModel model1 = Newtonsoft.Json.JsonConvert.DeserializeObject<StepModel>(_json1);
            }

            if (!string.IsNullOrWhiteSpace(_json2))
            {
                StepModel model2 = Newtonsoft.Json.JsonConvert.DeserializeObject<StepModel>(_json2);
            }
        }
    }
}
