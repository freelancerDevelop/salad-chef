using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerMove : MonoBehaviour
{

    private ThirdPersonCharacter m_Character; // A reference to the ThirdPersonCharacter on the object
    private Vector3 m_Move;
    public string horizontalAxis, verticalAxis;


    private void Start()
    {
        m_Character = GetComponent<ThirdPersonCharacter>();
    }





    // Fixed update is called in sync with physics
    private void FixedUpdate()
    {
        // read inputs
        float h = CrossPlatformInputManager.GetAxis(horizontalAxis);
        float v = CrossPlatformInputManager.GetAxis(verticalAxis);

        m_Move = v * Vector3.forward + h * Vector3.right;

        m_Character.Move(m_Move, false, false);


    }
}
