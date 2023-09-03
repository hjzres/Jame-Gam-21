using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float jumpHeight = 4f;
    public float airtime = 0.6f;
    private float gravity;
    private float jumpForce;

    private CharacterController controller;

    private float velY = 0f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

        gravity = (-8 * jumpHeight) / (airtime * airtime);
        jumpForce = (4 * jumpHeight) / airtime;
    }

    // Update is called once per frame
    void Update()
    {
        speed = StaticData.motifiedWalkSpeed/2;

        Vector2 inputDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        inputDir.Normalize();

        if(controller.isGrounded) {
            velY = 0.0f;

            if(Input.GetKeyDown(KeyCode.Space)){
                velY = jumpForce;
            }
        } else {
            velY += gravity * Time.deltaTime;
        }

        Vector3 vel = (transform.forward * inputDir.y + transform.right * inputDir.x).normalized * speed +  Vector3.up * velY;

        controller.Move(vel * Time.deltaTime);
    }
}
