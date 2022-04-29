using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log4Net
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Info("Merhaba");
            try
            {
                throw new Exception("Exception!");
            }
            catch (Exception exception)
            {
                log.Error("This is a error", exception);
                
            }
        }
    }
}
