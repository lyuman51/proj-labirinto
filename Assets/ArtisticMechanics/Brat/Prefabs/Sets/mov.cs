using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    public Vector3 b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
               if(Input.GetKey(KeyCode.W))
    
      {
        b.x = -0.08F;
        b.y = 0F;
        b.z = 0F;
        transform.Translate(b);
      }
               if(Input.GetKey(KeyCode.S))
    
      {
        b.x = 0.05F;
        b.y = 0F;
        b.z = 0F;
        transform.Translate(b);
      }

                if(Input.GetKey(KeyCode.D))
    
      {
        b.x = 0F;
        b.y = 0.5F;
        b.z = 0F;
        transform.Rotate(b);
      }

                if(Input.GetKey(KeyCode.A))
    
      {
        b.x = 0F;
        b.y = -0.5F;
        b.z = 0F;
        transform.Rotate(b);
      }
    }
}
