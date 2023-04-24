using System;
using Test_a_18.DTO;

namespace Test_a_18
{
    public class OnedriveConfigurationRepository
    {
        private readonly OnedriveConfiguration _onedriveConfiguration;

        public OnedriveConfigurationRepository(OnedriveConfiguration onedriveConfiguration)
        {
            _onedriveConfiguration = onedriveConfiguration;
        }

        public OnedriveConfiguration GetOnedriveConfigurationById(int id)
        {
            return _onedriveConfiguration;
        }

        public OnedriveConfiguration AddOnedriveConfiguration(OnedriveConfiguration onedriveConfiguration)
        {
            return onedriveConfiguration;
        }

        public OnedriveConfiguration UpdateOnedriveConfiguration(OnedriveConfiguration onedriveConfiguration)
        {
            return onedriveConfiguration;
        }

        public void DeleteOnedriveConfiguration(int id)
        {
            _onedriveConfiguration.Id = 0;
        }
    }
}