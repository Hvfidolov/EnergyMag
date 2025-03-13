using EnergyMagMain.Server.dao.entities;
using EnergyMagMain.Server.dao.repositories;

namespace EnergyMagMain.Server.service
{
    public class RuleService : IRuleRepository
    {
        public List<Rule> getAllRules()
        {
            throw new NotImplementedException();
        }

        public Rule getRuleById(long id)
        {
            throw new NotImplementedException();
        }

        public List<Rule> GetRuleByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Rule> GetRuleByStatus(bool status)
        {
            throw new NotImplementedException();
        }
    }
}
