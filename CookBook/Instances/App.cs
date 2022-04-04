using System.Windows.Forms;

namespace CookBook.Instances
{
    internal class App
    {
        private static ApplicationContext _Instance;

        public static ApplicationContext Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ApplicationContext();
                }

                return _Instance;
            }
        }
    }
}
