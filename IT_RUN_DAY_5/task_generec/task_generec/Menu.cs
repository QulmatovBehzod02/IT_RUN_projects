using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_generec
{
    public class Menu
    {
        public string MenuName { get; set; }
        public Menu[] Childs { get; set; }

        public string Generate()
        {

            return $"<li>{MenuName}</li>";
        }
    }
    public class ComplexMenu : IMenu
    {
        public string ComplexMenuName { get; set; }
        
        public ComplexMenu[] ComplexChilds { get; set; }

        public string Href { get; set; }
        IMenu[] IMenu.Childs { get=>Childs; set =>Childs=(ComplexMenu[]) value; }

        public string Generate()
        {

            return $"<li><a href='{Href}'></a></li>";
        }
    }

    public interface IMenu
    {
        IMenu[] Childs { get; set; }
        string Generate();
    }
}
