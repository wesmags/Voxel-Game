using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGen : MonoBehaviour
{

    // Block List 
    public Transform block00;

    void Start()
    {   
        for ( float xPos = -24; xPos < 24; xPos += 0.25f) 
        {
            for ( float zPos = -24; zPos < 24; zPos += 0.25f) 
            {
                Instantiate(block00, new Vector3(xPos,0,zPos), block00.rotation);
            }
        }
    }

    
    void Update()
    {
        
    }
}
