using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{   
    [SerializeField] private Rigidbody2D rb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Physics2D.gravity.y == -9.81f){
                Physics2D.gravity = new Vector2(0, 9.81f);
            }
            else if (Physics2D.gravity.y == 9.81f){
                Physics2D.gravity = new Vector2(0, -9.81f);
            }
        }
    }
}
