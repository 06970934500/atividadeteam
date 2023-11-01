using TeamOrganizer.Models;

namespace TeamOrganizer.Repository;

public class ArquitetoRepository
{
    private List<Arquiteto> Arquitetos = new List<Arquiteto>()
    {
        new("Fabio", "fabio@empresa.com", new() { "C#", "JavaScript" }, new() { "MVC", "API", "DevOps", "SAAS" }),
        new("Vinicius", "vinicius@empresa.com", new() { "C", "Python" }, new() { "MVVM", "Legado", "DevOps", "PAAS" }),
        new("Fabiana", "fabiana@empresa.com", new() { "Python", "Java", "C#" }, new() { "API", "MVC", "SPA", "SAAS" }),
    };

    public Arquiteto? BuscarPorSkillELinguagem(string skill, string linguagem)
    {
        return Arquitetos.FirstOrDefault(
            a => a.TemSkill(skill) &&
                a.SabeLinguagem(linguagem));
    }
}
