using EnergyMagMain.Server.dao.entities;

namespace EnergyMagMain.Server.dao.repositories
{
    public interface IIssueRepository
    {
        public List<Issue> getAllIssues();
        public Issue getIssueById(long id);
        public List<Issue> GetIssueByType(string type);
        public List<Issue> GetIssueByStatus(bool status);
        public List<Issue> GetIssueByPriority(int priority);
        public List<Issue> GetIssueByStartDate(DateTime startDateTime);
        public List<Issue> GetIssueByEndDate(DateTime EndDateTime);
    }
}