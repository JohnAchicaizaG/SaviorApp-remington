using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaviorIA.Services.Settings
{
    public interface ISettingsProvider
    {
        Task<T> Get<T>(string key, T DefaultValue);
        Task Save<T>(string key, T value);
    }
}
