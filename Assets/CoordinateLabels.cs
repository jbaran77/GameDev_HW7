using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Security.Cryptography.X509Certificates;

[ExecuteAlways]
public class CoordinateLabels : MonoBehaviour
{

    TextMeshPro label;

    Vector2Int coordinates = new Vector2Int();

    // Start is called before the first frame update
    void Start()
    {
        label = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!Application.isPlaying){
            DisplayLabelCoordinates();
            UpdateObjectName();
        }
    }

    void DisplayLabelCoordinates(){
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x/ 10);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z/ 10);
        label.text = coordinates.x + " , " + coordinates.y;
    }

    void UpdateObjectName() {
        transform.parent.name = coordinates.ToString();
    }
}
