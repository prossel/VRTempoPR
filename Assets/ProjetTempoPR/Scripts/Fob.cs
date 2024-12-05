using UnityEngine;
using UnityEngine.EventSystems;

public class Fob : MonoBehaviour, IPointerClickHandler
{

    public float speed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object on z axis
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        // if the distance between the object and the camera is less than 1.5
        if (Vector3.Distance(transform.position, Camera.main.transform.position) < 1f)
        {
            Catch();
        }
    }

    // This function is called when the object is clicked or touched
    public void Catch() {
        Debug.Log("Catch");

        // destroy the object
        Destroy(gameObject);
    }

}
