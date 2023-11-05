using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    public bool big;
    public bool small;
    public bool stool;
    public bool dj;
    public bool dash;

    void Update()
    {
        if (big){
            if (transform.localScale.x < 0) {
                transform.localScale += new Vector3(0, 0.1f, 0);
                transform.localScale -= new Vector3(0.1f, 0, 0);
            }
            else {
                transform.localScale += new Vector3(0.1f, 0.1f, 0);
            }
            big = false;
        }
        
        if (small){
            if (transform.localScale.x < 0) {
                transform.localScale -= new Vector3(0, 0.1f, 0);
                transform.localScale += new Vector3(0.1f, 0, 0);
            }
            else {
                transform.localScale -= new Vector3(0.1f, 0.1f, 0);
            }
            small = false;
        }
    }
}