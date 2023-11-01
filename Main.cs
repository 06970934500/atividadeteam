using TeamOrganizer.Services;

public static class Main
{
    public static void Executar()
    {
        var squadService = new SquadService();
        var discoveryService = new DiscoveryService();

        // CRIAÇÃO TIME
        var language1 = RandomLanguage();
        var arqSkill1 = RandomArqSkill();
        var techSkill1 = RandomTechSkill();
        var novoTeam = squadService.CriarNovoTime:("TeamMobile", language1, new() { arqSkill1, techSkill1 }, "Segurança");

        if(novoTeam is not null) {
            Console.WriteLine("NOVO TIME CRIADO");

            Console.WriteLine($"Gestor: {novoTeam.Gestor.Nome} ({novoTeam.Gestor.Email})");
            Console.WriteLine("Desenvolvedores: ");
            novoTeam.Desenvolvedores.ForEach(dev => Console.WriteLine($"{dev.Nome} ({dev.Email}) - {dev.Nivel}"));

            if(novoTeam.Arquiteto is not null)
            {
                Console.WriteLine("Arquiteto:");
                Console.WriteLine($"{novoTeam.Arquiteto.Nome} ({novoTeam.Arquiteto.Email})");
            }

            if(novoTeam.TechLead is not null)
            {
                Console.WriteLine("TechLead:");
                Console.WriteLine($"{novoTeam.TechLead.Nome} ({novoTeam.TechLead.Email})");
            }

            Console.WriteLine($"Total de Pessoas: {novoTeam?.TotalDePessoasNoTime()}");
        }

        // CRIAÇÃO TIME DISCOVERY
        var language2 = RandomLanguage();
        var arqSkill2 = RandomArqSkill();
        var techSkill2 = RandomTechSkill();
        var novoDiscovery = discoveryService.CriarNovoTimeDiscovery("Discovery Service", language2, new() { arqSkill2, techSkill2 });

        if(novoDiscovery is not null) {
            Console.WriteLine("\nNOVO TIME DISCOVERY CRIADO");

            Console.WriteLine($"Gestor: {novoDiscovery.Gestor.Nome} ({novoDiscovery.Gestor.Email})");
            Console.WriteLine("Desenvolvedores: ");
            novoDiscovery.Desenvolvedores.ForEach(dev => Console.WriteLine($"{dev.Nome} ({dev.Email}) - {dev.Nivel}"));

            if(novoDiscovery.Arquiteto is not null)
            {
                Console.WriteLine("Arquiteto:");
                Console.WriteLine($"{novoDiscovery.Arquiteto.Nome} ({novoDiscovery.Arquiteto.Email})");
            }

            if(novoDiscovery.TechLead is not null)
            {
                Console.WriteLine("TechLead:");
                Console.WriteLine($"{novoDiscovery.TechLead.Nome} ({novoDiscovery.TechLead.Email})");
            }

            Console.WriteLine($"Total de Pessoas: {novoDiscovery?.TotalDePessoasNoTime()}");
        }
    }

    private static string RandomLanguage()
    {
        List<string> linguagens = new() { "JavaScript", "C#", "Python", "C", "Java" };

        Random rnd = new Random();
        return linguagens[rnd.Next(linguagens.Count)];
    }

    private static string RandomArqSkill()
    {
        List<string> skills = new() { "MVC", "API", "DevOps", "SAAS", "Legado", "PAAS", "SPA" };

        Random rnd = new Random();
        return skills[rnd.Next(skills.Count)];
    }

    private static string RandomTechSkill()
    {
        List<string> skills = new() { "Web Applications", "API", "DevOps", "SAAS", "UIUX", "Services", "Cloud", "SPA" };

        Random rnd = new Random();
        return skills[rnd.Next(skills.Count)];
    }
}
