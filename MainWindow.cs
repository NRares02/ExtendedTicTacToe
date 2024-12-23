﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedTicTacToe
{
    public partial class MainWindow : Form
    {
        private bool isXTurn = true; // Dacă este rândul lui X
        private int turnCount = 0;   // Numără câte mutări s-au făcut
        private int turnCount2 = 0;
        private int turnCount3 = 0;
        private int turnCount4 = 0;
        private int turnCount5 = 0;
        private int turnCount6 = 0;
        private int turnCount7 = 0;
        private int turnCount8 = 0;
        private int turnCount9 = 0;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Dacă butonul nu este deja apăsat (fără text), plasăm X sau O
            if (btn.Text == "")
            {
                if (isXTurn)
                {
                    btn.Text = "X";
                }
                else
                {
                    btn.Text = "O";
                }

                // Schimbă rândul
                isXTurn = !isXTurn;
                turnCount++;

                if (turnCount > 2)
                {
                    CheckWinner();
                }

                if (btn.Name== "btn1_gb1")
                {
                    if (LBLGB1.Text == "")
                    {
                        groupBox1.Enabled = true;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn2_gb1")
                {
                    if (LBLGB2.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = true;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if(btn.Name == "btn3_gb1")
                {
                    if (lblgb3.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = true;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn4_gb1")
                {
                    if (lblgb4.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = true;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn5_gb1")
                {
                    if (lblgb5.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = true;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn6_gb1")
                {
                    if (lblgb6.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = true;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn7_gb1")
                {
                    if (lblgb7.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = true;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn8_gb1")
                {
                    if (lblgb8.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = true;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn9_gb1")
                {
                    if (lblgb9.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = true;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }

                // Verifică dacă avem un câștigător

            }
        }
        private void button_Click2(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Dacă butonul nu este deja apăsat (fără text), plasăm X sau O
            if (btn.Text == "")
            {
                if (isXTurn)
                {
                    btn.Text = "X";
                }
                else
                {
                    btn.Text = "O";
                }

                // Schimbă rândul
                isXTurn = !isXTurn;
                turnCount2++;

                // Verifică dacă avem un câștigător
                if (turnCount2 > 2)
                {
                    CheckWinner2();
                }

                if (btn.Name == "btn1_gb2")
                {
                    if (LBLGB1.Text == "")
                    {
                        groupBox1.Enabled = true;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn2_gb2")
                {
                    if (LBLGB2.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = true;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn3_gb2")
                {
                    if (lblgb3.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = true;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn4_gb2")
                {
                    if (lblgb4.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = true;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn5_gb2")
                {
                    if (lblgb5.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = true;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn6_gb2")
                {
                    if (lblgb6.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = true;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn7_gb2")
                {
                    if (lblgb7.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = true;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn8_gb2")
                {
                    if (lblgb8.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = true;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn9_gb2")
                {
                    if (lblgb9.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = true;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }

                
            }
        }
        private void button_Click3(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Dacă butonul nu este deja apăsat (fără text), plasăm X sau O
            if (btn.Text == "")
            {
                if (isXTurn)
                {
                    btn.Text = "X";
                }
                else
                {
                    btn.Text = "O";
                }

                // Schimbă rândul
                isXTurn = !isXTurn;
                turnCount3++;

                // Verifică dacă avem un câștigător
                if (turnCount3 > 2)
                {
                    CheckWinner3();
                }

                if (btn.Name == "btn1_gb3")
                {
                    if (LBLGB1.Text == "")
                    {
                        groupBox1.Enabled = true;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn2_gb3")
                {
                    if (LBLGB2.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = true;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn3_gb3")
                {
                    if (lblgb3.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = true;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn4_gb3")
                {
                    if (lblgb4.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = true;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn5_gb3")
                {
                    if (lblgb5.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = true;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn6_gb3")
                {
                    if (lblgb6.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = true;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn7_gb3")
                {
                    if (lblgb7.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = true;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn8_gb3")
                {
                    if (lblgb8.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = true;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn9_gb3")
                {
                    if (lblgb9.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = true;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }

            }
        }
        private void button_Click4(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Dacă butonul nu este deja apăsat (fără text), plasăm X sau O
            if (btn.Text == "")
            {
                if (isXTurn)
                {
                    btn.Text = "X";
                }
                else
                {
                    btn.Text = "O";
                }

                // Schimbă rândul
                isXTurn = !isXTurn;
                turnCount4++;

                // Verifică dacă avem un câștigător
                if (turnCount4++ > 2)
                {
                    CheckWinner4();
                }

                if (btn.Name == "btn1_gb4")
                {
                    if (LBLGB1.Text == "")
                    {
                        groupBox1.Enabled = true;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn2_gb4")
                {
                    if (LBLGB2.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = true;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn3_gb4")
                {
                    if (lblgb3.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = true;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn4_gb4")
                {
                    if (lblgb4.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = true;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn5_gb4")
                {
                    if (lblgb5.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = true;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn6_gb4")
                {
                    if (lblgb6.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = true;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn7_gb4")
                {
                    if (lblgb7.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = true;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn8_gb4")
                {
                    if (lblgb8.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = true;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn9_gb4")
                {
                    if (lblgb9.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = true;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
            }
        }
        private void button_Click5(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Dacă butonul nu este deja apăsat (fără text), plasăm X sau O
            if (btn.Text == "")
            {
                if (isXTurn)
                {
                    btn.Text = "X";
                }
                else
                {
                    btn.Text = "O";
                }

                // Schimbă rândul
                isXTurn = !isXTurn;
                turnCount5++;

                // Verifică dacă avem un câștigător
                if (turnCount5++ > 2)
                {
                    CheckWinner5();
                }

                if (btn.Name == "btn1_gb5")
                {
                    if (LBLGB1.Text == "")
                    {
                        groupBox1.Enabled = true;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn2_gb5")
                {
                    if (LBLGB2.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = true;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn3_gb5")
                {
                    if (lblgb3.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = true;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn4_gb5")
                {
                    if (lblgb4.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = true;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn5_gb5")
                {
                    if (lblgb5.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = true;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn6_gb5")
                {
                    if (lblgb6.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = true;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn7_gb5")
                {
                    if (lblgb7.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = true;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn8_gb5")
                {
                    if (lblgb8.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = true;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn9_gb5")
                {
                    if (lblgb9.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = true;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
            }
        }
        private void button_Click6(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Dacă butonul nu este deja apăsat (fără text), plasăm X sau O
            if (btn.Text == "")
            {
                if (isXTurn)
                {
                    btn.Text = "X";
                }
                else
                {
                    btn.Text = "O";
                }

                // Schimbă rândul
                isXTurn = !isXTurn;
                turnCount6++;

                // Verifică dacă avem un câștigător
                if (turnCount6 > 2)
                {
                    CheckWinner6();
                }

                if (btn.Name == "btn1_gb6")
                {
                    if (LBLGB1.Text == "")
                    {
                        groupBox1.Enabled = true;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn2_gb6")
                {
                    if (LBLGB2.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = true;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn3_gb6")
                {
                    if (lblgb3.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = true;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn4_gb6")
                {
                    if (lblgb4.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = true;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn5_gb6")
                {
                    if (lblgb5.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = true;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn6_gb6")
                {
                    if (lblgb6.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = true;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn7_gb6")
                {
                    if (lblgb7.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = true;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn8_gb6")
                {
                    if (lblgb8.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = true;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn9_gb6")
                {
                    if (lblgb9.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = true;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
            }
        }
        private void button_Click7(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Dacă butonul nu este deja apăsat (fără text), plasăm X sau O
            if (btn.Text == "")
            {
                if (isXTurn)
                {
                    btn.Text = "X";
                }
                else
                {
                    btn.Text = "O";
                }

                // Schimbă rândul
                isXTurn = !isXTurn;
                turnCount7++;

                // Verifică dacă avem un câștigător
                if (turnCount7 > 2)
                {
                    CheckWinner7();
                }

                if (btn.Name == "btn1_gb7")
                {
                    if (LBLGB1.Text == "")
                    {
                        groupBox1.Enabled = true;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn2_gb7")
                {
                    if (LBLGB2.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = true;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn3_gb7")
                {
                    if (lblgb3.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = true;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn4_gb7")
                {
                    if (lblgb4.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = true;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn5_gb7")
                {
                    if (lblgb5.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = true;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn6_gb7")
                {
                    if (lblgb6.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = true;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn7_gb7")
                {
                    if (lblgb7.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = true;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn8_gb7")
                {
                    if (lblgb8.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = true;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn9_gb7")
                {
                    if (lblgb9.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = true;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }

                
            }
        }
        private void button_Click8(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Dacă butonul nu este deja apăsat (fără text), plasăm X sau O
            if (btn.Text == "")
            {
                if (isXTurn)
                {
                    btn.Text = "X";
                }
                else
                {
                    btn.Text = "O";
                }

                // Schimbă rândul
                isXTurn = !isXTurn;
                turnCount8++;
                
                // Verifică dacă avem un câștigător
                if (turnCount8 > 2)
                {
                    CheckWinner8();
                }

                if (btn.Name == "btn1_gb8")
                {
                    if (LBLGB1.Text == "")
                    {
                        groupBox1.Enabled = true;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn2_gb8")
                {
                    if (LBLGB2.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = true;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn3_gb8")
                {
                    if (lblgb3.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = true;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn4_gb8")
                {
                    if (lblgb4.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = true;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn5_gb8")
                {
                    if (lblgb5.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = true;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn6_gb8")
                {
                    if (lblgb6.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = true;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn7_gb8")
                {
                    if (lblgb7.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = true;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn8_gb8")
                {
                    if (lblgb8.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = true;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn9_gb8")
                {
                    if (lblgb9.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = true;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
            }
        }
        private void button_Click9(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Dacă butonul nu este deja apăsat (fără text), plasăm X sau O
            if (btn.Text == "")
            {
                if (isXTurn)
                {
                    btn.Text = "X";
                }
                else
                {
                    btn.Text = "O";
                }

                // Schimbă rândul
                isXTurn = !isXTurn;
                turnCount9++;

                // Verifică dacă avem un câștigător
                if (turnCount9 > 2)
                {
                    CheckWinner9();
                }

                if (btn.Name == "btn1_gb9")
                {
                    if (LBLGB1.Text == "")
                    {
                        groupBox1.Enabled = true;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn2_gb9")
                {
                    if (LBLGB2.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = true;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn3_gb9")
                {
                    if (lblgb3.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = true;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn4_gb9")
                {
                    if (lblgb4.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = true;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn5_gb9")
                {
                    if (lblgb5.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = true;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn6_gb9")
                {
                    if (lblgb6.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = true;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn7_gb9")
                {
                    if (lblgb7.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = true;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn8_gb9")
                {
                    if (lblgb8.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = true;
                        groupBox9.Enabled = false;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
                else if (btn.Name == "btn9_gb9")
                {
                    if (lblgb9.Text == "")
                    {
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        groupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox8.Enabled = false;
                        groupBox9.Enabled = true;
                    }
                    else
                    {
                        CheckIfSectionIsActive();
                    }
                }
            }
        }

        private void CheckWinner()
        {
            bool winnerFound = false;
            //bool winnerFound1 = false;

            // Verificăm toate liniile orizontale, verticale și diagonale pentru câștigător
            if ((btn1_gb1.Text == btn2_gb1.Text) && (btn2_gb1.Text == btn3_gb1.Text) && (btn1_gb1.Text != ""))
                winnerFound = true;
            else if ((btn4_gb1.Text == btn5_gb1.Text) && (btn5_gb1.Text == btn6_gb1.Text) && (btn4_gb1.Text != ""))
                winnerFound = true;
            else if ((btn7_gb1.Text == btn8_gb1.Text) && (btn8_gb1.Text == btn9_gb1.Text) && (btn7_gb1.Text != ""))
                winnerFound = true;
            else if ((btn1_gb1.Text == btn4_gb1.Text) && (btn4_gb1.Text == btn7_gb1.Text) && (btn1_gb1.Text != ""))
                winnerFound = true;
            else if ((btn2_gb1.Text == btn5_gb1.Text) && (btn5_gb1.Text == btn8_gb1.Text) && (btn2_gb1.Text != ""))
                winnerFound = true;
            else if ((btn3_gb1.Text == btn6_gb1.Text) && (btn6_gb1.Text == btn9_gb1.Text) && (btn3_gb1.Text != ""))
                winnerFound = true;
            else if ((btn1_gb1.Text == btn5_gb1.Text) && (btn5_gb1.Text == btn9_gb1.Text) && (btn1_gb1.Text != ""))
                winnerFound = true;
            else if ((btn3_gb1.Text == btn5_gb1.Text) && (btn5_gb1.Text == btn7_gb1.Text) && (btn3_gb1.Text != ""))
                winnerFound = true;

            if (winnerFound)
            {
                // Afișează un mesaj și resetează jocul
                string winner = isXTurn ? "O" : "X"; // Cel care a jucat ultimul câștigă
                MessageBox.Show($"{winner} este câștigător!");
                LBLGB1.Text = $"{winner} este câștigător!";
                groupBox1.Enabled = false;
                CheckWinnerGlobal();
            }
            else if (turnCount == 9)
            {
                // Dacă toate butoanele sunt apăsate și nu avem câștigător
                MessageBox.Show("Remiză!");
                LBLGB1.Text = "Remiză!";
            }
        }
        private void CheckWinner2()
        {
            bool winnerFound = false;
            //bool winnerFound1 = false;

            // Verificăm toate liniile orizontale, verticale și diagonale pentru câștigător
            //Gb2
            if ((btn1_gb2.Text == btn2_gb2.Text) && (btn2_gb2.Text == btn3_gb2.Text) && (btn1_gb2.Text != ""))
                winnerFound = true;
            else if ((btn4_gb2.Text == btn5_gb2.Text) && (btn5_gb2.Text == btn6_gb2.Text) && (btn4_gb2.Text != ""))
                winnerFound = true;
            else if ((btn7_gb2.Text == btn8_gb2.Text) && (btn8_gb2.Text == btn9_gb2.Text) && (btn7_gb2.Text != ""))
                winnerFound = true;
            else if ((btn1_gb2.Text == btn4_gb2.Text) && (btn4_gb2.Text == btn7_gb2.Text) && (btn1_gb2.Text != ""))
                winnerFound = true;
            else if ((btn2_gb2.Text == btn5_gb2.Text) && (btn5_gb2.Text == btn8_gb2.Text) && (btn2_gb2.Text != ""))
                winnerFound = true;
            else if ((btn3_gb2.Text == btn6_gb2.Text) && (btn6_gb2.Text == btn9_gb2.Text) && (btn3_gb2.Text != ""))
                winnerFound = true;
            else if ((btn1_gb2.Text == btn5_gb2.Text) && (btn5_gb2.Text == btn9_gb2.Text) && (btn1_gb2.Text != ""))
                winnerFound = true;
            else if ((btn3_gb2.Text == btn5_gb2.Text) && (btn5_gb2.Text == btn7_gb2.Text) && (btn3_gb2.Text != ""))
                winnerFound = true;

            if (winnerFound)
            {
                // Afișează un mesaj și resetează jocul
                string winner = isXTurn ? "O" : "X"; // Cel care a jucat ultimul câștigă
                MessageBox.Show($"{winner} este câștigător!");
                LBLGB2.Text = $"{winner} este câștigător!";
                groupBox2.Enabled = false;
                CheckWinnerGlobal();
            }
            else if (turnCount2 == 9)
            {
                // Dacă toate butoanele sunt apăsate și nu avem câștigător
                MessageBox.Show("Remiză!");
                LBLGB2.Text = "Remiză!";
            }
        }
        private void CheckWinner3()
        {
            bool winnerFound = false;
            //bool winnerFound1 = false;

            // Verificăm toate liniile orizontale, verticale și diagonale pentru câștigător
            //Gb2
            if ((btn1_gb3.Text == btn2_gb3.Text) && (btn2_gb3.Text == btn3_gb3.Text) && (btn1_gb3.Text != ""))
                winnerFound = true;
            else if ((btn4_gb3.Text == btn5_gb3.Text) && (btn5_gb3.Text == btn6_gb3.Text) && (btn4_gb3.Text != ""))
                winnerFound = true;
            else if ((btn7_gb3.Text == btn8_gb3.Text) && (btn8_gb3.Text == btn9_gb3.Text) && (btn7_gb3.Text != ""))
                winnerFound = true;
            else if ((btn1_gb3.Text == btn4_gb3.Text) && (btn4_gb3.Text == btn7_gb3.Text) && (btn1_gb3.Text != ""))
                winnerFound = true;
            else if ((btn2_gb3.Text == btn5_gb3.Text) && (btn5_gb3.Text == btn8_gb3.Text) && (btn2_gb3.Text != ""))
                winnerFound = true;
            else if ((btn3_gb3.Text == btn6_gb3.Text) && (btn6_gb3.Text == btn9_gb3.Text) && (btn3_gb3.Text != ""))
                winnerFound = true;
            else if ((btn1_gb3.Text == btn5_gb3.Text) && (btn5_gb3.Text == btn9_gb3.Text) && (btn1_gb3.Text != ""))
                winnerFound = true;
            else if ((btn3_gb3.Text == btn5_gb3.Text) && (btn5_gb3.Text == btn7_gb3.Text) && (btn3_gb3.Text != ""))
                winnerFound = true;

            if (winnerFound)
            {
                // Afișează un mesaj și resetează jocul
                string winner = isXTurn ? "O" : "X"; // Cel care a jucat ultimul câștigă
                MessageBox.Show($"{winner} este câștigător!");
                lblgb3.Text = $"{winner} este câștigător!";
                groupBox3.Enabled = false;
                CheckWinnerGlobal();
            }
            else if (turnCount3 == 9)
            {
                // Dacă toate butoanele sunt apăsate și nu avem câștigător
                MessageBox.Show("Remiză!");
                lblgb3.Text = "Remiză!";
            }
        }
        private void CheckWinner4()
        {
            bool winnerFound = false;
            //bool winnerFound1 = false;

            // Verificăm toate liniile orizontale, verticale și diagonale pentru câștigător
            //Gb2
            if ((btn1_gb4.Text == btn2_gb4.Text) && (btn2_gb4.Text == btn3_gb4.Text) && (btn1_gb4.Text != ""))
                winnerFound = true;
            else if ((btn4_gb4.Text == btn5_gb4.Text) && (btn5_gb4.Text == btn6_gb4.Text) && (btn4_gb4.Text != ""))
                winnerFound = true;
            else if ((btn7_gb4.Text == btn8_gb4.Text) && (btn8_gb4.Text == btn9_gb4.Text) && (btn7_gb4.Text != ""))
                winnerFound = true;
            else if ((btn1_gb4.Text == btn4_gb4.Text) && (btn4_gb4.Text == btn7_gb4.Text) && (btn1_gb4.Text != ""))
                winnerFound = true;
            else if ((btn2_gb4.Text == btn5_gb4.Text) && (btn5_gb4.Text == btn8_gb4.Text) && (btn2_gb4.Text != ""))
                winnerFound = true;
            else if ((btn3_gb4.Text == btn6_gb4.Text) && (btn6_gb4.Text == btn9_gb4.Text) && (btn3_gb4.Text != ""))
                winnerFound = true;
            else if ((btn1_gb4.Text == btn5_gb4.Text) && (btn5_gb4.Text == btn9_gb4.Text) && (btn1_gb4.Text != ""))
                winnerFound = true;
            else if ((btn3_gb4.Text == btn5_gb4.Text) && (btn5_gb4.Text == btn7_gb4.Text) && (btn3_gb4.Text != ""))
                winnerFound = true;

            if (winnerFound)
            {
                // Afișează un mesaj și resetează jocul
                string winner = isXTurn ? "O" : "X"; // Cel care a jucat ultimul câștigă
                MessageBox.Show($"{winner} este câștigător!");
                lblgb4.Text = $"{winner} este câștigător!";
                groupBox4.Enabled = false;
                CheckWinnerGlobal();
            }
            else if (turnCount4 == 9)
            {
                // Dacă toate butoanele sunt apăsate și nu avem câștigător
                MessageBox.Show("Remiză!");
                lblgb4.Text = "Remiză!";
            }
        }
        private void CheckWinner5()
        {
            bool winnerFound = false;
            //bool winnerFound1 = false;

            // Verificăm toate liniile orizontale, verticale și diagonale pentru câștigător
            //Gb2
            if ((btn1_gb5.Text == btn2_gb5.Text) && (btn2_gb5.Text == btn3_gb5.Text) && (btn1_gb5.Text != ""))
                winnerFound = true;
            else if ((btn4_gb5.Text == btn5_gb5.Text) && (btn5_gb5.Text == btn6_gb5.Text) && (btn4_gb5.Text != ""))
                winnerFound = true;
            else if ((btn7_gb5.Text == btn8_gb5.Text) && (btn8_gb5.Text == btn9_gb5.Text) && (btn7_gb5.Text != ""))
                winnerFound = true;
            else if ((btn1_gb5.Text == btn4_gb5.Text) && (btn4_gb5.Text == btn7_gb5.Text) && (btn1_gb5.Text != ""))
                winnerFound = true;
            else if ((btn2_gb5.Text == btn5_gb5.Text) && (btn5_gb5.Text == btn8_gb5.Text) && (btn2_gb5.Text != ""))
                winnerFound = true;
            else if ((btn3_gb5.Text == btn6_gb5.Text) && (btn6_gb5.Text == btn9_gb5.Text) && (btn3_gb5.Text != ""))
                winnerFound = true;
            else if ((btn1_gb5.Text == btn5_gb5.Text) && (btn5_gb5.Text == btn9_gb5.Text) && (btn1_gb5.Text != ""))
                winnerFound = true;
            else if ((btn3_gb5.Text == btn5_gb5.Text) && (btn5_gb5.Text == btn7_gb5.Text) && (btn3_gb5.Text != ""))
                winnerFound = true;

            if (winnerFound)
            {
                // Afișează un mesaj și resetează jocul
                string winner = isXTurn ? "O" : "X"; // Cel care a jucat ultimul câștigă
                MessageBox.Show($"{winner} este câștigător!");
                lblgb5.Text = $"{winner} este câștigător!";
                groupBox5.Enabled = false;
                CheckWinnerGlobal();
            }
            else if (turnCount5 == 9)
            {
                // Dacă toate butoanele sunt apăsate și nu avem câștigător
                MessageBox.Show("Remiză!");
                lblgb5.Text = "Remiză!";
            }
        }
        private void CheckWinner6()
        {
            bool winnerFound = false;
            //bool winnerFound1 = false;

            // Verificăm toate liniile orizontale, verticale și diagonale pentru câștigător
            //Gb2
            if ((btn1_gb6.Text == btn2_gb6.Text) && (btn2_gb6.Text == btn3_gb6.Text) && (btn1_gb6.Text != ""))
                winnerFound = true;
            else if ((btn4_gb6.Text == btn5_gb6.Text) && (btn5_gb6.Text == btn6_gb6.Text) && (btn4_gb6.Text != ""))
                winnerFound = true;
            else if ((btn7_gb6.Text == btn8_gb6.Text) && (btn8_gb6.Text == btn9_gb6.Text) && (btn7_gb6.Text != ""))
                winnerFound = true;
            else if ((btn1_gb6.Text == btn4_gb6.Text) && (btn4_gb6.Text == btn7_gb6.Text) && (btn1_gb6.Text != ""))
                winnerFound = true;
            else if ((btn2_gb6.Text == btn5_gb6.Text) && (btn5_gb6.Text == btn8_gb6.Text) && (btn2_gb6.Text != ""))
                winnerFound = true;
            else if ((btn3_gb6.Text == btn6_gb6.Text) && (btn6_gb6.Text == btn9_gb6.Text) && (btn3_gb6.Text != ""))
                winnerFound = true;
            else if ((btn1_gb6.Text == btn5_gb6.Text) && (btn5_gb6.Text == btn9_gb6.Text) && (btn1_gb6.Text != ""))
                winnerFound = true;
            else if ((btn3_gb6.Text == btn5_gb6.Text) && (btn5_gb6.Text == btn7_gb6.Text) && (btn3_gb6.Text != ""))
                winnerFound = true;

            if (winnerFound)
            {
                // Afișează un mesaj și resetează jocul
                string winner = isXTurn ? "O" : "X"; // Cel care a jucat ultimul câștigă
                MessageBox.Show($"{winner} este câștigător!");
                lblgb6.Text = $"{winner} este câștigător!";
                groupBox6.Enabled = false;
                CheckWinnerGlobal();
            }
            else if (turnCount6 == 9)
            {
                // Dacă toate butoanele sunt apăsate și nu avem câștigător
                MessageBox.Show("Remiză!");
                lblgb6.Text = "Remiză!";
            }
        }
        private void CheckWinner7()
        {
            bool winnerFound = false;
            //bool winnerFound1 = false;

            // Verificăm toate liniile orizontale, verticale și diagonale pentru câștigător
            //Gb2
            if ((btn1_gb7.Text == btn2_gb7.Text) && (btn2_gb7.Text == btn3_gb7.Text) && (btn1_gb7.Text != ""))
                winnerFound = true;
            else if ((btn4_gb7.Text == btn5_gb7.Text) && (btn5_gb7.Text == btn6_gb7.Text) && (btn4_gb7.Text != ""))
                winnerFound = true;
            else if ((btn7_gb7.Text == btn8_gb7.Text) && (btn8_gb7.Text == btn9_gb7.Text) && (btn7_gb7.Text != ""))
                winnerFound = true;
            else if ((btn1_gb7.Text == btn4_gb7.Text) && (btn4_gb7.Text == btn7_gb7.Text) && (btn1_gb7.Text != ""))
                winnerFound = true;
            else if ((btn2_gb7.Text == btn5_gb7.Text) && (btn5_gb7.Text == btn8_gb7.Text) && (btn2_gb7.Text != ""))
                winnerFound = true;
            else if ((btn3_gb7.Text == btn6_gb7.Text) && (btn6_gb7.Text == btn9_gb7.Text) && (btn3_gb7.Text != ""))
                winnerFound = true;
            else if ((btn1_gb7.Text == btn5_gb7.Text) && (btn5_gb7.Text == btn9_gb7.Text) && (btn1_gb7.Text != ""))
                winnerFound = true;
            else if ((btn3_gb7.Text == btn5_gb7.Text) && (btn5_gb7.Text == btn7_gb7.Text) && (btn3_gb7.Text != ""))
                winnerFound = true;

            if (winnerFound)
            {
                // Afișează un mesaj și resetează jocul
                string winner = isXTurn ? "O" : "X"; // Cel care a jucat ultimul câștigă
                MessageBox.Show($"{winner} este câștigător!");
                lblgb7.Text = $"{winner} este câștigător!";
                groupBox7.Enabled = false;
                CheckWinnerGlobal();
            }
            else if (turnCount7 == 9)
            {
                // Dacă toate butoanele sunt apăsate și nu avem câștigător
                MessageBox.Show("Remiză!");
                lblgb7.Text = "Remiză!";
            }
        }
        private void CheckWinner8()
        {
            bool winnerFound = false;
            //bool winnerFound1 = false;

            // Verificăm toate liniile orizontale, verticale și diagonale pentru câștigător
            //Gb2
            if ((btn1_gb8.Text == btn2_gb8.Text) && (btn2_gb8.Text == btn3_gb8.Text) && (btn1_gb8.Text != ""))
                winnerFound = true;
            else if ((btn4_gb8.Text == btn5_gb8.Text) && (btn5_gb8.Text == btn6_gb8.Text) && (btn4_gb8.Text != ""))
                winnerFound = true;
            else if ((btn7_gb8.Text == btn8_gb8.Text) && (btn8_gb8.Text == btn9_gb8.Text) && (btn7_gb8.Text != ""))
                winnerFound = true;
            else if ((btn1_gb8.Text == btn4_gb8.Text) && (btn4_gb8.Text == btn7_gb8.Text) && (btn1_gb8.Text != ""))
                winnerFound = true;
            else if ((btn2_gb8.Text == btn5_gb8.Text) && (btn5_gb8.Text == btn8_gb8.Text) && (btn2_gb8.Text != ""))
                winnerFound = true;
            else if ((btn3_gb8.Text == btn6_gb8.Text) && (btn6_gb8.Text == btn9_gb8.Text) && (btn3_gb8.Text != ""))
                winnerFound = true;
            else if ((btn1_gb8.Text == btn5_gb8.Text) && (btn5_gb8.Text == btn9_gb8.Text) && (btn1_gb8.Text != ""))
                winnerFound = true;
            else if ((btn3_gb8.Text == btn5_gb8.Text) && (btn5_gb8.Text == btn7_gb8.Text) && (btn3_gb8.Text != ""))
                winnerFound = true;

            if (winnerFound)
            {
                // Afișează un mesaj și resetează jocul
                string winner = isXTurn ? "O" : "X"; // Cel care a jucat ultimul câștigă
                MessageBox.Show($"{winner} este câștigător!");
                lblgb8.Text = $"{winner} este câștigător!";
                groupBox8.Enabled = false;
                CheckWinnerGlobal();
            }
            else if (turnCount8 == 9)
            {
                // Dacă toate butoanele sunt apăsate și nu avem câștigător
                MessageBox.Show("Remiză!");
                lblgb8.Text = "Remiză!";
            }
        }
        private void CheckWinner9()
        {
            bool winnerFound = false;
            //bool winnerFound1 = false;

            // Verificăm toate liniile orizontale, verticale și diagonale pentru câștigător
            //Gb2
            if ((btn1_gb9.Text == btn2_gb9.Text) && (btn2_gb9.Text == btn3_gb9.Text) && (btn1_gb9.Text != ""))
                winnerFound = true;
            else if ((btn4_gb9.Text == btn5_gb9.Text) && (btn5_gb9.Text == btn6_gb9.Text) && (btn4_gb9.Text != ""))
                winnerFound = true;
            else if ((btn7_gb9.Text == btn8_gb9.Text) && (btn8_gb9.Text == btn9_gb9.Text) && (btn7_gb9.Text != ""))
                winnerFound = true;
            else if ((btn1_gb9.Text == btn4_gb9.Text) && (btn4_gb9.Text == btn7_gb9.Text) && (btn1_gb9.Text != ""))
                winnerFound = true;
            else if ((btn2_gb9.Text == btn5_gb9.Text) && (btn5_gb9.Text == btn8_gb9.Text) && (btn2_gb9.Text != ""))
                winnerFound = true;
            else if ((btn3_gb9.Text == btn6_gb9.Text) && (btn6_gb9.Text == btn9_gb9.Text) && (btn3_gb9.Text != ""))
                winnerFound = true;
            else if ((btn1_gb9.Text == btn5_gb9.Text) && (btn5_gb9.Text == btn9_gb9.Text) && (btn1_gb9.Text != ""))
                winnerFound = true;
            else if ((btn3_gb9.Text == btn5_gb9.Text) && (btn5_gb9.Text == btn7_gb9.Text) && (btn3_gb9.Text != ""))
                winnerFound = true;

            if (winnerFound)
            {
                // Afișează un mesaj și resetează jocul
                string winner = isXTurn ? "O" : "X"; // Cel care a jucat ultimul câștigă
                MessageBox.Show($"{winner} este câștigător!");
                lblgb9.Text = $"{winner} este câștigător!";
                groupBox9.Enabled = false;
                CheckWinnerGlobal();
            }
            else if (turnCount9 == 9)
            {
                // Dacă toate butoanele sunt apăsate și nu avem câștigător
                MessageBox.Show("Remiză!");
                lblgb9.Text = "Remiză!";
            }
        }

        private void CheckIfSectionIsActive()
        {
            if (LBLGB1.Text == "")
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }

            if (LBLGB2.Text == "")
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }

            if (lblgb3.Text == "")
            {
                groupBox3.Enabled = true;
            }
            else
            {
                groupBox3.Enabled = false;
            }

            if (lblgb4.Text == "")
            {
                groupBox4.Enabled = true;
            }
            else
            {
                groupBox4.Enabled = false;
            }

            if (lblgb5.Text == "")
            {
                groupBox5.Enabled = true;
            }
            else
            {
                groupBox5.Enabled = false;
            }

            if (lblgb6.Text == "")
            {
                groupBox6.Enabled = true;
            }
            else
            {
                groupBox6.Enabled = false;
            }

            if (lblgb7.Text == "")
            {
                groupBox7.Enabled = true;
            }
            else
            {
                groupBox7.Enabled = false;
            }

            if (lblgb8.Text == "")
            {
                groupBox8.Enabled = true;
            }
            else
            {
                groupBox8.Enabled = false;
            }

            if (lblgb9.Text == "")
            {
                groupBox9.Enabled = true;
            }
            else
            {
                groupBox9.Enabled = false;
            }
        }

        private void CheckWinnerGlobal()
        {
            bool winnerFound = false;
            //bool winnerFound1 = false;

            // Verificăm toate liniile orizontale, verticale și diagonale pentru câștigător
            //Gb2
            if ((LBLGB1.Text == LBLGB2.Text) && (LBLGB2.Text == lblgb3.Text) && (LBLGB1.Text != ""))
                winnerFound = true;
            else if ((lblgb4.Text == lblgb5.Text) && (lblgb5.Text == lblgb6.Text) && (lblgb4.Text != ""))
                winnerFound = true;
            else if ((lblgb7.Text == lblgb8.Text) && (lblgb8.Text == lblgb9.Text) && (lblgb7.Text != ""))
                winnerFound = true;
            else if ((LBLGB1.Text == lblgb4.Text) && (lblgb4.Text == lblgb7.Text) && (LBLGB1.Text != ""))
                winnerFound = true;
            else if ((LBLGB2.Text == lblgb5.Text) && (lblgb5.Text == lblgb8.Text) && (LBLGB2.Text != ""))
                winnerFound = true;
            else if ((lblgb3.Text == lblgb6.Text) && (lblgb6.Text == lblgb9.Text) && (lblgb3.Text != ""))
                winnerFound = true;
            else if ((LBLGB1.Text == lblgb5.Text) && (lblgb5.Text == lblgb9.Text) && (LBLGB1.Text != ""))
                winnerFound = true;
            else if ((lblgb3.Text == lblgb5.Text) && (lblgb5.Text == lblgb7.Text) && (lblgb3.Text != ""))
                winnerFound = true;

            if (winnerFound)
            {
                // Afișează un mesaj și resetează jocul
                string winner = isXTurn ? "O" : "X"; // Cel care a jucat ultimul câștigă
                MessageBox.Show($"{winner} este câștigător!");
                LBLGLOBAL.Visible = true;
                LBLGLOBAL.Text = $"{winner} este câștigător!";
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                groupBox8.Enabled = false;
                groupBox9.Enabled = false;
                //ResetGame();
            }
            else if (turnCount == 81)
            {
                // Dacă toate butoanele sunt apăsate și nu avem câștigător
                MessageBox.Show("Remiză!");
                LBLGLOBAL.Text = "Remiză!";
                //ResetGame();
            }
        }

        private void ResetButtons(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button)
                {
                    ((Button)c).Text = "";
                }
                else if (c.HasChildren)
                {
                    // Apel recursiv pentru a verifica și controalele din containere
                    ResetButtons(c);
                }
            }
        }


        private void btn_reset_Click(object sender, EventArgs e)
        {
            // Resetează butoanele și variabilele
            isXTurn = true;
            turnCount = 0;   // Numără câte mutări s-au făcut
            turnCount2 = 0;
            turnCount3 = 0;
            turnCount4 = 0;
            turnCount5 = 0;
            turnCount6 = 0;
            turnCount7 = 0;
            turnCount8 = 0;
            turnCount9 = 0;
            LBLGB1.Text = "";
            LBLGB2.Text = "";
            lblgb3.Text = "";
            lblgb4.Text = "";
            lblgb5.Text = "";
            lblgb6.Text = "";
            lblgb7.Text = "";
            lblgb8.Text = "";
            lblgb9.Text = "";
            LBLGLOBAL.Text = "";
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
            groupBox6.Enabled = true;
            groupBox7.Enabled = true;
            groupBox8.Enabled = true;
            groupBox9.Enabled = true;


            ResetButtons(this);
            btn_reset.Text = "Reset";

        }

        /*private void btn2_gb1_Click(object sender, EventArgs e)
        {
            // Dacă butonul nu este deja apăsat (fără text), plasăm X sau O
            if (btn2_gb1.Text == "")
            {
                if (isXTurn)
                {
                    btn2_gb1.Text = "X";
                }
                else
                {
                    btn2_gb1.Text = "O";
                }

                // Schimbă rândul
                isXTurn = !isXTurn;
                turnCount++;

                if (LBLGB2.Text == "")
                {
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = false;
                    groupBox4.Enabled = false;
                    groupBox5.Enabled = false;
                    groupBox6.Enabled = false;
                    groupBox7.Enabled = false;
                    groupBox8.Enabled = false;
                    groupBox9.Enabled = false;
                }
                else
                {
                    CheckIfSectionIsActive();
                }


                // Verifică dacă avem un câștigător
                if (turnCount2 > 2)
                {
                    CheckWinner2();
                }
            }
        }*/

        /*private void btn1_gb2_Click(object sender, EventArgs e)
        {
            // Dacă butonul nu este deja apăsat (fără text), plasăm X sau O
            if (btn1_gb2.Text == "")
            {
                if (isXTurn)
                {
                    btn1_gb2.Text = "X";
                }
                else
                {
                    btn1_gb2.Text = "O";
                }

                // Schimbă rândul
                isXTurn = !isXTurn;
                turnCount2++;

                if (LBLGB1.Text == "")
                {
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    groupBox4.Enabled = false;
                    groupBox5.Enabled = false;
                    groupBox6.Enabled = false;
                    groupBox7.Enabled = false;
                    groupBox8.Enabled = false;
                    groupBox9.Enabled = false;
                }
                else
                {
                    CheckIfSectionIsActive();
                }

                // Verifică dacă avem un câștigător
                if (turnCount2 > 2)
                {
                    CheckWinner2();
                }
            }
        }*/


    }
}
