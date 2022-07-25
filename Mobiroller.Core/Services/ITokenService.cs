using Mobiroller.Core.Configuration;
using Mobiroller.Core.DTOs;
using Mobiroller.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiroller.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(AppUser appUser);

        ClientTokenDto CreateTokenByClient(Client client);
    }
}
