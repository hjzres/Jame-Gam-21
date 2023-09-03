using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float maxDistance = 3;

    private Camera cam;
    private float lastInteract = 0;



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

            float interactInterval = 0.765f - StaticData.motifiedDexterity * 0.015f;

            if(Physics.Raycast(rayOrigin, transform.forward, out hit, maxDistance)) {
                if((Time.time - lastInteract) < interactInterval) {
                    return;
                }

                lastInteract = Time.time;
                

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

                

            }
        }
    }
}
