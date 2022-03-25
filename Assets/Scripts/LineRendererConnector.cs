using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererConnector : MonoBehaviour
{
    public GameObject[] connectors;

    private LineRenderer line;

    private void Start()
    {
        line = this.gameObject.GetComponent<LineRenderer>();
    }

    private void Update()
    {
        for (int i = 0; i < connectors.Length; i++)
        {
            line.SetPosition(i, connectors[i].transform.position);
        }
    }
}
