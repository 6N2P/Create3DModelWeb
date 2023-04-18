using Creator;
using System.ServiceModel;

namespace Create3DModelWeb.Models
{
    public class ValuesModel
    {
        private ICreator creator;

        public int width { get; set; }
        public int height { get; set; }
        public int thickness { get; set; }
        public int calculation { get; set; } = 0;

      
    }

}
