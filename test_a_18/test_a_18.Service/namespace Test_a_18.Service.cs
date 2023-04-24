using System;
using Test_a_18.DataAccess;
using Test_a_18.DTO;

namespace Test_a_18.Service
{
    public class OnedriveConfigurationService
    {
        private readonly OnedriveConfigurationRepository _onedriveConfigurationRepository;

        public OnedriveConfigurationService(OnedriveConfigurationRepository onedriveConfigurationRepository)
        {
            _onedriveConfigurationRepository = onedriveConfigurationRepository;
        }

        public OnedriveConfiguration GetOnedriveConfigurationById(int id)
        {
            return _onedriveConfigurationRepository.GetOnedriveConfigurationById(id);
        }

        public OnedriveConfiguration AddOnedriveConfiguration(OnedriveConfiguration onedriveConfiguration)
        {
            return _onedriveConfigurationRepository.AddOnedriveConfiguration(onedriveConfiguration);
        }

        public OnedriveConfiguration UpdateOnedriveConfiguration(OnedriveConfiguration onedriveConfiguration)
        {
            return _onedriveConfigurationRepository.UpdateOnedriveConfiguration(onedriveConfiguration);
        }

        public void DeleteOnedriveConfiguration(int id)
        {
            _onedriveConfigurationRepository.DeleteOnedriveConfiguration(id);
        }
    }
}