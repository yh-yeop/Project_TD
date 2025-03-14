using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform waypointsParent;
    private Transform[] waypoints;
    public float speed = 2f;
    private int currentWaypointIndex = 0;

    void Start()
    {
        int count=waypointsParent.childCount;
        waypoints=new Transform[count];
        for (int i=0;i<count;i++)
        {
            waypoints[i]=waypointsParent.GetChild(i);
            Debug.Log(waypoints.Length);
        }
    }

    void Update()
    {
        if(waypoints.Length==0) return;

        Transform targetWaypoint=waypoints[currentWaypointIndex];

        Vector2 direction=(targetWaypoint.position-transform.position).normalized;
        transform.Translate(direction*speed*Time.deltaTime);

        if(currentWaypointIndex==waypoints.Length-1)
        {
            Debug.Log("끝");
        }

        else if(CollideCheck(targetWaypoint))
        {
            Debug.Log((currentWaypointIndex+1)+"번 웨이포인트 도달");
            currentWaypointIndex++;
        }
    }
    bool CollideCheck(Transform targetWaypoint)
    {
        if (Vector2.Distance(transform.position, targetWaypoint.position)<0.1f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}