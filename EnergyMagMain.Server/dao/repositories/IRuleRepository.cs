using EnergyMagMain.Server.dao.entities;


namespace EnergyMagMain.Server.dao.repositories
{
    public interface IRuleRepository
    {
        public List<Rule> getAllRules();
        public Rule getRuleById(long id);
        public List<Rule> GetRuleByName(string name);
        public List<Rule> GetRuleByStatus(bool status);
    }
}
