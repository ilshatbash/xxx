using AutoItX3Lib;
namespace addressbook_tests_autoit
{
    public class HelperBase
    {
        protected AutoItX3 aux;
        protected string WINTITLE;
        protected ApplicationManager manager;
        public HelperBase(ApplicationManager manager)
        {
            WINTITLE = ApplicationManager.WINTITLE;
            this.manager = manager;
            this.aux = manager.Aux;
        }
    }
}