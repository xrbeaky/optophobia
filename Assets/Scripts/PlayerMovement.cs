using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controls;
    private Animator anim;

    [SerializeField] private float baseSpeed = 10;

    Vector3 velocity;
    public static Vector3 playerPosition;

    void Start()
    {
        controls = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 moveLocalTransform = transform.right * x + transform.forward * z;

        controls.Move(moveLocalTransform * baseSpeed * Time.deltaTime);

        controls.Move(velocity * Time.deltaTime);

        playerPosition = transform.position;


        //anim.SetBool("isWalking", x != 0 || z != 0);
    }
}