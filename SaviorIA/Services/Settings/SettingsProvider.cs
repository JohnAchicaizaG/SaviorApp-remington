using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaviorIA.Services.Settings
{
    public sealed class SettingsProvider : ISettingsProvider
    {

        public Task<T> Get<T>(string key, T DefaultValue)
        {
            var result = Preferences.Default.Get<T>(key, DefaultValue);
            return Task.FromResult(result);
        }

        public Task Save<T>(string key, T value)
        {
            Preferences.Default.Set(key, value);
            return Task.CompletedTask;
        }

    }
}
