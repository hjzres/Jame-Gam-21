using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeInteract : MonoBehaviour
{
    private int health = 3;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
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
        Destroy(gameObject);
    }
}
