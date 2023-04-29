﻿using MODEL;
using CONTROL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;
using MySql.Data.MySqlClient;

namespace Projeto_Loc_Senai.FormsAdm
{
    public partial class TelaPerfil : Form
    {
        public TelaPerfil()
        {
            InitializeComponent();
        }

        private void TelaPerfil_Load(object sender, EventArgs e)
        {
            conexao conn = new conexao();
            User us = new User();
            ConsultarDados consu = new ConsultarDados();
            MySqlDataReader dt = consu.select("select * from tb_funcionario");
              dt.Read();
            box_nome_funcionario.Text = dt.GetString(1);
            box_email_funcionario.Text = dt.GetString(2);
            box_funcao_funcionario.Text = dt.GetString(4);
            box_id_funcionario.Text = dt.GetString(0);
            box_pesquisa.Text = dt.GetString(5);
            

            try
            {
                if (box_pesquisa.Text != null)
                {
                    FotoPerfil.Image = Image.FromFile(box_pesquisa.Text);
                }
                else
                {
                    box_pesquisa.Text = null;
                    FotoPerfil = null;
                }


            }
            catch
            {
                MessageBox.Show("Erro na imagem");
            }


        }

        private void bordasPerfil1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A");
        }
    }
}
