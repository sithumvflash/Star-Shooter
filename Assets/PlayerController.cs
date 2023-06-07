using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using unirtEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
  // [SerializeField] InputAction movement;
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
