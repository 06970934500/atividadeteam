using TeamOrganizer.Models;

namespace TeamOrganizer.Repository;

public class GestorRepositorys:DesenvolvedorRepository
{
    private List<Gestor> Gestores = new List<Gestor>()
    {
        //new("Matheus", "matheus@empresa.com", "Mobile"),
       // new("Joze", "joze@empresa.com", "Segurança"),
       // new("Andressa", "andressa@empresa.com", "Portal Web"),
    };

    public Gestor? BuscarPorSquad(string squad)
    {
        return Gestores.FirstOrDefault(g => g.Squad.Equals(squad));
    }

    public Gestor? BuscarPrimeiroDisponivel()
    {
        return Gestores.FirstOrDefault();
    }
}
