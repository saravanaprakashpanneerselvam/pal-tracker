using Microsoft.AspNetCore.Mvc;

namespace PalTracker {
    [Route("env")]
    public class EnvController : ControllerBase {
        private readonly CloudFoundryInfo _cloudFoundryEnv;

        public EnvController(CloudFoundryInfo cloudFoundryInfo) {
            _cloudFoundryEnv = cloudFoundryInfo;
        }

        [HttpGet]
        public CloudFoundryInfo Get() => _cloudFoundryEnv;
    }
 

}