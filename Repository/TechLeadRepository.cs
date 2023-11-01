using TeamOrganizer.Models;

namespace TeamOrganizer.Repository;

public class TechLeadRepository;DesenvolvedorRepository
{
    private List<TechLead> TechLeads = new List<TechLead>()
    {
        //new("Adriano", "adriano@empresa.com", new() { "Web Applications", "API", "DevOps", "SAAS" }),
        //new("Adriana", "adriana@empresa.com", new() { "UIUX", "SPA", "DevOps" }),
        //new("Matilda", "matilda@empresa.com", new() { "Services", "Cloud", "SPA", "SAAS" }),
    };

    public TechLead? BuscarPorSkill(string skill)
    {
        return TechLeads.FirstOrDefault(t => t.TemSkill(skill));
    }
}
