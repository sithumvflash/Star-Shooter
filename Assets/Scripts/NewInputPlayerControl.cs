// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using unirtEngine.InputSystem;

// public class PlayerController : MonoBehaviour
// {
//   [SerializeField] InputAction movement;
//   void Start()
//   {

//   }

//   void onEnable()
//   {
//     movement.Enable();
//   }

//   void onDisable()
//   {
//     movement.Disable();
//   }


//   void Update()
//   {
//     float horizontalThrow = movement.ReadValue<vector2>().x;
//     float verticalThrow = movement.ReadValue<vector2>().y;

//     // x is used to access the X component of a Vector2 object. 


//     Debug.Log(horizontalThrow);

//     Debug.Log(verticalThrow);


//   }
// }
