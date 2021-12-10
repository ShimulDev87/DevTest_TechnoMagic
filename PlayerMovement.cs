using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform playerTrans;
    public VariableJoystick virtualJoystick;
    public float moveSpeed;
    public float speedOfRotation;
    public const float frameRateCount = 15f;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while(Application.isPlaying)
        {
            MoveAndRotation();
            yield return new WaitForSeconds(1 / frameRateCount); 
        } 

       
    }

    private void MoveAndRotation()
    {
        Vector3 directionOfJoystick = Vector3.forward * virtualJoystick.Vertical +
                Vector3.right * virtualJoystick.Horizontal;
        directionOfJoystick.Normalize();  

        playerTrans.Translate(directionOfJoystick * moveSpeed * Time.deltaTime, Space.World);

        if(directionOfJoystick != Vector3.zero)
        {
            Quaternion RotationOfRolling = Quaternion.LookRotation(directionOfJoystick, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, RotationOfRolling,
                speedOfRotation * Time.deltaTime);  

        }
    }

}
