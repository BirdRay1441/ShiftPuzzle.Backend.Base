public interface ICompanionRepository
{
    void AddCompanion(Companion companion); 
    void DeleteCompanion(int companionId);
    List<Companion> GetCompanions();
    List<Companion> SearchCompanion(string origin, string destination);
} 