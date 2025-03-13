using EnergyMagMain.Server.dao.entities;
using EnergyMagMain.Server.dao.repositories;

namespace EnergyMagMain.Server.service
{
    public class IssueService : IIssueRepository
    {
        List<Issue> _issues = new List<Issue>();

        public List<Issue> getAllIssues()
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetIssueByEndDate(DateTime EndDateTime)
        {
            throw new NotImplementedException();
        }

        public Issue getIssueById(long id)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetIssueByPriority(int priority)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetIssueByStartDate(DateTime startDateTime)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetIssueByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetIssueByType(string type)
        {
            throw new NotImplementedException();
        }
        public void CreateIssue(Issue issue)
        {
            _issues.Add(issue);
        }

        public void UpdateIssue(Issue updatedIssue)
        {
            var existingIssue = getIssueById(updatedIssue.id);
            if (existingIssue != null)
            {
                existingIssue.type = updatedIssue.type;
                existingIssue.description = updatedIssue.description;
                existingIssue.priority = updatedIssue.priority;
                existingIssue.startDate = updatedIssue.startDate;
                existingIssue.endDate = updatedIssue.endDate;
                existingIssue.issueStatus = updatedIssue.issueStatus;
                existingIssue.response = updatedIssue.response;
            }
        }

        public void DeleteIssue(long id)
        {
            var issue = getIssueById(id);
            if (issue != null)
            {
                _issues.Remove(issue);
            }
        }
    }
}
