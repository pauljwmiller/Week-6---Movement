using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject02 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + moveDirection;
    }
    // I don't remember exactly how I fixed this learning unit. Was this code not there at the start?
}
