using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour
{
    private Transform track;
    private float moveSpeed = 4;

    void Start()
    {
        track = GameObject.Find("BoatFloat").transform;
    }

    void Update ()
    {
        float move = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards (transform.position, track.position, move);

        // Orient correctly
        transform.rotation = Quaternion.LookRotation(transform.position - track.position);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "WoodBoat")
        {
            Debug.Log ("Reached the end!");
            Application.Quit();
        }
    }
}
