using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pecaScript : MonoBehaviour
{
    void Update() {
        transform.position = new Vector3(transform.position.x,-0.00000001f * Time.deltaTime,transform.position.z);    
    }
}
