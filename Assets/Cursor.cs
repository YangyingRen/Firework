using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cursor : MonoBehaviour
{ 
    public GameObject firework, cursor;
    public RectTransform button;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        button.anchoredPosition = new Vector2(mousePos.x*110f, mousePos.y*110f);
        cursor.transform.position=new Vector2(mousePos.x, mousePos.y);

    }

    public void Firework(){
       Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       firework.transform.position=new Vector2(mousePos.x, mousePos.y);
       Instantiate(firework);     
    }
   

}
