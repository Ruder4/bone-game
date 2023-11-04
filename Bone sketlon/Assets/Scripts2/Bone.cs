using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable object/Item")]
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
        Gravity,
        Ghost,
        Stool,
        Size,
        Teleport,
        Double,
        Dash
    }
}