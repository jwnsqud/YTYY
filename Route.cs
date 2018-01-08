using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Route : MonoBehaviour
{
    public static GameObject target;
    public static string target1;
    public Camera camera;


    RaycastHit hit;

    // Update is called once per frame
    private void Start()
    {
      
    }
    void Update()
    {

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonUp(0))
        {
           
            CastRay();
            if (target == this.gameObject)
            {
                target1 = Route.target.name;
                Announce.inform = true;
                target.SetActive(false);
           
            }

           
        }
        
    }
    
        
    

    void CastRay()
    {
        target = null;

        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

        if (hit.collider != null)
        {
            target = hit.collider.gameObject;
        }
    }
}
