using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newXPosition = Player.transform.position.x - offset.x;
        float newZPosition = Player.transform.position.z;

        transform.position = new Vector3(newXPosition, transform.position.y, newZPosition - 5);
    }
}
