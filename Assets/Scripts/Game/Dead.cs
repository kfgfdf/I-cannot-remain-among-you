using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Dead : MonoBehaviour
{
    public Rigidbody2D rb;  
    //public GameObject Respawn; 
    public GameObject DeadMenu; 
    public GameObject WallDontBack;

    public GameObject Player;
    public PlayerHP script;
    public MovingPlayer scriptMove;

    void Start()
    {
        Player = GameObject.Find("kucha");
        script = Player.GetComponent<PlayerHP>();
        scriptMove = Player.GetComponent<MovingPlayer>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {
           // DeadMenu.SetActive(true);
            script.HP = script.HP - 1;
            if(scriptMove.isGrounded == false)
            rb.velocity = Vector2.up * 6;
            else
            rb.transform.position = new Vector2(rb.transform.position.x -1.3f, rb.transform.position.y);
            //Time.timeScale = 0;
            
        }
    }
    public void GetButtDead()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //SceneManager.LoadScene(2);
       //WallDontBack.transform.position = new Vector2(-7.3f, 0f);
        //DeadMenu.SetActive(false);
        //Time.timeScale = 1;
        //rb.transform.position = Respawn.transform.position;
    }
}
