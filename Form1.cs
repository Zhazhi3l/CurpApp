using BibliotecaCURPControl;

namespace CurpApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerarCURP curpsita = new GenerarCURP();
            this.Controls.Add(curpsita);
            curpsita.Location = new System.Drawing.Point(10, 10);
        }

    }
}
