using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] GameObject playerObj;
    void Update()
    {
        transform.position = new Vector3(playerObj.transform.position.x, playerObj.transform.position.y, -10);
    }
}
