namespace TeamOrganizer.Models;

public class Team
{
    public string Nome { get; set; }
    public List<Desenvolvedor> Desenvolvedores { get; set; } = new List<Desenvolvedor>();
    public TechLead? TechLead { get; set; }
    public Arquiteto? Arquiteto { get; set; }
    public Gestor Gestor { get; set; }

    public Team(string nome, Gestor gestor)
    {
        Nome = nome;
        Gestor = gestor;
    }

    public bool AdicionarDev(Desenvolvedor? desenvolvedor)
    {
        if(Desenvolvedores.Any(d => d.Equals(desenvolvedor)))
            return false;

        if(desenvolvedor is not null) {
            Desenvolvedores.Add(desenvolvedor);
            return true;
        }
            
        return false;
    }

    public void AdicionarTechLead(TechLead? techLead)
    {
        TechLead = techLead;
    }

    public void AdicionarArquiteto(Arquiteto? arquiteto)
    {
        Arquiteto = arquiteto;
    }

    public int TotalDePessoasNoTime()
    {
        var total = 1;
        
        total += Desenvolvedores.Count;
        total += TechLead is not null ? 1 : 0;
        total += Arquiteto is not null ? 1 : 0;

        return total;
    }
}