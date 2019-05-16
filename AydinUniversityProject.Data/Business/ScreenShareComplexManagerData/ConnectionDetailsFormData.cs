using AydinUniversityProject.Data.Business.ForumComplexManager;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.Business.ScreenShareComplexManagerData
{
    public class ConnectionDetailsFormData
    {
        public ConnectionDetailsFormData()
        {
            ProfilePhotoFormDatas = new List<ProfilePhotoFormData>();
        }
        public List<ProfilePhotoFormData> ProfilePhotoFormDatas { get; set; }

        public Connection Connection { get; set; }
    }
}
