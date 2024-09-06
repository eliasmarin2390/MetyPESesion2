using MyApp1.Clase

using Sesion2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp1
{
    public partial class FrmPrincipal1 : Form
    {
        public FrmPrincipal1()
        {
            InitializeComponent();
        }

        private void FrmPrincipal1_Load(object sender, EventArgs e)
        {
            persona = new persona();
            Persona.Nombre = tbNombre.Text;
            persoma.FechaNac = dtpFechaNac.Text;
            MessageBox.Show(Persona.EvaluarEdad());
            

            
        }

       
        

        
    

