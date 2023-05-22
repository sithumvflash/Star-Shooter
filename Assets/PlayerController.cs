using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    float horizontalThrow = Input.GetAxis("Horizontal");
    // creating a float variable to get the input of GetAxis
    Debug.Log(horizontalThrow);

    float verticalLift = Input.GetAxis("Vertical");
    Debug.Log(verticalLift);
  }
}
