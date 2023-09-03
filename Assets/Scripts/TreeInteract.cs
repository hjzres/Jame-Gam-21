using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeInteract : MonoBehaviour
{
    public GameObject trunk;
    public GameObject log;
    public int size = 1;
    public int health = 3;
    private Animator animator;
    private Vector3 windVector;
    public int minSize = 1;
    public int maxSize = 3;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        size = Random.Range(minSize, maxSize + 1);
        health *= size;
        transform.localScale *= size;
    }

    // Update is called once per frame
    void Update()
    {
        if(StaticData.axe == 3)
        {
            windVector = new Vector3(0, 0, Random.Range(5, 25));
        }
        else
        {
            windVector = Vector3.zero;
        }
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
            new Vector3(Random.Range(-3, 3), 1, Random.Range(-3, 3)) + windVector,
            ForceMode.Impulse
        );
    }
}
