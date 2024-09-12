using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyonu
{
    public partial class Ascim : Form
    {
        public Ascim()
        {
            InitializeComponent();
        }

        private void Asçı_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet11.Hazir' table. You can move, or remove it, as needed.
            this.hazirTableAdapter.Fill(this.otelDataSet11.Hazir);
            // TODO: This line of code loads data into the 'otelDataSet10.Hazirlaniyor' table. You can move, or remove it, as needed.
            this.hazirlaniyorTableAdapter.Fill(this.otelDataSet10.Hazirlaniyor);

        }
    }
}
