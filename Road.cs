using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RGR_Algo
{
    class Road
    {
        City c1;
        City c2;
        Point P;
        bool check;
        int length = 10000;
        int price = 10000;

        public Road() { }
        public Road(City _c1, City _c2, int l, int p)
        {
            c1 = _c1;
            c2 = _c2;
            P.X = (_c1.X + _c2.X) / 2;
            P.Y = (_c1.Y + _c2.Y) / 2;
            length = l;
            price = p;
            check = false;
        }

        public City C1
        {
            get { return c1; }
        }

        public City C2
        {
            get { return c2; }
        }

        public int get_value()
        {
            return length + price;
        }

        public bool same_direction(Road r2)
        {
            return ((c1 == r2.c1 && c2 == r2.c2) || (c1 == r2.c2 && c2 == r2.c1));
        }

        public bool Check
        {
            get { return check; }
            set { check = value; }
        }

        public static bool operator ==(Road r1, Road r2)
        {
            return ((r1.c1 == r2.c1 && r1.c2 == r2.c2 && r1.length == r2.length &&
                r1.price == r2.price)|| (r1.c1 == r2.c2 && r1.c2 == r2.c1 && r1.length == r2.length &&
                r1.price == r2.price));
        }
        public static bool operator !=(Road r1, Road r2)
        {
            return (!(r1==r2));
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public void draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            e.Graphics.DrawLine(pen, c1.X, c1.Y, c2.X, c2.Y);
            e.Graphics.DrawString(this.get_value().ToString(), new Font("Sergoe", 8), Brushes.Red, P);
        }
    }
}
