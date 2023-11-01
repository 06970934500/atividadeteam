namespace TeamOrganizer.Models;

public class Arquiteto
{
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public List<string> Linguagens { get; private set; }
    public List<string> Skills { get; private set; }

    public Arquiteto(string nome, string email, List<string> linguagens, List<string> skills)
    {
        Nome = nome;
        Email = email;
        Linguagens = linguagens;
        Skills = skills;
    }

    public bool SabeLinguagem(string linguagem)
    {
        return Linguagens.Any(l => l.Equals(linguagem));
    }

    public bool TemSkill(string skill)
    {
        return Skills.Any(l => l.Equals(skill));
    }
}