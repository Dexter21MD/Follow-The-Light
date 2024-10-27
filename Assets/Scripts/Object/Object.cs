using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField] bool isMovable = false;




    public bool GetIsMovable()
    {
        return isMovable;
    }

}
