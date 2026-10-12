namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int contador = 0;

        bool ganhou = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";

                vez = "O";
            } else
            {
                btn.Text = "O";

                vez = "X";
            }

            contador++;
            
            if(btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") /* Verificando se o X ganhou na 1ª linha */
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            } if(btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X") /* Verificando se o X ganhou na 2ª linha */
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            } if(btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X") /* Verificando se o X ganhou na 3ª linha */
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            } if(btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X") /* Verificando se o X ganhou na 1ª coluna */
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            } if(btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X") /* Verificando se o X ganhou na 2º coluna */
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            } if(btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X") /* Verificando se o X ganhou na 3ª coluna */
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            } if(btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X") /* Verificando se o X ganhou na 1ª diagonal*/
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            } if(btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X") /* Verificando se o X ganhou na 2ª diagonal */
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            } if(btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O") /* Verificando se o O ganhou na 1ª linha */
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            } if(btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O") /* Verificando se o O ganhou na 2ª linha */
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            } if(btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O") /* Verificando se o O ganhou na 3ª linha */
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            } if(btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O") /* Verificando se o O ganhou na 1ª coluna */
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            } if(btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O") /* Verificando se o O ganhou na 2º coluna */
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            } if(btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O") /* Verificando se o O ganhou na 3ª coluna */
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            } if(btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O") /* Verificando se o O ganhou na 1ª diagonal*/
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            } if(btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O") /* Verificando se o O ganhou na 2ª diagonal */
            {
                ganhou = true;
                DisplayAlertAsync("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            } if(contador==9 && ganhou==false)
            {
                DisplayAlertAsync("Fim de jogo!", "Deu velha! Ninguém ganhou.", "OK");
                Zerar();
            }

        } // Fecha método

        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";


            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            vez = "X";
            contador = 0;
            ganhou = false;
        }
    } // Fecha classe
} // Fecha namespace
