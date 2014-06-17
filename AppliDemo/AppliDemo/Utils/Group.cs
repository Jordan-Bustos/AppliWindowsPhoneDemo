using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using LieuNamespace;

namespace AppliDemo.Utils
{
    public class Group : System.Linq.IGrouping<Lieu.LieuType, Lieu>
    {
        System.Linq.IGrouping<Lieu.LieuType, Lieu> mLieu;

        public Group(System.Linq.IGrouping<Lieu.LieuType, Lieu> lieu)
        {
            mLieu = lieu;
        }

        public System.Collections.Generic.IEnumerator<Lieu> GetEnumerator()
        {
            return mLieu.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return mLieu.GetEnumerator();
        }

        public Lieu.LieuType Key
        {
            get
            {
                return mLieu.Key;
            }
        }
    }
}
