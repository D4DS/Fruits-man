using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
{

    public GameObject arrow;
    public float launchForce;
    public Transform shotPoint;
    public GameObject connonGirl;
    public GameObject Player;
    public GameObject Joystick;
    public GameObject ConnonPower;
   public GameObject countDown;
   public static int CheckTimeManager =0;

    
    //public float  slowdownLength = 2f;
    public float respawnTime = 1.0f;

    public GameObject point;
     GameObject[] points;
    public int numberOfPoints;
    public float  spaceBetweenPoints;
    Vector2 direction;
    public GameObject PlayerObject;
    
    public GameObject cloudFrame;

    // Start is called before the first frame update
    void Start()
    {
       // GameObject e = Instantiate(countDown) as GameObject;
      //  e.transform.position = transform.position;
       // e.transform.position = new Vector2(transform.position.x - 0.6f,transform.position.y +0.3f);
        points = new GameObject[numberOfPoints];
        for (int i=0; i < numberOfPoints; i++)
        {
            points[i] = Instantiate(point, shotPoint.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    { 
  
        if (Input.touchCount >0)
        {
        Touch touch = Input.GetTouch(0);
      Vector2 bowPosition =  transform.position;
     // Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
     Vector2 mousePosition = Camera.main.ScreenToWorldPoint(touch.position);
       direction = mousePosition - bowPosition;
      transform.right =direction;
        }

     if (Input.touches[0].phase == TouchPhase.Ended && Input.touchCount >0) 
     // if(Input.GetMouseButtonDown(0))
      {
           Shoot();
           CheckTimeManager =1;
           Gamesettings.clicked = 0;
           GameObject e = Instantiate(countDown) as GameObject;
           e.transform.position = transform.position;
           GameObject g = Instantiate(countDown) as GameObject;
            g.transform.position = new Vector2(PlayerObject.transform.position.x,PlayerObject.transform.position.y);

     }
      for (int i = 0; i < numberOfPoints; i++)
      {
          points[i].transform.SetParent(connonGirl.transform);
          points[i].transform.position = PointPostion(i * spaceBetweenPoints);
      }
    }

public void Shoot(){

    GameObject newArrow = Instantiate(arrow, shotPoint.position, shotPoint.rotation);
    newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
    //  Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
//Time.timeScale = Mathf.Clamp(Time.timeScale, 0f,1f);
 //Time.timeScale = 1;
 StartCoroutine(asteroidWave());

 Player.SetActive(true);
 Joystick.SetActive(true);
ConnonPower.SetActive(true);



}

public void timer()
{
Time.timeScale = 1;
 connonGirl.SetActive(false);
}


Vector2 PointPostion(float t)
{
    Vector2 position = (Vector2)shotPoint.position + (direction.normalized * launchForce * t) + 0.5f * Physics2D.gravity * (t * t);
return position;
}


           IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            timer();
        }
    }


}
