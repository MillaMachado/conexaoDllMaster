﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexaoDllMaster;

namespace ApptestaDLL
{
    public partial class frmTestar : Form
    {
        public frmTestar()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            clsPostgres objConn =
                new clsPostgres("LocalHost",
                    "AgendaAula",
                    "xxxx");
            objConn.Conectar();

            
            

        }
    }
}
