namespace Jogo_da_Velha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
            AtualizarCores();
        }

        private void Button_Cliked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
                
            }
            AtualizarCores();

            bool vitoriaX = false;
            bool vitoriaO = false;

            // Linhas horizontais
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") vitoriaX = true;
            else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O") vitoriaO = true;

            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") vitoriaX = true;
            else if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") vitoriaO = true;

            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") vitoriaX = true;
            else if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") vitoriaO = true;

            // Colunas verticais
            if (btn10.Text == "X" && btn7.Text == "X" && btn4.Text == "X") vitoriaX = true;
            else if (btn10.Text == "O" && btn7.Text == "O" && btn4.Text == "O") vitoriaO = true;

            if (btn11.Text == "X" && btn8.Text == "X" && btn5.Text == "X") vitoriaX = true;
            else if (btn11.Text == "O" && btn8.Text == "O" && btn5.Text == "O") vitoriaO = true;

            if (btn12.Text == "X" && btn9.Text == "X" && btn6.Text == "X") vitoriaX = true;
            else if (btn12.Text == "O" && btn9.Text == "O" && btn6.Text == "O") vitoriaO = true;

            // Diagonais
            if (btn10.Text == "X" && btn8.Text == "X" && btn6.Text == "X") vitoriaX = true;
            else if (btn10.Text == "O" && btn8.Text == "O" && btn6.Text == "O") vitoriaO = true;

            if (btn12.Text == "X" && btn8.Text == "X" && btn4.Text == "X") vitoriaX = true;
            else if (btn12.Text == "O" && btn8.Text == "O" && btn4.Text == "O") vitoriaO = true;

            if (vitoriaX)
            {
                DisplayAlert("Congratulações!!!", "O X Acaba de Ganhar", "OK");
                Zerar();
                return;
            }
            else if (vitoriaO)
            {
                DisplayAlert("Congratulações!!!", "O O Acaba de Ganhar", "OK");
                Zerar();
                return;
            }

            
            if (btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "" && btn10.Text != "" && btn11.Text != "" && btn12.Text != "")
            {
                DisplayAlert("Deu Velha!!!", "Ninguém venceu", "OK");
                Zerar();
            }
        }

        void Zerar()
        {
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
        }
        private void AtualizarCores()
        {
            if (vez == "X")
            {
                lblX.TextColor = Colors.Purple; 
                lblO.TextColor = Colors.Black; 
            }
            else
            {
                lblO.TextColor = Colors.Purple; 
                lblX.TextColor = Colors.Black; 
            }
        }
    }
}