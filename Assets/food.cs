using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    public Collider2D gridArea;
    private List<Transform> _segments;
    public Transform segmentPrefab; 

    private void Start()
    {
        RandomizePosition();
       
    }

    public void RandomizePosition()
    {
        Bounds bounds = gridArea.bounds;

       
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

   
        x = Mathf.Round(x);
        y = Mathf.Round(y);

        transform.position = new Vector2(x, y);
    }

    private void OnTriggerEnter2D(Collider2D other)

    {
        if(other.tag == "Player"){
        RandomizePosition();}
    }

}
   
   

