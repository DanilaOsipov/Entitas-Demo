using System.Collections.Generic;
using System.Linq;
using Configs;

namespace Services
{
    public abstract class ConfigsLibrary<T> : IConfigsLibrary where T : Config
    {
        private List<T> _libraryData = new List<T>();

        public void Initialize(IEnumerable<T> libraryData) => _libraryData = libraryData.ToList();

        public IEnumerable<T> GetAllLibraryData() => _libraryData;
    }

    public interface IConfigsLibrary
    {
    }
}