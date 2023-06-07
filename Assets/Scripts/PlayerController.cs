using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

  void Start()
  {

  }


  void Update()
  {
    float xThrow = Input.GetAxis("Horizontal");
    float yThrow = Input.GetAxis("Vertical");
    // creating a float variable to get the input of GetAxis
    // Debug.Log(xThrow);
    // Debug.Log(yThrow);

    float xOffset = .1f;
    float newXPos = transform.localPosition.x + xOffset;

    transform.localPosition = new Vector3
    (transform.localPosition.x,
    transform.localPosition.y,
    transform.localPosition.z);
  }
}
