using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /*Velocità con cui Player si muove avanti */
    public float moveSpeed = 5;
    bool IsJumping = false;
    /*Velocità con cui Player si muove a destra e sinistra */
    public float leftRightSpeed = 4;
    Rigidbody rb;
    public FixedJoystick Joysk;
    public static bool canMove = false;
    public int TIMER;
    void FixedUpdate()
    {
        /*
         * Player si muove avanti costantemente
         */
        if (IsJumping == true)
        {
            TIMER++;
            if (TIMER <= 20)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 9);
            }
          
            if (TIMER >= 20 && TIMER < 40)
            {
                transform.Translate(Vector3.down * Time.deltaTime * 9);
            }

            if(TIMER >= 40)
            {
                IsJumping = false;
                TIMER = 0;
            }
        }
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (canMove == true)
        {                      
            if (Joysk.Horizontal < 0)
            {

                /*
                * Prima che Player si muova verso sinistra controlla se ha già raggiunto il bordo sinistro
                */
                if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
            }
            if (Joysk.Horizontal > 0)
            {

                /*
                 * Prima che Player si muova verso destra controlla se ha giàa raggiunto il bordo destro
                 */
                if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
                }

            }
        }
    }   
    public void Jump()
    {
        IsJumping = true;

    }
      
}
