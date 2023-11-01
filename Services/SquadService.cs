using TeamOrganizer.Models;
using TeamOrganizer.Repository;

namespace TeamOrganizer.Services;

public class SquadService
{   
    private List<Team> Teams = new List<Team>();
    private ArquitetoRepository ArqRepository = new ArquitetoRepository();
    private DesenvolvedorRepository DevRepository = new DesenvolvedorRepository();
    private GestorRepository GestRepository = new GestorRepository();
    private TechLeadRepository TechRepository = new TechLeadRepository();

    public Team? CriarNovoTime(string nomeTime, string linguagem, List<string> skills, string nomeSquad)
    {
        var gestor = GestRepository.BuscarPorSquad(nomeSquad);
        var desenvolvedores = DevRepository.BuscarQuantidadePorLinguagem(linguagem, 3);
        var arquiteto = ArqRepository.BuscarPorSkillELinguagem(skills[0], linguagem);
        var techlead = TechRepository.BuscarPorSkill(skills[1]);

        if(gestor is not null)
        {
            var novoTeam = new Team(nomeTime, gestor);

            novoTeam.AdicionarArquiteto(arquiteto);
            novoTeam.AdicionarTechLead(techlead);
            desenvolvedores?.ForEach(dev => novoTeam.AdicionarDev(dev));

            Teams.Add(novoTeam);
            return novoTeam;
        }

        return null;
    }
}
