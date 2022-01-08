using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR_Algo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = " In the system of two-way roads, a certain toll is charged for the passage of " +
                "each road.\n Find a path from city A to city B with a minimum value of S + P, " +
                "where S is the sum of\n the lengths of the roads of the path, and P is the sum of" +
                " the tolls of the roads being traveled.\n Develop an algorithm for solving this" +
                " problem and write a program.\n\n Made by Khazgalieva Diana, PRO-227";
        }

        int id = 0;
        int selected = 0;
        City new_city = new City();
        vertex new_vertex = new vertex();
        Road edge = new Road();
        List<City> cities = new List<City>();
        List<Road> roads = new List<Road>();
        List<Road> min_value_roads = new List<Road>();
        List<City> selected_cities = new List<City>();
        List<vertex> vertices = new List<vertex>();
        Map map = new Map();

        private void find_min_values()
        {
            for(int i = 0; i < roads.Count; ++i)
                if (!roads[i].Check)
                {
                    Road min_road = roads[i];
                    for(int j = i; j < roads.Count; ++j)
                        if(!(roads[j].Check) && roads[i].same_direction(roads[j]))
                        {
                            if (roads[j].get_value() < min_road.get_value())
                                min_road = roads[j];
                            roads[j].Check = true;
                        }
                    min_value_roads.Add(min_road);
                    roads[i].Check = true;
                }
            
            for(int i = 0; i < min_value_roads.Count; ++i)
            {
                vertices[min_value_roads[i].C1.ID].roadsL.Add(min_value_roads[i]);
                vertices[min_value_roads[i].C2.ID].roadsL.Add(min_value_roads[i]);
            }
        }

        private void algorithm(vertex first_v, vertex dest)
        {
            for(int i = 0; i < vertices[first_v.ID].roadsL.Count; ++i)
            {
                if(first_v.ID == vertices[first_v.ID].roadsL[i].C2.ID)
                    if(vertices[vertices[first_v.ID].roadsL[i].C1.ID].Weight >
                    (first_v.Weight + vertices[first_v.ID].roadsL[i].get_value()))
                    {
                        vertices[vertices[first_v.ID].roadsL[i].C1.ID].Weight = first_v.Weight + vertices[first_v.ID].roadsL[i].get_value();
                        vertices[vertices[first_v.ID].roadsL[i].C1.ID].Prev = vertices[first_v.ID];
                    }
                if (first_v.ID == vertices[first_v.ID].roadsL[i].C1.ID)
                    if (vertices[vertices[first_v.ID].roadsL[i].C2.ID].Weight >
                    (first_v.Weight + vertices[first_v.ID].roadsL[i].get_value()))
                    {
                        vertices[vertices[first_v.ID].roadsL[i].C2.ID].Weight = first_v.Weight + vertices[first_v.ID].roadsL[i].get_value();
                        vertices[vertices[first_v.ID].roadsL[i].C2.ID].Prev = vertices[first_v.ID];
                    }
            }
            first_v.Visit = true;
            int min = 10000;
            vertex new_v = new vertex();
            for(int i = 0; i < vertices.Count; ++i)
            {
                if(!vertices[i].Visit && vertices[i].Weight < min)
                {
                    min = vertices[i].Weight;
                    new_v = vertices[i];
                }
            }
            if (new_v.ID != dest.ID) algorithm(new_v, dest);
        }

        private void City_Creator(object sender, MouseEventArgs e)
        {
            new_city = new City(e.X, e.Y, id);
            new_vertex = new vertex(id);
            ++id;
            cities.Add(new_city);
            vertices.Add(new_vertex);
            map = new Map(cities, roads);

            Refresh(); //ручной вызов PaintEvent

        }

        private void GraphBox_RightButton(object sender, MouseEventArgs e)
        {
            for(int i = 0; i < id ; ++i)
            {
                if(cities[i].hittest(e.X, e.Y))
                {
                    if (!cities[i].IsSelected && selected < 2)
                    {
                        cities[i].IsSelected = true;
                        selected++;
                        selected_cities.Add(cities[i]);
                    }
                    else if(cities[i].IsSelected)
                    {
                        cities[i].IsSelected = false;
                        if (selected_cities[0] == cities[i]) selected_cities.Remove(selected_cities[0]);
                        else if (selected_cities[1] == cities[i]) selected_cities.Remove(selected_cities[1]);
                        selected--;
                    }

                    map = new Map(cities, roads);
                    Refresh();
                }
            }
        }

        private void GraphBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) City_Creator(sender, e);
            else GraphBox_RightButton(sender, e);
        }

        private void GraphBox_Paint(object sender, PaintEventArgs e)
        {
            map.draw(e);
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (selected == 2)
            {
                int l = Int32.Parse(lengthTB.Text);
                int p = Int32.Parse(priceTB.Text);
                edge = new Road(selected_cities[0], selected_cities[1], l, p);
                //vertices[selected_cities[0].ID].roadsL.Add(edge);
                //vertices[selected_cities[1].ID].roadsL.Add(edge);
                roads.Add(edge);

                selected = 0;
                cities[selected_cities[0].ID].IsSelected = false;
                cities[selected_cities[1].ID].IsSelected = false;
                selected_cities.Clear();

                map = new Map(cities, roads);
                Refresh();
            }
        }

        private void searchB_Click(object sender, EventArgs e)
        {
            find_min_values();

            int id1 = Int32.Parse(first_vTB.Text)-1;
            int id2 = Int32.Parse(destTB.Text)-1;
            List<int> s = new List<int>();

            algorithm(vertices[id1], vertices[id2]);
            while(id2 != id1)
            {
                s.Add(id2);
                id2 = vertices[id2].Prev.ID;
            }
            s.Add(id2);

            resultL.Text = "Weight = " + vertices[s[0]].Weight.ToString() + ". Path: ";
            for (int i = s.Count-1; i > -1; --i)
            {
                resultL.Text += (s[i]+1).ToString() + "->";
            }

        }
    }
}
