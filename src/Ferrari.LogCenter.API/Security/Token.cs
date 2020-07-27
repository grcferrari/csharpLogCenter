using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari.LogCenter.API.Security
{
    public class Token
    {
        public bool Authenticated { get; set; }

        public string Created { get; set; }

        public string Expiration { get; set; }

        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        public string Message { get; set; }

        public string Error { get; set; }

        [JsonProperty(PropertyName = "error_description")]
        public string ErrorDescription { get; set; }
    }
}
