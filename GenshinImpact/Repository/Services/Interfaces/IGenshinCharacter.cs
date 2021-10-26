using GenshinImpact.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Repository.Services.Interfaces
{
    interface IGenshinCharacter
    {
        [Get("/characters")]
        Task<Characters> getCharacter();
    }
}
