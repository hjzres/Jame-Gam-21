using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Transform camPos;

    // Start is called before the first frame update
    void Start()
    {
        camPos = GameObject.Find("Camera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(camPos);
        transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y + 180, 0f);
    }
}
