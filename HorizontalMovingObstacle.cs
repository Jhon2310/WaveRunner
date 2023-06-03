using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovingObstacle : MonoBehaviour
{
 
 private float _currentTime;

 private void Update()
 {
  _currentTime += Time.deltaTime;
  var progress = (Mathf.Sin(_currentTime) + 1) / 2;
  var position = transform.position;
  position = Vector3.Lerp(new Vector3(-10,position.y),new Vector3(10,position.y),progress);
  transform.position = position;
 }
}
