using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOBGcamera : MonoBehaviour
{
    private GameObject RedCircle;
    private GameObject cameraBG;
    private GameObject Player;
    private float Distan;
    private float FloorDistan;
    private AreaEffector2D AE2D;
    private GameObject AreaEffector;
    private GameObject Maincam;



    void Start()
    {
        Maincam = GameObject.Find("Main Camera");
        cameraBG = GameObject.Find("GOBGcameraBG");
        RedCircle = GameObject.Find("GOBGcameraRedCircle");
        Player = GameObject.Find("kucha");
        AreaEffector = GameObject.Find("AreaEffectorsss");
        AE2D = AreaEffector.GetComponent<AreaEffector2D>();

    }
    void Update()
    {
        //cameraBG.transform.position = new Vector2(cameraBG.transform.position.x, Maincam.transform.position.y +3);
        Distan = Player.transform.position.x - cameraBG.transform.position.x;
        if(Distan >= 0)
        {
            AE2D.forceAngle = -50f;
        }
        else
        {
            AE2D.forceAngle = 50f;
        }
    }
    void FixUpdate()
    {
        
    }
}
