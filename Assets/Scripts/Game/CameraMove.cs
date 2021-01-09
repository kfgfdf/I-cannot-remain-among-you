using UnityEngine;
using UnityEngine.SceneManagement;


public class CameraMove : MonoBehaviour
{
    public GameObject Player;
    public GameObject WallDontBack;
    public float PosWallDontBack;
    public MovingPlayer script;
    public Rigidbody2D pl;
    public Rigidbody2D wal;
    public GameObject CheckPlayerDistforSpawnGround;
    public float minus;
    public float minusGround;

    public ScoreGround MetersScript;

    void Update()
    {
        GameObject go = GameObject.Find("kucha");
            if(go != null)
            {
        PosWallDontBack = WallDontBack.transform.position.x -4;
        minusGround = CheckPlayerDistforSpawnGround.transform.position.x - Player.transform.position.x;
        if(script.MoveInput > 0 && minusGround <= 8)
        {
            CheckPlayerDistforSpawnGround.transform.position = new Vector3(Player.transform.position.x + 8, -4, 0);
        }
        minus = Player.transform.position.x - WallDontBack.transform.position.x;
        transform.position = new Vector3(Player.transform.position.x + 2, Player.transform.position.y + 1.2f, -10);
        if(script.MoveInput > 0 && minus >= 15)
        {
            WallDontBack.transform.position = new Vector3(Player.transform.position.x -15, 0, 0);
        }
        
                 
               
            }
    }

    public void GetButtDead()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
        
//        PlayerPrefs.SetInt("coundDiamond", PlayerPrefs.GetInt("coundDiamond") + MetersScript.ScoreMeters /2);
    }
}
