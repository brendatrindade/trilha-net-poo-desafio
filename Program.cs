using DesafioPOO.Models;

List<Smartphone> smartphones = new List<Smartphone>
{
	new Nokia("11999999999", "Nokia 2233", "123456789012345", 32),
	new Iphone("11988888888", "iPhone 11", "987654321098765", 128)
};

foreach (var phone in smartphones)
{
	phone.ExibirInformacoes();
	phone.Ligar();
	phone.ReceberLigacao();
	string app = phone is Iphone ? "Instagram" : "Whatsapp";
	phone.InstalarAplicativo(app);
}