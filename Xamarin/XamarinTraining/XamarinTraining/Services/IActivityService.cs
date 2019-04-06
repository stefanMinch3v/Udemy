using System.Collections.Generic;
using XamarinTraining.Models;

namespace XamarinTraining.Services
{
    public interface IActivityService
    {
        IEnumerable<Activity> GetActivities();
    }
}
