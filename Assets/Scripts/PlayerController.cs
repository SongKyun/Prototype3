using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody plyerRb;

    // Start is called before the first frame update
    void Start()
    {
        plyerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           plyerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}
