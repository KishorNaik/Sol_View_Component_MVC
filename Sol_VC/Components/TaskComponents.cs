using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_VC.Models;
using Sol_VC.Repository;

namespace Sol_VC.Components
{
    public class TaskComponents : ViewComponent
    {

        private readonly ITaskRepository _taskRepository;

        public TaskComponents(ITaskRepository taskRepository){
            this._taskRepository=taskRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(bool showpendingtask, bool showcompleteTask)
        {
            var taskModel=new TaskModel(){
                TotalTask=await _taskRepository.GetTotalTaskAsync(),
                TotalPendingTask= (showpendingtask==true) ? await _taskRepository.GetPendingTaskAsync() : 0,
                TotalCompleteTask=(showcompleteTask==true) ?  await _taskRepository.GetTotalTaskAsync() : 0
            };

            return View(taskModel);
        }

    }
}
