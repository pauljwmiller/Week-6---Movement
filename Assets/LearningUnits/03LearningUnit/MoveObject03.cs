using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject03 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position;
    }
    // Changed the masses of both cubes to make the scene work as intended.
}
