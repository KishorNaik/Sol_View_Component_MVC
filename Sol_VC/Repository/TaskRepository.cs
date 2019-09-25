using System;
using System.Threading.Tasks;

namespace Sol_VC.Repository
{

    public interface ITaskRepository{
        Task<int> GetTotalTaskAsync();
        Task<int> GetPendingTaskAsync();

        Task<int> GetCompleteTaskAsync();
    }

    public class TaskRepository : ITaskRepository
    {
        public async Task<int> GetTotalTaskAsync()
        {
            return await Task.Run(()=>{

                return 20;

            });
        }

        public async Task<int> GetPendingTaskAsync(){

            return await Task.Run(()=>{

                return 10;
            });
        }

        public async Task<int> GetCompleteTaskAsync(){

            return await Task.Run(()=>{


                return 10;

            });
        }
    }
}
