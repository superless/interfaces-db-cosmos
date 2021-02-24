using System.Threading.Tasks;
using trifenix.model;

namespace trifenix.connect.interfaces.db.cosmos
{
    public interface ITimeStampDbQueries {
        Task<long[]> GetTimestamps<T>() where T: DocumentDb;
    }
}
