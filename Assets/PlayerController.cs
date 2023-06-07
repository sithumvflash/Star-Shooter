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
    float horizontalThrow = Input.GetAxis("Horizontal");
    // creating a float variable to get the input of GetAxis
    Debug.Log(horizontalThrow);

    float verticalThrow = Input.GetAxis("Vertical");
    Debug.Log(verticalThrow);
  }
}
