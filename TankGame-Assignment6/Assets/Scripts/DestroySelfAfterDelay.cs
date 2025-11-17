using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelfAfterDelay : MonoBehaviour
{

//delay before game object destroyed in secs
public float delay = 2f;

    // Start is called before the first frame update
    void Start()
    {
       //destroythegameobject after 2 secs
	Destroy(gameObject, delay); 
    }

    
   
}
