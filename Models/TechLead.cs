namespace TeamOrganizer.Models;

public class TechLead
{
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public List<string> Skills { get; private set; }

    public TechLead(string nome, string email, List<string> skills)
    {
        Nome = nome;
        Email = email;
        Skills = skills;
    }

    public bool TemSkill(string skill)
    {
        return Skills.Any(l => l.Equals(skill));
    }
}
