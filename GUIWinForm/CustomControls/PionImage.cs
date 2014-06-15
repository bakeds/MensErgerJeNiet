﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GUIWinForm.Screen;

namespace GUIWinForm
{
    public class PionImage : PictureBox
    {
        private MensErgerJeNietLogic.Pion lPion;
        private BordPositions bordPositions = new BordPositions();
        //PictureBox picturebox2;

        public event EventHandler Click;


        #region constructors
        
        /// <summary>
        /// maak een pion en bepaal de kleur
        /// </summary>
        /// <param name="kleur">kleur die hij in het spel krijgt</param>
        public PionImage(Color kleur, MensErgerJeNietLogic.Pion logicPion)
        {
            this.lPion = logicPion;
            this.SetCollorImage(kleur);
            this.configPion();
            this.SetSelectedPion();
            
            // Eventlisteners toevoegen
            logicPion.OnVerplaatst += logicPion_Verplaatst;
            logicPion.Verplaatsbaar += logicPion_Verplaatsbaar;
        }

        public PionImage(Color kleur)
        {
            
            this.SetCollorImage(kleur);
            this.configPion();
            

 
        }
        #endregion

        /// <summary>
        /// Zorgt dat de pion verandert zodat de gebruiker weet dat de pion klikbaar is. Gebeurt zodra "logicgpion_verplaatsbaar" wordt aangeroepen 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void logicPion_Verplaatsbaar(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Verplaats de pion automatisch zodra het event "logicPion_Verplaatst" word aangeroepen 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void logicPion_Verplaatst(object sender, EventArgs e)
        {
            
            Point nieuwelocatie = bordPositions.GetPosition(lPion.Locatie);

            // x bewerking en y bewerking
            nieuwelocatie.X *= 65 + 453;
            nieuwelocatie.Y *= -1* 58 + 26;
            this.Location = nieuwelocatie;
        }

        private void configPion()
        {
            this.Size = new System.Drawing.Size(42, 60);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TabIndex = 8;
            this.TabStop = false;
            this.BackColor = System.Drawing.Color.Transparent;

        }

        void SetCollorImage(Color kleur)
        {
            switch(kleur)
            {
                case Color.blauw:
                    this.Image = global::GUIWinForm.Properties.Resources.pion_blauw;
                    break;
                case Color.geel:
                    this.Image = global::GUIWinForm.Properties.Resources.pion_geel;
                    break;
                case Color.groen:
                    this.Image = global::GUIWinForm.Properties.Resources.pion_groen;
                    break;
                case Color.rood:
                    this.Image = global::GUIWinForm.Properties.Resources.pion_rood;
                    break;
            }
        }

        // methode om de gebruiker te laten zien dat de pion selecteerbaar is 
        /// <summary>
        /// Om de gebruiker te laten zien dat de pion selecteerbaar is 
        /// </summary>
        private void SetSelectedPion()
        {
            //MensErgerJeNietLogic.Pion pion;
            this.Click += PionImage_Click;
        }

        void PionImage_Click(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.Fixed3D;
           
        }

    }
}

/*
this.pictureBox2.Image = global::GUIWinForm.Properties.Resources.pion_rood;
            this.pictureBox2.Location = new System.Drawing.Point(679, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
*/
