using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererConnector : MonoBehaviour
{
    /// <summary>
    /// In this script is made for loop where line renderer will go through all objects in connectors array
    /// </summary>

    //reference for connectors array
    public GameObject[] connectors;
    //reference for line renderer
    public LineRenderer line;

    private void Start()
    {
        line = this.gameObject.GetComponent<LineRenderer>();
        line.positionCount = connectors.Length;
    }

    private void Update()
    {
        //with for loop line will go through all objects that are in connectors array
        for (int i = 0; i < connectors.Length; i++)
        {
            line.SetPosition(i, connectors[i].transform.position);
        }
    }
}
