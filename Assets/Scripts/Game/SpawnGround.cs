using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{
   public GameObject WallDontBack;
   public GameObject Destroyer;
    public GameObject Ground;

    private int rnd;
    //private int rndray;
    public Rigidbody2D Player;
    private GameObject NewGround;
    //private float positChekaNewGround;

    //public float minus;
   // public CameraMove scriptCamer;
    //public GameObject CheckPlayerDistforSpawnGround;
    private float positCheka;
    //[SerializedField]
   // private int toglground;
   public GameObject BOTerminal1;
   private GameObject newBOTerminal1;

   public GameObject BOTerminal2;
   private GameObject newBOTerminal2;
   private int rndTerminal;

   public GameObject flowerTrain;
   private GameObject newFlowerTrain;

    public GameObject flowerMix;
    private GameObject newFlowerMix;

    public GameObject flowerLong;
    private GameObject newFlowerLong;

    public GameObject stake;
    public GameObject stakeCactus;
    private GameObject newStake;
    private int rndStake;
    private int rndEnemy;

    public GameObject Zombie;
    public GameObject Zombie2;
    public GameObject Zombie3;
    public GameObject newZombie;
    //public GameObject newZombie2;
    private int rndZombie;

    private int NumberZombie;


  

    void Start()
    {
      //PlayerPrefs.SetInt("NumberZombie", 2); 
      //NumberZombie = 
        if (!PlayerPrefs.HasKey("NumberZombie")) 
            {
                NumberZombie = 1;
            }
        else
        {
            NumberZombie = PlayerPrefs.GetInt("NumberZombie"); 
        }
       //rndray = 0;
        Player = GetComponent<Rigidbody2D>();
        //Move = script.MoveInput;
       // StartCoroutine(Spawner());
      // StartCoroutine(Spawner());
    }
    
    void Update()
    {
       Destroyer.transform.position = new Vector2(WallDontBack.transform.position.x - 15, 0);

//       if(Mathf.Approximately(NewGround.transform.position.x, scriptCamer.PosWallDontBack))
  //     {
    //      Destroy(NewGround);
      // }
      // minus = scriptCamer.minusGround;
     // minus = scriptCamer.PosWallDontBack;
      // if(CheckPlayerDistforSpawnGround.transform.position.x == 18f)
       
       // positCheka = Player.transform.position.x + 18;

       positCheka = Player.transform.position.x + 19;
       
       //test = Player.transform.TransformPoint(Vector3.right * 2);

      // positCheka = Mathf.Approximately(Player.transform.position.x, Ground.transform.position.x);
      //
       

      // positChekaGround = Ground.transform.position.x + 8;
      // positChekaGround2 = Ground2.transform.position.x + 8;
          // StopAllCoroutines();
      // %= 4
      //toglground = 0;
    }

    void OnTriggerEnter2D (Collider2D other)
    {
       if(other.gameObject.tag == "GroundTrigger")
        {
          //Debug.Log("SpawnGround withtrigger");
         // NewGround = Instantiate(Ground, new Vector3(positCheka, 0, 0), Quaternion.identity) as GameObject;
          if(NumberZombie == 2)
          {
           rndZombie = Random.Range(1, 5);
          }
          if(NumberZombie == 3)
          {
           rndZombie = Random.Range(1, 10);
          }
           rndStake = Random.Range(1, 5);
           rnd = Random.Range(1, 7);
           rndTerminal = Random.Range(1, 8);
           rndEnemy = Random.Range(1, 10);
           //Debug.Log("SpawnGround withtrigger! rndray = 0" + "rnd = " + rnd); 
           if(rnd == 1 || rnd == 2 || rnd == 3)
           {

              
               
               //rndray = 1;
               NewGround = Instantiate(Ground, new Vector3(Mathf.Floor(positCheka), 1, 0), Quaternion.identity)as GameObject;
               if(rndTerminal == 1){newBOTerminal1 = Instantiate(BOTerminal1, new Vector3(Mathf.Floor(positCheka) +1, 4.1f, 0), Quaternion.identity)as GameObject;
               newFlowerTrain = Instantiate(flowerTrain, new Vector3(Mathf.Floor(positCheka) - 1.5f , 3.325f, 0), Quaternion.identity)as GameObject;}
               if(rndTerminal == 2){newFlowerTrain = Instantiate(flowerTrain, new Vector3(Mathf.Floor(positCheka) + 1.5f , 3.325f, 0), Quaternion.identity)as GameObject; 
               newFlowerTrain = Instantiate(flowerTrain, new Vector3(Mathf.Floor(positCheka) - 1, 3.325f, 0), Quaternion.identity)as GameObject;}
               if(rndTerminal == 3){newBOTerminal2 = Instantiate(BOTerminal2, new Vector3(Mathf.Floor(positCheka) -1.5f, 4.1f, 0), Quaternion.identity)as GameObject;
               newFlowerTrain = Instantiate(flowerTrain, new Vector3(Mathf.Floor(positCheka) + 1.5f , 3.325f, 0), Quaternion.identity)as GameObject;}
               if(rndTerminal == 4){newFlowerLong = Instantiate(flowerLong, new Vector3(Mathf.Floor(positCheka) -0.75f, 3.55f, 0), Quaternion.identity)as GameObject;
               newFlowerTrain = Instantiate(flowerTrain, new Vector3(Mathf.Floor(positCheka) + 1.5f , 3.325f, 0), Quaternion.identity)as GameObject;}
               if(rndTerminal == 5){newFlowerMix = Instantiate(flowerMix, new Vector3(Mathf.Floor(positCheka) +0.75f, 3.35f, 0), Quaternion.identity)as GameObject;
               newFlowerTrain = Instantiate(flowerTrain, new Vector3(Mathf.Floor(positCheka) - 1f , 3.325f, 0), Quaternion.identity)as GameObject;}
               if(rndTerminal == 6){newFlowerTrain = Instantiate(flowerTrain, new Vector3(Mathf.Floor(positCheka) + 1.5f , 3.325f, 0), Quaternion.identity)as GameObject;}
               if(rndEnemy == 1){
                 if(rndStake == 1 || rndStake == 2 || rndStake == 3) newStake = Instantiate(stake, new Vector3(Mathf.Floor(positCheka), 3.7f, 0), Quaternion.identity)as GameObject;
                 if(rndStake == 4) newStake = Instantiate(stakeCactus, new Vector3(Mathf.Floor(positCheka), 3.7f, 0), Quaternion.identity)as GameObject;}
               if(rndEnemy == 3 || rndEnemy == 2 || rndEnemy == 4){
                 if(NumberZombie == 1) newZombie = Instantiate(Zombie, new Vector3(Mathf.Floor(positCheka), 4f, 0), Quaternion.identity)as GameObject;
                 if(NumberZombie == 2) {
                 if(rndZombie == 1 || rndZombie == 3) newZombie = Instantiate(Zombie2, new Vector3(Mathf.Floor(positCheka), 4f, 0), Quaternion.identity)as GameObject;
                 if(rndZombie == 2 || rndZombie == 4) newZombie = Instantiate(Zombie, new Vector3(Mathf.Floor(positCheka), 4f, 0), Quaternion.identity)as GameObject;}
                 if(NumberZombie == 3) {
                 if(rndZombie == 1 || rndZombie == 3 || rndZombie == 5) 
                 newZombie = Instantiate(Zombie2, new Vector3(Mathf.Floor(positCheka), 4f, 0), Quaternion.identity)as GameObject;
                 if(rndZombie == 2 || rndZombie == 4 || rndZombie == 6) 
                 newZombie = Instantiate(Zombie, new Vector3(Mathf.Floor(positCheka), 4f, 0), Quaternion.identity)as GameObject;
                 if(rndZombie == 7 || rndZombie == 8 || rndZombie == 9) 
                 newZombie = Instantiate(Zombie3, new Vector3(Mathf.Floor(positCheka), 4f, 0), Quaternion.identity)as GameObject;}}
           }
           if(rnd == 4 || rnd == 5 || rnd == 6)
           {
               //rndray = 0;
               NewGround = Instantiate(Ground, new Vector3(Mathf.Floor(positCheka), 0, 0), Quaternion.identity)as GameObject; 
               if(rndTerminal == 1){newBOTerminal1 = Instantiate(BOTerminal1, new Vector3(Mathf.Floor(positCheka) - 1.5f, 3.1f, 0), Quaternion.identity)as GameObject;
               newFlowerTrain = Instantiate(flowerTrain, new Vector3(Mathf.Floor(positCheka) +1.5f , 2.325f, 0), Quaternion.identity)as GameObject; }
               if(rndTerminal == 2){newFlowerTrain = Instantiate(flowerTrain, new Vector3(Mathf.Floor(positCheka) +1 , 2.325f, 0), Quaternion.identity)as GameObject; 
               newFlowerTrain = Instantiate(flowerTrain, new Vector3(Mathf.Floor(positCheka) - 1, 2.325f, 0), Quaternion.identity)as GameObject;}
               if(rndTerminal == 3){newBOTerminal2 = Instantiate(BOTerminal2, new Vector3(Mathf.Floor(positCheka) + 1.5f, 3.1f, 0), Quaternion.identity)as GameObject;
               newFlowerTrain = Instantiate(flowerTrain, new Vector3(Mathf.Floor(positCheka) -1 , 2.325f, 0), Quaternion.identity)as GameObject; }
               if(rndTerminal == 4){newFlowerLong = Instantiate(flowerLong, new Vector3(Mathf.Floor(positCheka) +0.75f, 2.55f, 0), Quaternion.identity)as GameObject;
               newFlowerTrain = Instantiate(flowerTrain, new Vector3(Mathf.Floor(positCheka) - 1.5f , 2.325f, 0), Quaternion.identity)as GameObject; }
               if(rndTerminal == 5){newFlowerMix = Instantiate(flowerMix, new Vector3(Mathf.Floor(positCheka) -0.75f, 2.35f, 0), Quaternion.identity)as GameObject;
               newFlowerTrain = Instantiate(flowerTrain, new Vector3(Mathf.Floor(positCheka) +1 , 2.325f, 0), Quaternion.identity)as GameObject; }
               if(rndTerminal == 6){newFlowerTrain = Instantiate(flowerTrain, new Vector3(Mathf.Floor(positCheka) + 1.5f , 2.325f, 0), Quaternion.identity)as GameObject; }
               if(rndEnemy == 3){
                 if(rndStake == 2 || rndStake == 1 || rndStake == 3) newStake = Instantiate(stake, new Vector3(Mathf.Floor(positCheka) , 2.7f, 0), Quaternion.identity)as GameObject;
                 if(rndStake == 4) newStake = Instantiate(stakeCactus, new Vector3(Mathf.Floor(positCheka) , 2.7f, 0), Quaternion.identity)as GameObject;}
                if(rndEnemy == 4 || rndEnemy == 2 || rndEnemy == 5){
                  if(NumberZombie == 1) newZombie = Instantiate(Zombie, new Vector3(Mathf.Floor(positCheka), 3f, 0), Quaternion.identity)as GameObject;
                  if(NumberZombie == 2) {
                  if(rndZombie == 2 || rndZombie == 4) newZombie = Instantiate(Zombie2, new Vector3(Mathf.Floor(positCheka), 3f, 0), Quaternion.identity)as GameObject;
                  if(rndZombie == 1 || rndZombie == 3) newZombie = Instantiate(Zombie, new Vector3(Mathf.Floor(positCheka), 3f, 0), Quaternion.identity)as GameObject;}
                  if(NumberZombie == 3) {
                  if(rndZombie == 1 || rndZombie == 3 || rndZombie == 5) 
                  newZombie = Instantiate(Zombie2, new Vector3(Mathf.Floor(positCheka), 3f, 0), Quaternion.identity)as GameObject;
                  if(rndZombie == 2 || rndZombie == 4 || rndZombie == 6) 
                  newZombie = Instantiate(Zombie, new Vector3(Mathf.Floor(positCheka), 3f, 0), Quaternion.identity)as GameObject;
                  if(rndZombie == 7 || rndZombie == 8 || rndZombie == 9) 
                  newZombie = Instantiate(Zombie3, new Vector3(Mathf.Floor(positCheka), 3f, 0), Quaternion.identity)as GameObject;}}
           }
         
        }
        
    }
    void OnTriggerStay2D (Collider2D other)
    {
      if(other.gameObject.tag == "GroundTrigger")
      {
        Destroy(other.gameObject);
      }
    }
          //if(Mathf.Approximately(WallDontBack.transform.position.x, Ground.transform.position.x))
          //{
            // Debug.Log("XYITA RABOTATET!");
            // Destroy(NewGround);
          //}

}
