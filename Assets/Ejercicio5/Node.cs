using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public bool isWalkable = true; 
    public bool isExit = false;
    public bool isEntrance = false; 
    public Vector2Int position; 
    public List<Node> neighbors = new List<Node>();
    private SpriteRenderer spr;

    private void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        if (isWalkable )
        {
            spr.color = Color.white;
            if ( isExit)
            {
                spr.color = Color.red;
            }
            if ( isEntrance) { spr.color = Color.green; }
            
        }
        else
        {
            spr.color= Color.gray;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = isWalkable ? Color.white : Color.gray;
        Gizmos.DrawCube(transform.position, Vector3.one * 0.9f);
    }
}
