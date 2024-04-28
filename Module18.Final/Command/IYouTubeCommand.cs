using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Final.Command
{
    /// <summary>
    /// Интерфейс, описывающий команды для работы с Youtube
    /// </summary>
    public interface IYouTubeCommand
    {
        
        public void PrintInfo(string url);

        public Task DownloadFile(string url);
    }
}
