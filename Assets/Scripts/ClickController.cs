using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickController : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerDown(PointerEventData data)
    {
        transform.localScale += new Vector3(0.1f,0.1f,0.1f);
        MoneyControl.AddMoney(1);
    }
    public void OnPointerUp(PointerEventData data)
    {
        transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }
}
