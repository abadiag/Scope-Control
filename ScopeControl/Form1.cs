using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScopeControl
{
    /// <summary>
    /// This Form Class has only ScopeView(Custom control)test pourposes
    /// </summary>
    public partial class Form1 : Form
    {
        //ScopeView doesn't need any parameter in his Constructor
        ScopeView Scope = new ScopeView();
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(Scope);
        }

        private void trackBarValue_ValueChanged(object sender, EventArgs e)
        {
            Scope.inputValue = trackBarValue.Value;
        }
        private void trackBarGridScale_ValueChanged(object sender, EventArgs e)
        {
            Scope.GridScale = trackBarGridScale.Value;
        }
        private void trackBarMatrixJump_ValueChanged(object sender, EventArgs e)
        {
            Scope.TimeStep = trackBarMatrixJump.Value;
        }
        private void trackBarTimerInt_ValueChanged(object sender, EventArgs e)
        {
            Scope.Speed = trackBarTimerInt.Value;
        }
    }
}
