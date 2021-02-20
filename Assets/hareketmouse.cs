using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketmouse : MonoBehaviour
{

    public float yatay = 3f;

    private float xRotation = 0.0f;
    private float yRotation = 0.0f;

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void FixedUpdate()
    {
        this.xRotation += Input.GetAxis("Mouse Y");
        this.yRotation += this.yatay * Input.GetAxis("Mouse X");

        this.transform.eulerAngles = new Vector3(this.xRotation, this.yRotation, 0);
    }




}
