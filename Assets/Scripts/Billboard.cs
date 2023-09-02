using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public bool onlySetY;

    private Transform camPos;

    // Start is called before the first frame update
    void Start()
    {
        camPos = GameObject.Find("Camera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origRot = transform.rotation.eulerAngles;

        transform.LookAt(camPos);
        if(onlySetY) {
            transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y + 180, 0f);
        } else {
            print(":3");
            transform.rotation = Quaternion.Euler(origRot.x, transform.rotation.eulerAngles.y + 180, origRot.z);
        }
    }
}
