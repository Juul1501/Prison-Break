using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class HeightPass
{
    public enum PassType {PerlinBased, RandomBased}
    public string name;
    public float height;
    public float detail;
    public PassType type;
}
