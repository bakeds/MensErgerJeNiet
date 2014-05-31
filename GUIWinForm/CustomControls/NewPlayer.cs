﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIWinForm.CustomControls
{
    public class NewPlayer : GroupBox
    {
        #region private fields

        Label lNaam = new Label();
        TextBox tNaam = new TextBox();

        #endregion


        #region constructors
        public NewPlayer()
        {
            this.Top = 40;
            this.Text = "Speler {0}";
            this.Size = new System.Drawing.Size(200, 50);

            //lnaam is een label met de text
            this.lNaam.Text = "Naam:";
            this.lNaam.Top = 15;
            this.lNaam.Left = 10;
            this.lNaam.Width = 70;
            this.Controls.Add(this.lNaam);

            //tnaam
            this.tNaam.Left = 80;
            this.tNaam.Top = 15;
            this.Controls.Add(this.tNaam);
        }

        #endregion
    }
}
