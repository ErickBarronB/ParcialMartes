using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graphs<T>
{
    
    public Dictionary<T, List<(T, int)>> planets = new Dictionary<T, List<(T, int)>>();

    
    public void AddNode(T planet)
    {
        if (!planets.ContainsKey(planet))
        {
            planets[planet] = new List<(T, int)>();
        }
    }

    
    public void AddEdge(T from, T to, int cost)
    {
        
        if (planets.ContainsKey(from) && planets.ContainsKey(to))
        {
            planets[from].Add((to, cost));
            planets[to].Add((from, cost)); 
        }
    }

     
    public List<(T, int)> GetConnections(T planet)
    {
        if (planets.ContainsKey(planet))
        {
            return planets[planet];
        }
        return null;
    }

    
}
