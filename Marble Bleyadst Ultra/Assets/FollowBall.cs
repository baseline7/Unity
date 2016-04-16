using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Ball;
public class FollowBall : MonoBehaviour {

    public GameObject player;
    public float damping;
    public Ball ball;

	// Use this for initialization
	void Start () {
	
        
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 target = player.transform.position - transform.position;
        Quaternion lookAt = Quaternion.LookRotation(target);

        transform.rotation = Quaternion.Lerp(transform.rotation, lookAt, damping);

        if (ball.dead == false)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x - 3, player.transform.position.y + 2, player.transform.position.z), damping / 4);
        }
	}
}
