using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dondur : MonoBehaviour
{
    public float hizi = 2000f;

    void Update()
    {
        transform.Rotate(hizi*1 * Time.deltaTime,0,0);
    }
}
