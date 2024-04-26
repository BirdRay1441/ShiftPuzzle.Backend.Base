public class CompanionRepository : ICompanionRepository
{
    private readonly CompanionContext _context;

    public CompanionRepository(CompanionContext context)
    {
        _context = context;
    }

    public void AddCompanion(Companion companion)
    {
        _context.Companions.Add(companion);
        _context.SaveChanges();
    }

    public void DeleteCompanion(int companionid)
    {   
        _context.Companions.Where(u => u.ID == companionid).ToList().ForEach(t => _context.Companions.Remove(t));
        _context.SaveChanges(); 
    }

    public List<Companion> GetCompanions()
    {
        return _context.Companions.ToList();
    }

    public List<Companion> SearchCompanion(string origin, string destination)
    {
        return _context.Companions.Where(u => u.Origin == origin && u.Destination == destination).ToList();
    }
}