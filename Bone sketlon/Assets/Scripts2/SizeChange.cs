using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour
{
    [SerializeField] private GameObject player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            player.transform.localScale -= new Vector3(2, 2, 0);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            player.transform.localScale += new Vector3(2, 2, 0);
        }
    }
}
