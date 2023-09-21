using UnityEngine;
using UnityEngine.UI;

public class hitPoint : MonoBehaviour
{ 
    [SerializeField]
   
    Button b1;
    RaycastHit hit;

    private void Update()
    {
       

        if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
        {

            Debug.DrawLine(transform.position, hit.point, Color.green);
         
         


        }

      

    }

    public void Buttondown1()
    {

    
    }

    public void Buttondown()
    {

        if (hit.collider.tag != null)
        {
            Debug.Log("hitt : " + hit.collider.name);


        }
        else Debug.Log("no tag");
    }
}
