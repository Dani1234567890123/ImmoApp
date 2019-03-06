using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoLib
{
    //Erzeugt nur ein Window und von jeder View ein UserControl, das dann in den Content des Window gesetzt wird
    //Einschränkung class, um sicher zu gehen, dass es sich um ein Objekt handelt, new-Einschränkung nötig, damit ein neues Obj erzeugt werden kann(Obj muss einen parameterlosen Konstruktor besitzen
    public static class ViewCreator<T> where T : class, new()
    {
        //default-Zuweisung sicher den Zugriff, auf einen nicht initialisierten Standardzugriff
        static T newView = default(T);



        public static T CreateSingletonView()
        {
            if (newView == default(T))
            {
                newView = new T();
            }
            return newView;

            //Aufruf aus dem Progamm:
            //Window win = ViewCreator<Window>.CreateSingletonView();
            //UserControl uc = ViewCreator<UserControl>CreateSingletonView();
            //win.Content = uc;
        }
    }
}
