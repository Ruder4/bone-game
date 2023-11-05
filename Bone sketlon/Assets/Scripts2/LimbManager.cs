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

    public bool flipped = false;
    
    public int currentBoneSelection = 1;
    public string currentBoneType = "Arm";
    public int[] limbs = {0, 0, 0, 0};
    public GameObject[] allLimbs = {null, null, null, null};
    public List<Collider2D> collisions;

    private Color leftArmColor;
    private Color rightArmColor;
    private Color leftLegColor;
    private Color rightLegColor;

    public GameObject HleftArmU;
    public GameObject HleftArmL;
    public GameObject HleftArmH;

    public GameObject HrightArmU;
    public GameObject HrightArmL;
    public GameObject HrightArmH;

    public GameObject HleftLegU;
    public GameObject HleftLegL;
    public GameObject HleftLegH;

    public GameObject HrightLegU;
    public GameObject HrightLegL;
    public GameObject HrightLegH;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentBoneSelection = 1;
            currentBoneType = "Arm";
            
            HleftArmU.GetComponent<SpriteRenderer>().color = new Color(HleftArmU.GetComponent<SpriteRenderer>().color.r, HleftArmU.GetComponent<SpriteRenderer>().color.g, HleftArmU.GetComponent<SpriteRenderer>().color.b, 1f);
            HleftArmL.GetComponent<SpriteRenderer>().color = new Color(HleftArmL.GetComponent<SpriteRenderer>().color.r, HleftArmL.GetComponent<SpriteRenderer>().color.g, HleftArmL.GetComponent<SpriteRenderer>().color.b, 1f);
            HleftArmH.GetComponent<SpriteRenderer>().color = new Color(HleftArmH.GetComponent<SpriteRenderer>().color.r, HleftArmH.GetComponent<SpriteRenderer>().color.g, HleftArmH.GetComponent<SpriteRenderer>().color.b, 1f);
            
            HrightArmU.GetComponent<SpriteRenderer>().color = new Color(HrightArmU.GetComponent<SpriteRenderer>().color.r, HrightArmU.GetComponent<SpriteRenderer>().color.g, HrightArmU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HrightArmL.GetComponent<SpriteRenderer>().color = new Color(HrightArmU.GetComponent<SpriteRenderer>().color.r, HrightArmU.GetComponent<SpriteRenderer>().color.g, HrightArmU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HrightArmH.GetComponent<SpriteRenderer>().color = new Color(HrightArmU.GetComponent<SpriteRenderer>().color.r, HrightArmU.GetComponent<SpriteRenderer>().color.g, HrightArmU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            
            HleftLegU.GetComponent<SpriteRenderer>().color = new Color(HleftLegU.GetComponent<SpriteRenderer>().color.r, HleftLegU.GetComponent<SpriteRenderer>().color.g, HleftLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HleftLegL.GetComponent<SpriteRenderer>().color = new Color(HleftLegU.GetComponent<SpriteRenderer>().color.r, HleftLegU.GetComponent<SpriteRenderer>().color.g, HleftLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HleftLegH.GetComponent<SpriteRenderer>().color = new Color(HleftLegU.GetComponent<SpriteRenderer>().color.r, HleftLegU.GetComponent<SpriteRenderer>().color.g, HleftLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            
            HrightLegU.GetComponent<SpriteRenderer>().color = new Color(HrightLegU.GetComponent<SpriteRenderer>().color.r, HrightLegU.GetComponent<SpriteRenderer>().color.g, HrightLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HrightLegL.GetComponent<SpriteRenderer>().color = new Color(HrightLegU.GetComponent<SpriteRenderer>().color.r, HrightLegU.GetComponent<SpriteRenderer>().color.g, HrightLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HrightLegH.GetComponent<SpriteRenderer>().color = new Color(HrightLegU.GetComponent<SpriteRenderer>().color.r, HrightLegU.GetComponent<SpriteRenderer>().color.g, HrightLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentBoneSelection = 2;
            currentBoneType = "Arm";
            
            HleftArmU.GetComponent<SpriteRenderer>().color = new Color(HleftArmU.GetComponent<SpriteRenderer>().color.r, HleftArmU.GetComponent<SpriteRenderer>().color.g, HleftArmU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HleftArmL.GetComponent<SpriteRenderer>().color = new Color(HleftArmL.GetComponent<SpriteRenderer>().color.r, HleftArmL.GetComponent<SpriteRenderer>().color.g, HleftArmL.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HleftArmH.GetComponent<SpriteRenderer>().color = new Color(HleftArmH.GetComponent<SpriteRenderer>().color.r, HleftArmH.GetComponent<SpriteRenderer>().color.g, HleftArmH.GetComponent<SpriteRenderer>().color.b, 0.4f);
            
            HrightArmU.GetComponent<SpriteRenderer>().color = new Color(HrightArmU.GetComponent<SpriteRenderer>().color.r, HrightArmU.GetComponent<SpriteRenderer>().color.g, HrightArmU.GetComponent<SpriteRenderer>().color.b, 1f);
            HrightArmL.GetComponent<SpriteRenderer>().color = new Color(HrightArmU.GetComponent<SpriteRenderer>().color.r, HrightArmU.GetComponent<SpriteRenderer>().color.g, HrightArmU.GetComponent<SpriteRenderer>().color.b, 1f);
            HrightArmH.GetComponent<SpriteRenderer>().color = new Color(HrightArmU.GetComponent<SpriteRenderer>().color.r, HrightArmU.GetComponent<SpriteRenderer>().color.g, HrightArmU.GetComponent<SpriteRenderer>().color.b, 1f);
            
            HleftLegU.GetComponent<SpriteRenderer>().color = new Color(HleftLegU.GetComponent<SpriteRenderer>().color.r, HleftLegU.GetComponent<SpriteRenderer>().color.g, HleftLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HleftLegL.GetComponent<SpriteRenderer>().color = new Color(HleftLegU.GetComponent<SpriteRenderer>().color.r, HleftLegU.GetComponent<SpriteRenderer>().color.g, HleftLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HleftLegH.GetComponent<SpriteRenderer>().color = new Color(HleftLegU.GetComponent<SpriteRenderer>().color.r, HleftLegU.GetComponent<SpriteRenderer>().color.g, HleftLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            
            HrightLegU.GetComponent<SpriteRenderer>().color = new Color(HrightLegU.GetComponent<SpriteRenderer>().color.r, HrightLegU.GetComponent<SpriteRenderer>().color.g, HrightLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HrightLegL.GetComponent<SpriteRenderer>().color = new Color(HrightLegU.GetComponent<SpriteRenderer>().color.r, HrightLegU.GetComponent<SpriteRenderer>().color.g, HrightLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HrightLegH.GetComponent<SpriteRenderer>().color = new Color(HrightLegU.GetComponent<SpriteRenderer>().color.r, HrightLegU.GetComponent<SpriteRenderer>().color.g, HrightLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentBoneSelection = 3;
            currentBoneType = "Leg";
            
            HleftArmU.GetComponent<SpriteRenderer>().color = new Color(HleftArmU.GetComponent<SpriteRenderer>().color.r, HleftArmU.GetComponent<SpriteRenderer>().color.g, HleftArmU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HleftArmL.GetComponent<SpriteRenderer>().color = new Color(HleftArmL.GetComponent<SpriteRenderer>().color.r, HleftArmL.GetComponent<SpriteRenderer>().color.g, HleftArmL.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HleftArmH.GetComponent<SpriteRenderer>().color = new Color(HleftArmH.GetComponent<SpriteRenderer>().color.r, HleftArmH.GetComponent<SpriteRenderer>().color.g, HleftArmH.GetComponent<SpriteRenderer>().color.b, 0.4f);
            
            HrightArmU.GetComponent<SpriteRenderer>().color = new Color(HrightArmU.GetComponent<SpriteRenderer>().color.r, HrightArmU.GetComponent<SpriteRenderer>().color.g, HrightArmU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HrightArmL.GetComponent<SpriteRenderer>().color = new Color(HrightArmU.GetComponent<SpriteRenderer>().color.r, HrightArmU.GetComponent<SpriteRenderer>().color.g, HrightArmU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HrightArmH.GetComponent<SpriteRenderer>().color = new Color(HrightArmU.GetComponent<SpriteRenderer>().color.r, HrightArmU.GetComponent<SpriteRenderer>().color.g, HrightArmU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            
            HleftLegU.GetComponent<SpriteRenderer>().color = new Color(HleftLegU.GetComponent<SpriteRenderer>().color.r, HleftLegU.GetComponent<SpriteRenderer>().color.g, HleftLegU.GetComponent<SpriteRenderer>().color.b, 1f);
            HleftLegL.GetComponent<SpriteRenderer>().color = new Color(HleftLegU.GetComponent<SpriteRenderer>().color.r, HleftLegU.GetComponent<SpriteRenderer>().color.g, HleftLegU.GetComponent<SpriteRenderer>().color.b, 1f);
            HleftLegH.GetComponent<SpriteRenderer>().color = new Color(HleftLegU.GetComponent<SpriteRenderer>().color.r, HleftLegU.GetComponent<SpriteRenderer>().color.g, HleftLegU.GetComponent<SpriteRenderer>().color.b, 1f);
            
            HrightLegU.GetComponent<SpriteRenderer>().color = new Color(HrightLegU.GetComponent<SpriteRenderer>().color.r, HrightLegU.GetComponent<SpriteRenderer>().color.g, HrightLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HrightLegL.GetComponent<SpriteRenderer>().color = new Color(HrightLegU.GetComponent<SpriteRenderer>().color.r, HrightLegU.GetComponent<SpriteRenderer>().color.g, HrightLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HrightLegH.GetComponent<SpriteRenderer>().color = new Color(HrightLegU.GetComponent<SpriteRenderer>().color.r, HrightLegU.GetComponent<SpriteRenderer>().color.g, HrightLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentBoneSelection = 4;
            currentBoneType = "Leg";
            
            HleftArmU.GetComponent<SpriteRenderer>().color = new Color(HleftArmU.GetComponent<SpriteRenderer>().color.r, HleftArmU.GetComponent<SpriteRenderer>().color.g, HleftArmU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HleftArmL.GetComponent<SpriteRenderer>().color = new Color(HleftArmL.GetComponent<SpriteRenderer>().color.r, HleftArmL.GetComponent<SpriteRenderer>().color.g, HleftArmL.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HleftArmH.GetComponent<SpriteRenderer>().color = new Color(HleftArmH.GetComponent<SpriteRenderer>().color.r, HleftArmH.GetComponent<SpriteRenderer>().color.g, HleftArmH.GetComponent<SpriteRenderer>().color.b, 0.4f);
            
            HrightArmU.GetComponent<SpriteRenderer>().color = new Color(HrightArmU.GetComponent<SpriteRenderer>().color.r, HrightArmU.GetComponent<SpriteRenderer>().color.g, HrightArmU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HrightArmL.GetComponent<SpriteRenderer>().color = new Color(HrightArmU.GetComponent<SpriteRenderer>().color.r, HrightArmU.GetComponent<SpriteRenderer>().color.g, HrightArmU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HrightArmH.GetComponent<SpriteRenderer>().color = new Color(HrightArmU.GetComponent<SpriteRenderer>().color.r, HrightArmU.GetComponent<SpriteRenderer>().color.g, HrightArmU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            
            HleftLegU.GetComponent<SpriteRenderer>().color = new Color(HleftLegU.GetComponent<SpriteRenderer>().color.r, HleftLegU.GetComponent<SpriteRenderer>().color.g, HleftLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HleftLegL.GetComponent<SpriteRenderer>().color = new Color(HleftLegU.GetComponent<SpriteRenderer>().color.r, HleftLegU.GetComponent<SpriteRenderer>().color.g, HleftLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            HleftLegH.GetComponent<SpriteRenderer>().color = new Color(HleftLegU.GetComponent<SpriteRenderer>().color.r, HleftLegU.GetComponent<SpriteRenderer>().color.g, HleftLegU.GetComponent<SpriteRenderer>().color.b, 0.4f);
            
            HrightLegU.GetComponent<SpriteRenderer>().color = new Color(HrightLegU.GetComponent<SpriteRenderer>().color.r, HrightLegU.GetComponent<SpriteRenderer>().color.g, HrightLegU.GetComponent<SpriteRenderer>().color.b, 1f);
            HrightLegL.GetComponent<SpriteRenderer>().color = new Color(HrightLegU.GetComponent<SpriteRenderer>().color.r, HrightLegU.GetComponent<SpriteRenderer>().color.g, HrightLegU.GetComponent<SpriteRenderer>().color.b, 1f);
            HrightLegH.GetComponent<SpriteRenderer>().color = new Color(HrightLegU.GetComponent<SpriteRenderer>().color.r, HrightLegU.GetComponent<SpriteRenderer>().color.g, HrightLegU.GetComponent<SpriteRenderer>().color.b, 1f);
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
                else if ((currentBoneSelection == 2 && !flipped) || (currentBoneSelection == 1 && flipped)) {
                    rightArmU.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    rightArmL.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    rightArmH.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                }
                else if ((currentBoneSelection == 3 && !flipped) || (currentBoneSelection == 4 && flipped)) {
                    leftLegU.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    leftLegL.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    leftLegH.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                }
                else if ((currentBoneSelection == 4 && !flipped) || (currentBoneSelection == 3 && flipped)) {
                    rightLegU.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    rightLegL.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    rightLegH.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                }

                if (currentBoneSelection == 1) {
                    HleftArmU.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    HleftArmL.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    HleftArmH.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                }
                else if (currentBoneSelection == 2) {
                    HrightArmU.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    HrightArmL.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    HrightArmH.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                }
                else if (currentBoneSelection == 3) {
                    HleftLegU.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    HleftLegL.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    HleftLegH.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                }
                else if (currentBoneSelection == 4) {
                    HrightLegU.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    HrightLegL.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                    HrightLegH.GetComponent<SpriteRenderer>().color = closest.GetComponent<SpriteRenderer>().color;
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.F) && allLimbs[currentBoneSelection - 1] != null) {
            Debug.Log("Use " + allLimbs[currentBoneSelection - 1]);

            if (allLimbs[currentBoneSelection - 1].GetComponent<BoneInitiator>().BoneAction == "Big"){
                GetComponent<Abilities>().big = true;
            }
            else if (allLimbs[currentBoneSelection - 1].GetComponent<BoneInitiator>().BoneAction == "Small"){
                GetComponent<Abilities>().small = true;
            }
            else if (allLimbs[currentBoneSelection - 1].GetComponent<BoneInitiator>().BoneAction == "DJ"){
                GetComponent<Abilities>().dj = true;
            }
            else if (allLimbs[currentBoneSelection - 1].GetComponent<BoneInitiator>().BoneAction == "Dash"){
                GetComponent<Abilities>().dash = true;
            }
            else if (allLimbs[currentBoneSelection - 1].GetComponent<BoneInitiator>().BoneAction == "Levitation"){
                GetComponent<Abilities>().levitation = true;
            }
            else if (allLimbs[currentBoneSelection - 1].GetComponent<BoneInitiator>().BoneAction == "Teleport"){
                GetComponent<Abilities>().teleport = true;
            }

            /**
                "Big"
                "Small"
                "Stool"
                "DJ"
                "Dash"
            **/
            /**
                "Levitation"
                "Teleport"
            **/
            /**
                "Grapple"
            **/

            allLimbs[currentBoneSelection - 1] = null;
            if ((currentBoneSelection == 1 && !flipped) || (currentBoneSelection == 2 && flipped)) {
                leftArmU.GetComponent<SpriteRenderer>().color = Color.white;
                leftArmL.GetComponent<SpriteRenderer>().color = Color.white;
                leftArmH.GetComponent<SpriteRenderer>().color = Color.white;
            }
            else if ((currentBoneSelection == 2 && !flipped) || (currentBoneSelection == 1 && flipped)) {
                rightArmU.GetComponent<SpriteRenderer>().color = Color.white;
                rightArmL.GetComponent<SpriteRenderer>().color = Color.white;
                rightArmH.GetComponent<SpriteRenderer>().color = Color.white;
            }
            else if ((currentBoneSelection == 3 && !flipped) || (currentBoneSelection == 4 && flipped)) {
                leftLegU.GetComponent<SpriteRenderer>().color = Color.white;
                leftLegL.GetComponent<SpriteRenderer>().color = Color.white;
                leftLegH.GetComponent<SpriteRenderer>().color = Color.white;
            }
            else if ((currentBoneSelection == 4 && !flipped) || (currentBoneSelection == 3 && flipped)) {
                rightLegU.GetComponent<SpriteRenderer>().color = Color.white;
                rightLegL.GetComponent<SpriteRenderer>().color = Color.white;
                rightLegH.GetComponent<SpriteRenderer>().color = Color.white;
            }

            if (currentBoneSelection == 1) {
                    HleftArmU.GetComponent<SpriteRenderer>().color = Color.white;
                    HleftArmL.GetComponent<SpriteRenderer>().color = Color.white;
                    HleftArmH.GetComponent<SpriteRenderer>().color = Color.white;
                }
                else if (currentBoneSelection == 2) {
                    HrightArmU.GetComponent<SpriteRenderer>().color = Color.white;
                    HrightArmL.GetComponent<SpriteRenderer>().color = Color.white;
                    HrightArmH.GetComponent<SpriteRenderer>().color = Color.white;
                }
                else if (currentBoneSelection == 3) {
                    HleftLegU.GetComponent<SpriteRenderer>().color = Color.white;
                    HleftLegL.GetComponent<SpriteRenderer>().color = Color.white;
                    HleftLegH.GetComponent<SpriteRenderer>().color = Color.white;
                }
                else if (currentBoneSelection == 4) {
                    HrightLegU.GetComponent<SpriteRenderer>().color = Color.white;
                    HrightLegL.GetComponent<SpriteRenderer>().color = Color.white;
                    HrightLegH.GetComponent<SpriteRenderer>().color = Color.white;
                }
        }
        else if (Input.GetKeyDown(KeyCode.Q) && allLimbs[currentBoneSelection - 1] != null) {
            allLimbs[currentBoneSelection - 1].transform.position = transform.position;
            allLimbs[currentBoneSelection - 1] = null;
            if ((currentBoneSelection == 1 && !flipped) || (currentBoneSelection == 2 && flipped)) {
                leftArmU.GetComponent<SpriteRenderer>().color = Color.white;
                leftArmL.GetComponent<SpriteRenderer>().color = Color.white;
                leftArmH.GetComponent<SpriteRenderer>().color = Color.white;
            }
            else if ((currentBoneSelection == 2 && !flipped) || (currentBoneSelection == 1 && flipped)) {
                rightArmU.GetComponent<SpriteRenderer>().color = Color.white;
                rightArmL.GetComponent<SpriteRenderer>().color = Color.white;
                rightArmH.GetComponent<SpriteRenderer>().color = Color.white;
            }
            else if ((currentBoneSelection == 3 && !flipped) || (currentBoneSelection == 4 && flipped)) {
                leftLegU.GetComponent<SpriteRenderer>().color = Color.white;
                leftLegL.GetComponent<SpriteRenderer>().color = Color.white;
                leftLegH.GetComponent<SpriteRenderer>().color = Color.white;
            }
            else if ((currentBoneSelection == 4 && !flipped) || (currentBoneSelection == 3 && flipped)) {
                rightLegU.GetComponent<SpriteRenderer>().color = Color.white;
                rightLegL.GetComponent<SpriteRenderer>().color = Color.white;
                rightLegH.GetComponent<SpriteRenderer>().color = Color.white;
            }

            if (currentBoneSelection == 1) {
                    HleftArmU.GetComponent<SpriteRenderer>().color = Color.white;
                    HleftArmL.GetComponent<SpriteRenderer>().color = Color.white;
                    HleftArmH.GetComponent<SpriteRenderer>().color = Color.white;
                }
                else if (currentBoneSelection == 2) {
                    HrightArmU.GetComponent<SpriteRenderer>().color = Color.white;
                    HrightArmL.GetComponent<SpriteRenderer>().color = Color.white;
                    HrightArmH.GetComponent<SpriteRenderer>().color = Color.white;
                }
                else if (currentBoneSelection == 3) {
                    HleftLegU.GetComponent<SpriteRenderer>().color = Color.white;
                    HleftLegL.GetComponent<SpriteRenderer>().color = Color.white;
                    HleftLegH.GetComponent<SpriteRenderer>().color = Color.white;
                }
                else if (currentBoneSelection == 4) {
                    HrightLegU.GetComponent<SpriteRenderer>().color = Color.white;
                    HrightLegL.GetComponent<SpriteRenderer>().color = Color.white;
                    HrightLegH.GetComponent<SpriteRenderer>().color = Color.white;
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