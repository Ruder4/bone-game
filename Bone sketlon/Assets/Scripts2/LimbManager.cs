using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbManager : MonoBehaviour
{
    public GameObject selection;
    
    public int currentBoneSelection = 1;
    private int previousBoneSelection = 1;
    public int[] limbs = {0, 0, 0, 0};

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentBoneSelection = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentBoneSelection = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentBoneSelection = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentBoneSelection = 4;
        }

        if (currentBoneSelection != previousBoneSelection){
            previousBoneSelection = currentBoneSelection;
            
            if (currentBoneSelection == 1){
                selection.transform.localPosition = new Vector3(-0.1f, 0.075f, 0);
            }
            else if (currentBoneSelection == 2){
                selection.transform.localPosition = new Vector3(0.1f, 0.075f, 0);
            }
            else if (currentBoneSelection == 3){
                selection.transform.localPosition = new Vector3(-0.1f, -0.075f, 0);
            }
            else if (currentBoneSelection == 4){
                selection.transform.localPosition = new Vector3(0.1f, -0.075f, 0);
            }
        }
    }
}
