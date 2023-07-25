using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanker_Pathfinding : MonoBehaviour
{
    public float speed = 0;
    public float delay = 0;
    public float raycastDistance = 1.0f;
    public LayerMask raycastLayerMask;
    public Transform Player;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (delay < 30)
        {
            delay++;
        }
        else
        {
            Vector2 currentPosition = transform.position;
            RaycastHit2D hitNorth = Physics2D.Raycast(currentPosition, Vector2.up, raycastDistance);
            RaycastHit2D hitNorthEast = Physics2D.Raycast(currentPosition, (Vector2.up + Vector2.right).normalized, raycastDistance);
            RaycastHit2D hitEast = Physics2D.Raycast(currentPosition, Vector2.right, raycastDistance);
            RaycastHit2D hitSouthEast = Physics2D.Raycast(currentPosition, (Vector2.down + Vector2.right).normalized, raycastDistance);
            RaycastHit2D hitSouth = Physics2D.Raycast(currentPosition, Vector2.down, raycastDistance);
            RaycastHit2D hitSouthWest = Physics2D.Raycast(currentPosition, (Vector2.down + Vector2.left).normalized, raycastDistance);
            RaycastHit2D hitWest = Physics2D.Raycast(currentPosition, Vector2.left, raycastDistance);
            RaycastHit2D hitNorthWest = Physics2D.Raycast(currentPosition, (Vector2.up + Vector2.left).normalized, raycastDistance);

            Vector2 playerDirection = Player.position - transform.position;
            float angle = Vector2.SignedAngle(Vector2.up, playerDirection);
            Debug.Log(angle);
            delay = 0;
        }
    }
}