using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public  bool gameIsPaused = false;
    public static GameControl instance;
   //public GameObject gameovertext;
   public bool gameover =false;
   public Text scoreText;
   public float scrollSpeed=-1.5f;
   
   private int score =0;
    public GameObject pauseMenuUI;

    void Awake(){
	   if(instance==null){
		   instance=this;
	   }else if(instance!=this){
		   Destroy(gameObject);
	   }
   }
   
   void Update(){
        
	   if(gameover==true&& Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            //Time.timeScale = 1f;
	   }
   }
   
   public void BirdScored(){
	   if(gameover)
		   return;
	   score++;
	   
	   scoreText.text = "Score  "+score.ToString();
        FindObjectOfType<AudioManager>().Play("Coin");
    }
   
   public void BirdDied(){
        //gameovertext.SetActive(true);
        pauseMenuUI.SetActive(true);
       //Time.timeScale = 0f;
        gameover =true;
        if(gameover)
        FindObjectOfType<AudioManager>().Play("GameOver");
    
}
}
