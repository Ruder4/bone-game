using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable object/Bone")]
public class Bone : ScriptableObject
{
    [Header("Gameplay")]
    public Sprite image;
    public BoneType type;
    public BoneAction action;


    public enum BoneType {
        Arm,
        Leg
    }
 
    public enum BoneAction {
        Grapple,
        Levitation,
        Stool,
        Big,
        Small,
        Teleport,
        Double,
        Dash
    }
}