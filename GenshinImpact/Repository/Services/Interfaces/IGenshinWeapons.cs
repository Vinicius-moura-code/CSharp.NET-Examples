using GenshinImpact.Models;
using System.Threading.Tasks;

namespace GenshinImpact.Repository.Services.Interfaces
{
    internal interface IGenshinWeapons
    {
        Task<Weapons> getCharacter();
    }
}