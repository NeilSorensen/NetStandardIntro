using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FizzBuzz
{
    public class FizzBuzzRuleFactory
    {
        private string _dbLocation;

        public FizzBuzzRuleFactory(string dbLocation)
        {
            _dbLocation = dbLocation;
        }

        public List<Rule> GetRules()
        {
            if (!File.Exists(_dbLocation))
            {
                return new List<Rule>();
            }

            using (var connection = OpenConnection())
            {
                const string query = "Select ruleOrder, rule from FizzBuzzRules order by ruleOrder ASC";
                var rules = connection.Query<DbRule>(query);
                return rules.Select(x => Rule.Parse(x.Rule)).ToList();
            }
        }

        private class DbRule
        {
            public int RuleOrder { get; set; }
            public string Rule { get; set; }
        }

        private IDbConnection OpenConnection()
        {
            var connection = new SQLiteConnection($"Data Source={_dbLocation}");
            connection.Open();
            return connection;
        }
    }
}
