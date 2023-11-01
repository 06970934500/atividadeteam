namespace TeamOrganizer.Models;

public class Desenvolvedor : IEquatable<Desenvolvedor>
{
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public Nivel Nivel { get; private set; }
    public List<string> Linguagens { get; private set; }

    public Desenvolvedor(string nome, string email, Nivel nivel, List<string> linguagens)
    {
        Nome = nome;
        Email = email;
        Linguagens = linguagens;
        Nivel = nivel;
    }

    public bool SabeLinguagem(string linguagem)
    {
        return Linguagens.Any(l => l.Equals(linguagem));
    }

    public bool Equals(Desenvolvedor? other)
    {
        return Nivel.Equals(other?.Nivel) &&
            Nome.Equals(other?.Nivel) &&
            Email.Equals(other?.Email);
    }
}
