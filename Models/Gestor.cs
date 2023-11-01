namespace TeamOrganizer.Models;

public class Gestor
{
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Squad { get; private set; }

    public Gestor(string Nome, string Email, string Squad)
    {
        this.Nome = Nome;
        this.Email = Email;
        this.Squad = Squad;
    }
}
