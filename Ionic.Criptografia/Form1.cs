namespace Ionic.Criptografia
{
    public partial class Form1 : Form
    {
        private readonly Core.Criptografia _criptografia;
        public Form1()
        {
            _criptografia = new Core.Criptografia();
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var resultado = Enumerable.Empty<int>();

            await Task.Run(() => {
                resultado = _criptografia.Criptografar(txtMensagem.Text, txtChave.Text);
            });

            txtResultado.Text = string.Join("; ", resultado.ToArray());
        }
    }
}