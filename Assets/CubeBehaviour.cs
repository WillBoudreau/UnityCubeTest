using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    public float CubeRotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        CubeRotateSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        RotateCube();
    }
    void RotateCube()
    {
        gameObject.transform.Rotate(Vector3.up *  CubeRotateSpeed);
    }
}
