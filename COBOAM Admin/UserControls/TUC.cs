using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBOAM_Admin.UserControls
{
    public class TUserControl : UserControl
    {
        public MemoryCache[] memoryCaches = new MemoryCache[200];
    }
}
