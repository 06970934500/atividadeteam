using TeamOrganizer.Models;

namespace TeamOrganizer.Repository;

public class DesenvolvedorRepository
{
    public List<Desenvolvedor> Desenvolvedores = new List<Desenvolvedor>()
    {
        new("Toninho", "toninho@empresa.com", Nivel.PLENO, new() { "C#", "JavaScript" }),
        new("Junior", "junior@empresa.com", Nivel.ESTAGIARIO, new() { "C#" }),
        new("Bruno", "bruno@empresa.com", Nivel.ESTAGIARIO, new() { "Python" }),
        new("Marta", "marta@empresa.com", Nivel.SENIOR, new() { "Python", "JavaScript" }),
        new("Kleber", "kleber@empresa.com", Nivel.SENIOR, new() { "C", "Java" }),
        new("Juca", "juca@empresa.com", Nivel.JUNIOR, new() { "Java", "Python" }),
        new("Marcela", "marcela@empresa.com", Nivel.PLENO, new() { "C", "JavaScript" }),
        new("Julianna", "julianna@empresa.com", Nivel.SENIOR, new() { "C", "JavaScript", "Java" }),
        new("Elaine", "elaine@empresa.com", Nivel.JUNIOR, new() { "JavaScript" }),
    };

    public List<Desenvolvedor>? BuscarQuantidadePorLinguagem(string linguagem, int quantidade)
    {
        return Desenvolvedores
            .Where(d => d.SabeLinguagem(linguagem))
            .Take(quantidade)
            .ToList();
    }
}
