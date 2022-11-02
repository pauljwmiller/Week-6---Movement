using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject01 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        transform.position = transform.position + moveDirection;
        // Changed Vector3.zero to moveDirection in order to make the position change by a non-zero amount.
=======
        // My position equals my position PLUS 
	    // where I want to be by the end of this frame...
        transform.position = transform.position + Vector3.zero;
>>>>>>> 14bf5864b8de3b31e75410e8928775f0b5c4552d
    }
}
