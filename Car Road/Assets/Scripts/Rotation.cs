using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // https://www.youtube.com/watch?v=OwIE3GI8Rdg Thanks to this video I was able to figure out how to add rotation to my platforms
        transform.Rotate(new Vector3(0f, 0f, speed) * Time.deltaTime);
    }
}
