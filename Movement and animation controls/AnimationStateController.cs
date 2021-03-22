using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    int ridingHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        ridingHash = Animator.StringToHash("riding");
    }

    // Update is called once per frame
    void Update()
    {
        bool riding = animator.GetBool("ridingHash");
        bool forwardPressed = Input.GetKey("w");

        // if player presses
       if (!riding && forwardPressed)
        {
            //then set the riding boolean to be true
            animator.SetBool("ridingHash", true);
        }
       //if player is not pressing w key
       if (riding && !forwardPressed)
        {
            //then set the riding boolean to be false
            animator.SetBool("ridingHash", false);
        }
    }
}
