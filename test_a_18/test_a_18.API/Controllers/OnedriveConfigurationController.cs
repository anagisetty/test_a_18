using System;
using Test_a_18.DataAccess;
using Test_a_18.DTO;
using Test_a_18.Service;
using Microsoft.AspNetCore.Mvc;

namespace Test_a_18.API 
{
    [Route("api/[controller]")]
    public class OnedriveConfigurationController : Controller
    {
        private readonly OnedriveConfigurationService _onedriveConfigurationService;

        public OnedriveConfigurationController(OnedriveConfigurationService onedriveConfigurationService)
        {
            _onedriveConfigurationService = onedriveConfigurationService;
        }

        [HttpGet("{id}")]
        public IActionResult GetOnedriveConfigurationById(int id)
        {
            OnedriveConfiguration onedriveConfiguration = _onedriveConfigurationService.GetOnedriveConfigurationById(id);
            if (onedriveConfiguration == null)
            {
                return NotFound();
            }
            return Ok(onedriveConfiguration);
        }

        [HttpPost]
        public IActionResult AddOnedriveConfiguration([FromBody] OnedriveConfiguration onedriveConfiguration)
        {
            OnedriveConfiguration newOnedriveConfiguration = _onedriveConfigurationService.AddOnedriveConfiguration(onedriveConfiguration);
            return Ok(newOnedriveConfiguration);
        }

        [HttpPut]
        public IActionResult UpdateOnedriveConfiguration([FromBody] OnedriveConfiguration onedriveConfiguration)
        {
            OnedriveConfiguration updatedOnedriveConfiguration = _onedriveConfigurationService.UpdateOnedriveConfiguration(onedriveConfiguration);
            return Ok(updatedOnedriveConfiguration);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOnedriveConfiguration(int id)
        {
            _onedriveConfigurationService.DeleteOnedriveConfiguration(id);
            return NoContent();
        }
    }
}