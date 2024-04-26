
public class CompanionManager : ICompanionManager
{
    private ICompanionRepository _companionRepository;

    public CompanionManager(ICompanionRepository companionRepository)
    {
        _companionRepository = companionRepository;
    }
    public List<Companion> GetCompanions()
    {
        return _companionRepository.GetCompanions();
    }
    public List<Companion> SearchCompanion(string origin, string destination)
    {
        return _companionRepository.SearchCompanion(origin, destination);
    }  
    public void AddCompanion(Companion companion)
    { 
        _companionRepository.AddCompanion(companion);
    }
    public void DeleteCompanion(int companionId)
    { 
        _companionRepository.DeleteCompanion(companionId);
    } 
}