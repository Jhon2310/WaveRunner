using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    [SerializeField]
    private Vector3 _currentTime;
   
    private void Update()
    {
        transform.Rotate(_currentTime*Time.deltaTime,Space.Self);
    }
}
