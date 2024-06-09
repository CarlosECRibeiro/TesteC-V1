using Gtk;

class Program
{
    static void Main()
    {
        Application.Init();

        // Janela principal
        var window = new Window("Qual seria a sua classe?");
        window.SetDefaultSize(750, 600);
        window.DeleteEvent += delegate { Application.Quit(); };

        // Contêiner vertical
        var vbox = new VBox(false, 2);
        window.Add(vbox);

        // Imagem
        var image = new Image("classes.jpeg");
        vbox.PackStart(image, true, true, 0);

        // Contêiner horizontal para os botões
        var hbox = new HBox(false, 2);
        vbox.PackStart(hbox, false, false, 0);

        // Contêiner de alinhamento para centralizar o HBox
        var alignment = new Alignment(0.5f, 0.5f, 0, 0);
        alignment.Add(hbox);
        vbox.PackStart(alignment, false, false, 0);

        // Botões
        var button1 = new Button("Uma facada nas costas derruba qualquer coisa!");
        var button2 = new Button("Um soco é o suficiente!");
        var button3 = new Button("Pra que chegar perto se um feitiço da conta?");

        // Adiciona botões ao contêiner
        hbox.PackStart(button1, false, false, 0);
        hbox.PackStart(button2, false, false, 0);
        hbox.PackStart(button3, false, false, 0);

        // Conecta eventos dos botões
        button1.Clicked += (sender, e) => ShowImageWindow("Caçador!", "caçador.jpeg", "Você com certeza viraria um caçador!");
        button2.Clicked += (sender, e) => ShowImageWindow("Titã!", "titã.jpeg", "Você daria um belo titã!");
        button3.Clicked += (sender, e) => ShowImageWindow("Arcano!", "arcano.jpeg", "Você seria um bom arcano!");

        window.ShowAll();
        Application.Run();
    }

    static void ShowImageWindow(string title, string imagePath, string labelText)
    {
        // Nova janela
        var window = new Window(title);
        window.SetDefaultSize(600, 500);

        // Contêiner vertical
        var vbox = new VBox(false, 2);
        window.Add(vbox);

        // Imagem
        var image = new Image(imagePath);
        vbox.PackStart(image, true, true, 0);

        // Texto
        var label = new Label(labelText);
        vbox.PackStart(label, false, false, 0);

        window.ShowAll();
    }
}