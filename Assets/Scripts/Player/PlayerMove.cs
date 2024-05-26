using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /*Velocità con cui Player si muove avanti */
    public float moveSpeed = 5;

    /*Velocità con cui Player si muove a destra e sinistra */
    public float leftRightSpeed = 4;

    public static bool canMove = false;

    void FixedUpdate()
    {
        /*
         * Player si muove avanti costantemente
         */
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {

                /*
                * Prima che Player si muova verso sinistra controlla se ha già raggiunto il bordo sinistro
                */
                if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
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

      
}
