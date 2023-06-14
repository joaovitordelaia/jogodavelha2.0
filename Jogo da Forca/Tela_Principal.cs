using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Forca
{
    public partial class Tela_Principal : Form
    {

        string palavra = ""; // onde a palavra de teste, onde ira entrar a palavra do banco
        char[] resposta;
        int error = 0;

        public Tela_Principal()
        {
            InitializeComponent();
            
            //encherVetor();
        }

        private void SortearPalavra()
        {
            palavra = "PSICOFARMACOLOGIA";
            int contador = palavra.Length;
            resposta = new char[contador];
          
        }



        private void encherVetor()
        {
            for (int i = 0; i < 3; i++)
            {
                resposta[i] = '0';
            }
        }


        private void btn_Dica_Click(object sender, EventArgs e)
        {
            Cad_Palavra cadDica = new Cad_Palavra();
            this.Hide();
            cadDica.ShowDialog();
            this.Close();
        }

        private void gerarLetras(object sender, EventArgs e)
        {
  
            checarPalavra(sender as Button);
            
        }
        private void checarPalavra(Button botao)
        {
            char[] palavra2 = palavra.ToCharArray();
            bool validadorError = false;
            int Tentativas = Convert.ToInt32(lb_Chances.Text);
            string caminhoImagem = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogofacil\facilSemCabeça.png";
            string caminhoImagem2 = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogofacil\facilCabeça.png";
            string caminhoImagem3 = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogofacil\facil 2.png";
            string caminhoImagem4 = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogofacil\facil 3.png";
            string caminhoImagem5 = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogofacil\facil 4.png";
            string caminhoImagem6 = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogofacil\facil 5.png";

            string caminhoMedioCabeca = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogomedio\cabeca.png";
            string caminhoMedio2 = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogomedio\medio 2.png";
            string caminhoMedio3 = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogomedio\medio 3.png";
            string caminhoMedio4 = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogomedio\medio 4.png";
            string caminhoMedio5 = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogomedio\medio 5.png";

            string caminhoDificil = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogodificil\cabeca.png";
            string caminhoDificil2 = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogodificil\dificil 2.png";
            string caminhoDificil3 = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogodificil\dificil 3.png";
            string caminhoDificil4 = @"D:\Atividade C#\pontoDeVenda\pontoDeVenda\imagens\jogodificil\dificil 4.png";



            txt_Palavra.Text = "";
            botao.Enabled = false;
            txt_Letras.Text += botao.Text; // coloca letra jogada sem repetir

            for (int i = 0; i < palavra.Length; i++)//JOAO: se ele rodar esse FOR e sair sem letra correta então é erro
            {
                if (palavra2[i] == Convert.ToChar(botao.Text) && resposta[i] == '\0')// quando alguma letra for igual ao botão pressionado e tiver algum campo vazio no vetor ele ira entrar
                {
                    resposta[i] += Convert.ToChar(botao.Text);//resposta recebe a letra do botão
                    txt_Palavra.Text += Convert.ToString(resposta[i]);// o campo de texto no jogo recebe a resposta
                    validadorError = true;
                }
                else
                {
                    if (resposta[i] == '\0')
                    {
                        txt_Palavra.Text += "_"; // mantem o campo que não foi descoberto ainda como *
                       
                    }

                    
                    txt_Palavra.Text += Convert.ToString(resposta[i]);
                }

            }
            if (validadorError == false)
            {
                error++;
                lb_erro.Text = error.ToString();

                if (rb_Dificil.Checked == true)
                {
                    if (error == 1)
                    {
                        pbImagens.Image = Image.FromFile(caminhoDificil);
                    }
                    if (error == 2)
                    {
                        pbImagens.Image = Image.FromFile(caminhoDificil2);
                    }
                    if (error == 3)
                    {
                        pbImagens.Image = Image.FromFile(caminhoDificil3);
                    }
                    if (error == 4)
                    {
                        pbImagens.Image = Image.FromFile(caminhoDificil4);
                        game_over();
                    }
                }
                if (rb_Medio.Checked == true)
                {
                    if (error == 1)
                    {
                        pbImagens.Image = Image.FromFile(caminhoMedioCabeca);
                    }
                    if (error == 2)
                    {
                        pbImagens.Image = Image.FromFile(caminhoMedio2);
                    }
                    if (error == 3)
                    {
                        pbImagens.Image = Image.FromFile(caminhoMedio3);
                    }
                    if (error == 4)
                    {
                        pbImagens.Image = Image.FromFile(caminhoMedio4);
                    }
                    if (error == 5)
                    {
                        pbImagens.Image = Image.FromFile(caminhoMedio5);
                        game_over();
                    }
                }
                if (rb_Facil.Checked == true)
                {
                    if (error == 1)
                    {
                        pbImagens.Image = Image.FromFile(caminhoImagem);

                    }
                    if (error == 2)
                    {
                        pbImagens.Image = Image.FromFile(caminhoImagem2);
                    }
                    if (error == 3)
                    {
                        pbImagens.Image = Image.FromFile(caminhoImagem3);
                    }
                    if (error == 4)
                    {
                        pbImagens.Image = Image.FromFile(caminhoImagem4);
                    }
                    if (error == 5)
                    {
                        pbImagens.Image = Image.FromFile(caminhoImagem5);
                    }
                    if (error == 6)
                    {
                        pbImagens.Image = Image.FromFile(caminhoImagem6);
                        game_over();
                    }

                }

            }

        }

        private void definirDificuldade()
        {
            if (rb_Dificil.Checked == true)
            {
                rb_Facil.Enabled = false;
                rb_Medio.Enabled = false;
                lb_Chances.Text = "4";
                btn_Iniciar.Enabled = false;
            }
            if (rb_Medio.Checked == true)
            {
                rb_Facil.Enabled = false;
                rb_Dificil.Enabled = false;
                lb_Chances.Text = "5";
                btn_Iniciar.Enabled = false;
            }
            if (rb_Facil.Checked == true)
            {
                rb_Dificil.Enabled = false;
                rb_Medio.Enabled = false;
                lb_Chances.Text = "6";
                btn_Iniciar.Enabled = false;
            }
            






        }


        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            if (rb_Dificil.Checked == true || rb_Medio.Checked == true || rb_Facil.Checked == true)
            {
                definirDificuldade();
                SortearPalavra();
                liga_botao();
            }
            else
            {
                MessageBox.Show("Erro: É necessário selecionar a dificuldade desejada");
            }


            
        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {
            desliga_botao();
        }
        private void desliga_botao()
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            btn_E.Enabled = false;
            btn_F.Enabled = false;
            btn_G.Enabled = false;
            btn_H.Enabled = false;
            btn_I.Enabled = false;
            btn_J.Enabled = false;
            btn_K.Enabled = false;
            btn_L.Enabled = false;
            btn_M.Enabled = false;
            btn_N.Enabled = false;
            btn_O.Enabled = false;
            btn_P.Enabled = false;
            btn_Q.Enabled = false;
            btn_R.Enabled = false;
            btn_S.Enabled = false;
            btn_T.Enabled = false;
            btn_U.Enabled = false;
            btn_V.Enabled = false;
            btn_W.Enabled = false;
            btn_X.Enabled = false;
            btn_Y.Enabled = false;
            btn_Z.Enabled = false;

            btn_Dica.Enabled = false;
        }
        private void liga_botao()
        {
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;
            btn_E.Enabled = true;
            btn_F.Enabled = true;
            btn_G.Enabled = true;
            btn_H.Enabled = true;
            btn_I.Enabled = true;
            btn_J.Enabled = true;
            btn_K.Enabled = true;
            btn_L.Enabled = true;
            btn_M.Enabled = true;
            btn_N.Enabled = true;
            btn_O.Enabled = true;
            btn_P.Enabled = true;
            btn_Q.Enabled = true;
            btn_R.Enabled = true;
            btn_S.Enabled = true;
            btn_T.Enabled = true;
            btn_U.Enabled = true;
            btn_V.Enabled = true;
            btn_W.Enabled = true;
            btn_X.Enabled = true;
            btn_Y.Enabled = true;
            btn_Z.Enabled = true;

            btn_Dica.Enabled = true;
        }
        private void game_over()
        {
            MessageBox.Show("Falha");
        }
    }
}
