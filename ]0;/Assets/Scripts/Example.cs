using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{         
    public GameObject[] cube;
    //private Vector3[] randomPos;
    private float[] xvalues;


    void Start()
    {
        xvalues = new float[cube.Length];
        for (int i = 0; i < cube.Length; i++)
        {
            xvalues[i] = cube[i].transform.position.x;
        }
    }
        //cube = this.gameObject;
        //randomPos = new Vector3[3];
        //Vector3 currentPos = cube.transform.position;


        //for (int i = 0; i > randomPos.Length; i++)
        //{
        //    float newY = Random.Range(-10.0f, 10.0f);
        //    randomPos[i] = new Vector3(currentPos.x, newY, currentPos.z);

        //}

    
    void Update()
    {
        
    }
}
