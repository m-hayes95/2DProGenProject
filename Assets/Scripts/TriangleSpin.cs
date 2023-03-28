using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleSpin : MonoBehaviour
{
    private float rotateSpeed;
    private void Start()
    {
        rotateSpeed = Random.Range(30, 200);
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate the triangle ;
        transform.Rotate(new Vector3(0, 0, 1), rotateSpeed * Time.deltaTime);
    }
}
