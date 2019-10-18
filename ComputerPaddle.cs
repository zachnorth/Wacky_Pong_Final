using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ComputerPaddle : Paddle
{
    Rigidbody2D rigidBody;

    Vector2 newPosition1 = Vector2.zero;
    float halfPaddleHeight1;
    float halfPaddleWidth1;

    public void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        BoxCollider2D bc2d = GetComponent<BoxCollider2D>();
        halfPaddleHeight1 = bc2d.size.y / 2;
        halfPaddleWidth1 = bc2d.size.x / 2;
    }

    public override void FixedUpdate()
    {
        GameObject temp = FindClosestBall();
        if (!frozen && temp != null)
        {
            newPosition1 = rigidBody.position;

            if(temp.transform.position.y - rigidBody.transform.position.y > 0.1)
            {
                newPosition1.y += ConfigurationUtils.PaddleMoveUnitsPerSecond * Time.deltaTime;
                newPosition1.y = CalculateClampedY(newPosition1.y);
                rigidBody.MovePosition(newPosition1);
            }
            else if(temp.transform.position.y - rigidBody.transform.position.y < -0.1)
            {
                newPosition1.y -= ConfigurationUtils.PaddleMoveUnitsPerSecond * Time.deltaTime;
                newPosition1.y = CalculateClampedY(newPosition1.y);
                rigidBody.MovePosition(newPosition1);
            }
        }
    }


    public GameObject FindClosestBall()
    {
        GameObject[] balls;
        GameObject[] pickups;

        balls = GameObject.FindGameObjectsWithTag("Ball");
        pickups = GameObject.FindGameObjectsWithTag("Pickup");

        GameObject closestB = null;
        GameObject closestP = null;

        float distance = Mathf.Infinity;
        Vector3 position = transform.position;

        foreach(GameObject ball in balls)
        {
            Rigidbody2D ballRB2D = ball.GetComponent<Rigidbody2D>();
            Vector3 diff = ball.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if(curDistance < distance)
            {
                if(ballRB2D.velocity.x > 0)
                {
                    closestB = ball;
                    distance = curDistance;
                }
            }
        }
        

        distance = Mathf.Infinity;
        foreach(GameObject pickup in pickups)
        {
            Rigidbody2D pickupRB2D = pickup.GetComponent<Rigidbody2D>();
            Vector3 diff1 = pickup.transform.position - position;
            float curDistance1 = diff1.sqrMagnitude;
            if(curDistance1 < distance)
            {
                if(pickupRB2D.velocity.x > 0)
                {
                    closestP = pickup;
                    distance = curDistance1;
                }
            }
        }

        
        if(closestB == null && closestP != null)
        {
            return closestP;
        }
        else if(closestB != null && closestP == null)
        {
            return closestB;
        }

        else if (closestB != null && closestP != null && (closestB.transform.position - transform.position).sqrMagnitude < 
            (closestP.transform.position - transform.position).sqrMagnitude)
        {
            return closestB;
        }
        else
        {
            return closestP;
        }
    }


    float CalculateClampedY(float y)
    {
        if (y + halfPaddleHeight1 > ScreenUtils.ScreenTop)
        {
            y = ScreenUtils.ScreenTop - halfPaddleHeight1;
        }
        else if (y - halfPaddleHeight1 < ScreenUtils.ScreenBottom)
        {
            y = ScreenUtils.ScreenBottom + halfPaddleHeight1;
        }
        return y;
    }
}
