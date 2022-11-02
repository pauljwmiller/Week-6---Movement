using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectRB02 : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        rigidbody = GetComponent<Rigidbody>();
=======
        // Where does one find a rigidbody these days anyway?

	    //rigidbody = rigidbody;
>>>>>>> 14bf5864b8de3b31e75410e8928775f0b5c4552d
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(moveDirection, ForceMode.Force);
    }
}
