using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxelEdit : MonoBehaviour
{
    
    // public Transform nextBreakAnim; // for break animation 

    void OnMouseDown() 
    {   
        // if (gameObject.tag != "lastBreakAnim") {   Instantiate(nextBreakAnim, transform.position, nextBreakAnim.rotation);      } // for break animation  
        Destroy(gameObject);
    }
}
