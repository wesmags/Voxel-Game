using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGen : MonoBehaviour
{

    // Block List 
    public Transform block00;

    void Start()
    {   
        for ( float xPos = -6; xPos < 6; xPos += 0.1f) 
        {
            for ( float zPos = 0; zPos < 6; zPos += 0.1f) 
            {
                Instantiate(block00, new Vector3(xPos,0,zPos), block00.rotation);
            }
        }
    }

    
    void Update()
    {
        
    }
}
