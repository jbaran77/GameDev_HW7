using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    float waitTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        // PrintWayPointName();
        StartCoroutine(FollowPath());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrintWayPointName(){
        foreach(Waypoint waypoint in path){
            Debug.Log(waypoint.name);
        }
    }

    IEnumerator FollowPath(){
        
        foreach(Waypoint waypoint in path){
            Vector3 startPos = transform.position;
            Vector3 endPos = waypoint.transform.position;
            float travelPercentage = 0;


            while(travelPercentage < 1f){
                travelPercentage = travelPercentage + Time.deltaTime;
                transform.position = Vector3.Lerp(startPos,endPos,travelPercentage);
                yield return new WaitForEndOfFrame();
            }

            
        }
    }
}
