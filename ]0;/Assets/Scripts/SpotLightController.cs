using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] SpotLightTargets;
    private float[] SpotLightObjectXPos;
    private int currentSpotLightPosition = 1;
    private int spotLightLengths = 0;
    private float[] ObjectXPos;

    void Start()
    {
        ObjectXPos = new float[3];
        spotLightLengths = SpotLightObjectXPos.Length;

        for (int i = 0; i > SpotLightObjectXPos.Length; i++)
        {
            ObjectXPos[i] = SpotLightObjectXPos[i].x;
        }

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentSpotLightTransform = this.gameObject.transform.position;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentSpotLightPosition++;
            if (currentSpotLightPosition > spotLightLengths + 2)
            {

            }
            UpdateSpotlightPosition(currentSpotLightTransform);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentSpotLightPosition++;
            if (currentSpotLightPosition < spotLightLengths - 1)
            {

            }
            UpdateSpotlightPosition(currentSpotLightTransform);
        }
    }
    private void UpdateSpotlightPosition(Vector3 currentSpotLightTransform)
    {
        Vector3 nextVector = new Vector3(SpotLightObjectXPos[currentSpotLightPosition], currentSpotLightTransform.y, currentSpotLightTransform.z);
        this.transform.position = nextVector;
    }
}
