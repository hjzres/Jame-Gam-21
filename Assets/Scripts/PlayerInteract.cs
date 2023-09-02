using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float maxDistance = 3;

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            Vector3 rayOrigin = cam.ViewportToWorldPoint (new Vector3(0.5f, 0.5f, 0.0f));

            RaycastHit hit;

            if(Physics.Raycast(rayOrigin, transform.forward, out hit, maxDistance)) {
                Debug.DrawRay(rayOrigin, transform.forward * hit.distance, Color.yellow);
                Debug.Log("Did Hit");

                // hit.transform.gameObject.transform.position += hit.transform.gameObject.transform.forward;

                if(hit.transform.gameObject.tag == "Sketchy Guy")
                {
                    hit.transform.gameObject.GetComponent<SketchyGuy>().openDealerMenu();
                }
                else if(hit.transform.gameObject.tag == "Shop Keeper")
                {
                    hit.transform.gameObject.GetComponent<ShopKeeper>().openShopMenu();
                }
                else
                {
                    hit.transform.gameObject.GetComponent<TreeInteract>().Interact();

                }

            } else {
                Debug.DrawRay(rayOrigin, transform.forward * 1000, Color.white);
                Debug.Log("Did not Hit");
            }
        }
    }
}
