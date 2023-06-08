using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task_generec
{
    public class MenuGenerator
    {
        public static T GenerateMenu<T>(T menu)where T : IMenu
        {
            StringBuilder Sb=new ();
            
            Sb.AppendLine("<ul>");
            Sb.AppendLine(GenerateMenuRecursive(menu));
            Sb.AppendLine("</ul>");

            File.WriteAllText("index.html",Sb.ToString() , Encoding.UTF8);
            return menu;
        }
        
        public static string GenerateMenuRecursive<T>(T menu)where T : IMenu
        {
            StringBuilder Sb = new();
            Sb.AppendLine(menu.Generate());

            if (menu.Childs == null)
            {
                menu.Childs = new T[0];
            }

            if (menu.Childs.Length>0)
            {
                Sb.AppendLine("<ul>");
                foreach (var subMenu in menu.Childs)
                {
                    Sb.AppendLine(GenerateMenuRecursive(subMenu));
                }
                Sb.AppendLine("</ul>");
            }
            
            return Sb.ToString();

        }
    }
    
}
