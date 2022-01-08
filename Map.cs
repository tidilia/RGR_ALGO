using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RGR_Algo
{
    class Map
    {
        List<City> cities;
        List<Road> roads;

        public Map() { }
        public Map(List<City> _c, List<Road> _r)
        {
            cities = _c;
            roads = _r;
            List<int> stack = new List<int>();
            List<int> visited = new List<int>();
        }
        public void draw(PaintEventArgs e)
        {
            if (roads != null)
                for (int i = 0; i < roads.Count; i++) roads[i].draw(e);
            if (cities != null)
                for (int i = 0; i < cities.Count; i++) cities[i].draw(e);
        }
    }
}
