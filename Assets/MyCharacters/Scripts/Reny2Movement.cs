using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reny2Movement : MonoBehaviour
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
//ของอาจารย์

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("Is walking", true);
            anim.SetBool("Is Def", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("Is Danceing", true);
            anim.SetBool("Is Def", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("Is Def", true);
            anim.SetBool("Is Danceing", false);
            anim.SetBool("Is walking", false);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            anim.SetBool("Is Def", true);
            anim.SetBool("Is Danceing", true);
            anim.SetBool("Is walking", false);

        }
        else if (Input.GetKey(KeyCode.F))
        {
            anim.SetBool("Is Danceing", true);
            anim.SetBool("Is walking", true);
        }
        else if (Input.GetKey(KeyCode.G))
        {
            anim.SetBool("Is Danceing", true);
            anim.SetBool("Is walking", false);
            anim.SetBool("Is Def", false);

        }
    }
}
// 
//         if (Input.GetKey(KeyCode.W))
//         {
//             anim.SetBool("Is Def", true);
//             anim.SetBool("Is walking", true);
//             Debug.Log("W key is pressed: " + isWalking);
//         }
//         else if (Input.GetKey(KeyCode.S))
//         {

//             anim.SetBool("Is Def", true);
//             anim.SetBool("Is walking", false);
//             anim.SetBool("Is Danceing", false);
//             Debug.Log("S key is pressed: " + isDef);
//         }
//         else if (Input.GetKey(KeyCode.D))
//         {
//             anim.SetBool("Is Def", true);
//             anim.SetBool("Is Danceing", true);
//             Debug.Log("D key is pressed: " + isDancing);
//         }
//         else if (Input.GetKey(KeyCode.E))
//         {
//             anim.SetBool("Is Def", true);
//             anim.SetBool("Is Danceing", true);
//             anim.SetBool("Is walking", false);

//             Debug.Log("E key is pressed: " + isDancing);
//         }
//         else if (Input.GetKey(KeyCode.F))
//         {
//             anim.SetBool("Is Danceing", true);
//             anim.SetBool("Is walking", true);
//             Debug.Log("A key is pressed: " + isWalking);
//         }
//         else if (Input.GetKey(KeyCode.G))
//         {
//             anim.SetBool("Is Danceing", true);
//             anim.SetBool("Is walking", false);
//             anim.SetBool("Is Def", false);
//             Debug.Log("Space key is pressed: " + isWalking);
//         }
//     }
// }