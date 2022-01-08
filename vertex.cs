using System;
using System.Collections.Generic;
using System.Text;

namespace RGR_Algo
{
    class vertex
    {
        int id;
        int weight;
        bool visit = false;
        public List<Road> roadsL = new List<Road>();
        vertex prev;
        public vertex() { }
        public vertex(int _id)
        {
            id = _id;
            weight = 10000;
            roadsL = new List<Road>();
        }
        public vertex(int _id, int _w)
        {
            id = _id;
            weight = _w;
            roadsL = new List<Road>();
        }
        public vertex(int _id, vertex n)
        {
            id = _id;
            prev = n;
            roadsL = new List<Road>();
        }

        public vertex Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int ID
        {
            get { return id; }
        }

        public bool Visit
        {
            get { return visit; }
            set { visit = value; }
        }
    }
}
