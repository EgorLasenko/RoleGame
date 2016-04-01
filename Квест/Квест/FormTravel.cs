﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Квест
{
    public partial class FormTravel : Form
    {
        public FormTravel()
        {
            InitializeComponent();
            LabelHeal.Text = Globals.Heal.ToString();
            LabelLevel.Text = Globals.Level.ToString();
            LabelMoney.Text = Globals.Money.ToString();

        }

        private void FormTravel_Load(object sender, EventArgs e)
        {

            if (id.Maps == 1)
            {
                Button Location0 = new Button();
                Location0.Location = new Point(150, 50);
                Location0.Size = new Size(150, 25);
                Location0.Text = "Деревня Новичков";
                Location0.Click += new EventHandler(Location0_Click);
                Controls.Add(Location0);

                Button Location1 = new Button();
                Location1.Location = new Point(150, 75);
                Location1.Size = new Size(150, 25);
                Location1.Text = "Ферма";
                Location1.Click += new EventHandler(Location1_Click);
                Controls.Add(Location1);


                Button Location2 = new Button();
                Location2.Location = new Point(150, 100);
                Location2.Size = new Size(150, 25);
                Location2.Text = "АТП";
                Location2.Click += new EventHandler(Location2_Click);
                Controls.Add(Location2);

                Button Location3 = new Button();
                Location3.Location = new Point(150, 125);
                Location3.Size = new Size(150, 25);
                Location3.Text = "НИИ Агропром";
                Location3.Click += new EventHandler(Location3_Click);
                Controls.Add(Location3);

                Button Location4 = new Button();
                Location4.Location = new Point(150, 150);
                Location4.Size = new Size(150, 25);
                Location4.Text = "Темная Долина";
                Location4.Click += new EventHandler(Location4_Click);
                Controls.Add(Location4);
            }

        }

        private void Location0_Click(object sender, EventArgs e)
        {
            if (id.Location == 0)
            {
                MessageBox.Show("Ты уже в Деревне новичков.");
            }

            if (id.Location == 1)
            {
                Random rand = new Random();
                int attack = rand.Next(1, 5);
                if (attack == 3)
                {
                    FormSelectGun form2 = new FormSelectGun();
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                    Random rand1 = new Random();
                    id.Monster = rand1.Next(1, 10);
                }
                else
                {
                    
                    FormVillage form2 = new FormVillage();
                    this.Hide();
                    form2.ShowDialog();
                    this.Show();
                }
            }
            if (id.Location !=0 && id.Location !=1)
            {
                MessageBox.Show("Ты слишком далеко от Деревни новичков, а телепорт пока не придумали. \nВ Деревню Новичков можно попасть из локации «Ферма»");
            }
        }
        private void Location1_Click(object sender, EventArgs e)
        {
            if (id.Location == 1)
            {
                MessageBox.Show("Ты уже на Ферме");
            }
            if (id.Location != 0 && id.Location != 2)
            {
                MessageBox.Show("Ты слишком далеко от Фермы, а телепорт пока не придумали. \nВ На Ферму можно попасть из локаций «Деревня Новичков» и «АТП»");
            }

            if (id.Location == 0 || id.Location == 2)
            {
                Random rand = new Random();
                int attack = rand.Next(1, 5);
               
                if (attack == 3)
                {
                    Random rand1 = new Random();
                    id.Monster = rand1.Next(1, 10);
                    id.Location = 1;
                    FormSelectGun form2 = new FormSelectGun();
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                }

                else
                {
                    id.Location = 1;
                    FormLocation form2 = new FormLocation();
                    this.Hide();
                    form2.ShowDialog();
                    this.Show();
                }
            }
            

        }
        private void Location2_Click(object sender, EventArgs e)
        {
            if (id.Location == 2)
            {
                MessageBox.Show("Ты уже на АТП");
            }
            if (id.Location != 1 && id.Location != 3)
            {
                MessageBox.Show("Ты слишком далеко от АТП, а телепорт пока не придумали. \nВ На АТП можно попасть из локаций «Ферма» и «НИИ Агропром»");
            }

            if (id.Location == 1 || id.Location == 3)
            {
                Random rand = new Random();
                int attack = rand.Next(1, 5);

                if (attack == 3)
                {
                    Random rand1 = new Random();
                    id.Monster = rand1.Next(1, 10);
                    id.Location = 2;
                    FormSelectGun form2 = new FormSelectGun();
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                }

                else
                {
                    id.Location = 2;
                    FormLocation form2 = new FormLocation();
                    this.Hide();
                    form2.ShowDialog();
                    this.Show();
                }
            }

        }
        private void Location3_Click(object sender, EventArgs e)
        {
            if (id.Location == 3)
            {
                MessageBox.Show("Ты уже на НИИ Агропром");
            }
            if (id.Location != 2 && id.Location != 4)
            {
                MessageBox.Show("Ты слишком далеко от НИИ Агропром, а телепорт пока не придумали. \nВ На НИИ Агропром можно попасть из локаций «АТП» и «Темная Долина»");
            }

            if (id.Location == 2 || id.Location == 4)
            {
                Random rand = new Random();
                int attack = rand.Next(1, 5);
                if (attack == 3)
                {
                    Random rand1 = new Random();
                    id.Monster = rand1.Next(1, 10);
                    id.Location = 3;
                    FormSelectGun form2 = new FormSelectGun();
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                }

                else
                {
                    id.Location = 3;
                    FormLocation form2 = new FormLocation();
                    this.Hide();
                    form2.ShowDialog();
                    this.Show();
                }
            }
        }
        private void Location4_Click(object sender, EventArgs e)
        {
            if (id.Location == 4)
            {
                MessageBox.Show("Ты уже на НИИ Агропром");
            }
            if (id.Location != 3)
            {
                MessageBox.Show("Ты слишком далеко от Темной Долины, а телепорт пока не придумали. \nВ  Вемную Долину можно попасть из локации «НИИ Агропром»");
            }

            if (id.Location == 3)
            {
                Random rand = new Random();
                int attack = rand.Next(1, 5);
                if (attack == 3)
                {
                    Random rand1 = new Random();
                    id.Monster = rand1.Next(1, 10);
                    id.Location = 4;
                    FormSelectGun form2 = new FormSelectGun();
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                }

                else
                {
                    id.Location = 4;
                    FormLocation form2 = new FormLocation();
                    this.Hide();
                    form2.ShowDialog();
                    this.Show();
                }
            }

        }
        private void PDAButton_Click(object sender, EventArgs e)
        {
            PDA form3 = new PDA();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            inventory form2 = new inventory();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Globals s = new Globals();
            s.Save();
            MessageBox.Show("Процесс игры сохранен.");
        }
    }
}
