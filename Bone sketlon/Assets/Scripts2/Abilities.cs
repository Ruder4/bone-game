using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    public bool big;
    public bool small;
    public bool levitation;
    public bool dj;
    public bool dash;
    public bool teleport;

    public float jumpPower;

    public float floatTime;

    public float dashPower;
    public float dashTime;

    void Update()
    {
        if (big){
            if (transform.localScale.x < 0) {
                transform.localScale += new Vector3(0, 0.15f, 0);
                transform.localScale -= new Vector3(0.15f, 0, 0);
            }
            else {
                transform.localScale += new Vector3(0.15f, 0.15f, 0);
            }
            big = false;
        }
        
        if (small){
            if (transform.localScale.x < 0) {
                transform.localScale -= new Vector3(0, 0.15f, 0);
                transform.localScale += new Vector3(0.15f, 0, 0);
            }
            else {
                transform.localScale -= new Vector3(0.15f, 0.15f, 0);
            }
            small = false;
        }

        if (dj) {
            StartCoroutine(doubleJump());
            dj = false;
        }

        if (dash) {
            StartCoroutine(Dash());
            dash = false;
        }

        if (levitation) {
            StartCoroutine(Levitation());
            levitation = false;
        }

        if (teleport) {
            StartCoroutine(Teleport());
            teleport = false;
        }
    }

    private IEnumerator Dash(){
        float originalGravity = GetComponent<Rigidbody2D>().gravityScale;
        GetComponent<Rigidbody2D>().gravityScale = 0f;
        GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x * dashPower, 0f);
        Debug.Log(transform.localScale.x * dashPower);
        yield return new WaitForSeconds(dashTime);
        GetComponent<Rigidbody2D>().gravityScale = originalGravity;
    }

    private IEnumerator doubleJump(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, jumpPower);
        yield return new WaitForSeconds(dashTime);
    }

    private IEnumerator Levitation(){
        Physics2D.gravity = new Vector2(0, 9.81f);
        yield return new WaitForSeconds(floatTime);
        Physics2D.gravity = new Vector2(0, -9.81f);
    }

    private IEnumerator Teleport(){
        Vector3 telespot = transform.position;
        yield return new WaitForSeconds(floatTime);
        transform.position = telespot;
    }
}