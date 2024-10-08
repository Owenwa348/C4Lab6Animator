using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reny3Movement : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    CharacterController characterController;
    void Start() //Start ทำแค่ครั้งเดียวเท่านั้น
    {
        anim = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        anim.SetBool("Is Def", false);
        anim.SetBool("Is walking", false);
        anim.SetBool("Is Danceing", false);
        // anim.SetBool("is walking", true);
    }

    // Update is called once per frame
    void Update() //Update จะทำต่อไปเลื่อยๆ
    {
        

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("Is walking", true);
            anim.SetBool("Is Def", true);
            anim.SetBool("Is Danceing", false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("Is Danceing", true);
            anim.SetBool("Is walking", true);
            anim.SetBool("Is Def", false);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("Is Def", true);
            anim.SetBool("Is Danceing", true);
            anim.SetBool("Is walking", false);
        }
    }
}
// 