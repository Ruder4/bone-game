using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbManager : MonoBehaviour
{
    public GameObject leftArmU;
    public GameObject leftArmL;
    public GameObject leftArmH;

    public GameObject rightArmU;
    public GameObject rightArmL;
    public GameObject rightArmH;

    public GameObject leftLegU;
    public GameObject leftLegL;
    public GameObject leftLegH;

    public GameObject rightLegU;
    public GameObject rightLegL;
    public GameObject rightLegH;

    private bool flipped = false;
    
    public int currentBoneSelection = 1;
    public string currentBoneType = "Arm";
    public int[] limbs = {0, 0, 0, 0};
    public GameObject[] allLimbs = {null, null, null, null};
    public List<Collider2D> collisions;

    private Color leftArmColor;
    private Color rightArmColor;
    private Color leftLegColor;
    private Color rightLegColor;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentBoneSelection = 1;
            currentBoneType = "Arm";
            //highlight left arm
            Debug.Log("1");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentBoneSelection = 2;
            currentBoneType = "Arm";
            //highlight right arm
            Debug.Log("2");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentBoneSelection = 3;
            currentBoneType = "Leg";
            //highlight left leg
            Debug.Log("3");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentBoneSelection = 4;
            currentBoneType = "Leg";
            //highlight right leg
            Debug.Log("4");
        }

        if (Input.GetKeyDown(KeyCode.E) && allLimbs[currentBoneSelection - 1] == null)
        {
            GameObject[] gos;
            gos = GameObject.FindGameObjectsWithTag("Bone");
            GameObject closest = null;
            float distance = Mathf.Infinity;
            Vector3 position = transform.position;
            foreach (GameObject go in gos)
            {
                if (go.GetComponent<BoneInitiator>().BoneType == currentBoneType) {
                    Vector3 diff = go.transform.position - position;
                    float curDistance = diff.sqrMagnitude;
                    if (curDistance < distance)
                    {
                        closest = go;
                        distance = curDistance;
                    }
                }
            }
            if (distance <= 1f) {
                allLimbs[currentBoneSelection - 1] = closest;
                closest.transform.position = new Vector3(-100f, 0f, 0);

                if ((currentBoneSelection == 1 && !flipped) || (currentBoneSelection == 2 && flipped)) {
                    leftArmU.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    leftArmL.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    leftArmH.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                }
                else if ((currentBoneSelection == 2) || (currentBoneSelection == 1 && flipped)) {
                    rightArmU.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    rightArmL.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    rightArmH.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                }
                else if ((currentBoneSelection == 3) || (currentBoneSelection == 4 && flipped)) {
                    leftLegU.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    leftLegL.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    leftLegH.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                }
                else if ((currentBoneSelection == 4) || (currentBoneSelection == 3 && flipped)) {
                    rightLegU.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    rightLegL.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    rightLegH.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.E) && allLimbs[currentBoneSelection - 1] != null) {
            Debug.Log("Use " + allLimbs[currentBoneSelection - 1]);
        }
        else if (Input.GetKeyDown(KeyCode.Q) && allLimbs[currentBoneSelection - 1] != null) {
            allLimbs[currentBoneSelection - 1].transform.position = transform.position;
            allLimbs[currentBoneSelection - 1] = null;
            if ((currentBoneSelection == 1 && !flipped) || (currentBoneSelection == 2 && flipped)) {
                leftArmU.GetComponent<SpriteRenderer>().color = Color.white;
                leftArmL.GetComponent<SpriteRenderer>().color = Color.white;
                leftArmH.GetComponent<SpriteRenderer>().color = Color.white;
            }
            else if ((currentBoneSelection == 2) || (currentBoneSelection == 1 && flipped)) {
                rightArmU.GetComponent<SpriteRenderer>().color = Color.white;
                rightArmL.GetComponent<SpriteRenderer>().color = Color.white;
                rightArmH.GetComponent<SpriteRenderer>().color = Color.white;
            }
            else if ((currentBoneSelection == 3) || (currentBoneSelection == 4 && flipped)) {
                leftLegU.GetComponent<SpriteRenderer>().color = Color.white;
                leftLegL.GetComponent<SpriteRenderer>().color = Color.white;
                leftLegH.GetComponent<SpriteRenderer>().color = Color.white;
            }
            else if ((currentBoneSelection == 4) || (currentBoneSelection == 3 && flipped)) {
                rightLegU.GetComponent<SpriteRenderer>().color = Color.white;
                rightLegL.GetComponent<SpriteRenderer>().color = Color.white;
                rightLegH.GetComponent<SpriteRenderer>().color = Color.white;
            }
        }
    }

    public void flipper(){
        leftArmColor = rightArmU.GetComponent<SpriteRenderer>().color;
        rightArmColor = leftArmU.GetComponent<SpriteRenderer>().color;
        leftLegColor = rightLegU.GetComponent<SpriteRenderer>().color;
        rightLegColor = leftLegU.GetComponent<SpriteRenderer>().color;

        leftArmU.GetComponent<SpriteRenderer>().color = leftArmColor;
        leftArmL.GetComponent<SpriteRenderer>().color = leftArmColor;
        leftArmH.GetComponent<SpriteRenderer>().color = leftArmColor;
        
        rightArmU.GetComponent<SpriteRenderer>().color = rightArmColor;
        rightArmL.GetComponent<SpriteRenderer>().color = rightArmColor;
        rightArmH.GetComponent<SpriteRenderer>().color = rightArmColor;
        
        leftLegU.GetComponent<SpriteRenderer>().color = leftLegColor;
        leftLegL.GetComponent<SpriteRenderer>().color = leftLegColor;
        leftLegH.GetComponent<SpriteRenderer>().color = leftLegColor;
        
        rightLegU.GetComponent<SpriteRenderer>().color = rightLegColor;
        rightLegL.GetComponent<SpriteRenderer>().color = rightLegColor;
        rightLegH.GetComponent<SpriteRenderer>().color = rightLegColor;

        if (flipped) {
            flipped = false;
        }
        else {
            flipped = true;
        }
    }
}