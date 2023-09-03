using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeInteract : MonoBehaviour
{
    public GameObject trunk;
    public GameObject log;
    public int size = 1;
    private int health = 3;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        size = Random.Range(1, 4);
        health *= size;
        transform.localScale *= size;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact() {
        health -= 1;
        if (health <= 0) {
            animator.Play("Base Layer.Tree Fall");
            Invoke("Fall", 1f);
        } else {
            animator.Play("Base Layer.TreeHit");
        }
    }

    public void Fall() {
        trunk.SetActive(true);
        trunk.transform.SetParent(transform.parent);

        for(int i = 0; i < 3 * size; i++) {
            CreateLog(i);
        }

        Destroy(gameObject);
    }

    void CreateLog(int n) {
        GameObject newLog = Instantiate(log, transform.parent);
        newLog.transform.position = transform.position;
        newLog.transform.position += Vector3.up * (3 + n);
        newLog.GetComponent<Rigidbody>().AddForce(
            new Vector3(Random.Range(-3, 3), 1, Random.Range(-3, 3)),
            ForceMode.Impulse
        );
    }
}
