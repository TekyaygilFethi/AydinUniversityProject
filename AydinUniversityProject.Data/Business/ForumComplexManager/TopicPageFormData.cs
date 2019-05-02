using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.Business.ForumComplexManager
{
    public class TopicPageFormData
    {
        public Topic Topic { get; set; }

        public List<ProfilePhotoFormData> ProfilePhotoFormDatas { get; set; }
    }
}
