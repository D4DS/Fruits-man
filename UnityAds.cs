using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UnityAds : MonoBehaviour, IUnityAdsListener
{
    // Start is called before the first frame update
 private string gameID = "3988561";
   // private string bannerID = "";
    //private string interstitialID = "Interstitial";
    private string rewardedVideoID = "rewardedVideo";
    public bool TestMode;
    //public Button showInterstitial;
    public Button watchRewardAd;
   // public Text gemsAmt;
    public static int checkrewarded = 0;

 public GameObject gameoverRestart;
 public GameObject settingsbutton;
 public GameObject archivementbutton;
 public GameObject CannonGirlButton;
 
 public GameObject  facebookbutton;
 public GameObject pauseButton;
 public GameObject exitbutton2;
 public GameObject joystick;
 public GameObject connonGirl;
 public GameObject Gameoverpanel;

    void Start()
    {
        Advertisement.Initialize(gameID, TestMode);
        //showInterstitial.interactable = Advertisement.IsReady(interstitialID);
        watchRewardAd.interactable = Advertisement.IsReady(rewardedVideoID);
        Advertisement.AddListener(this);
    }

    //public void ShowInterstitial()
   // {
     //  if (Advertisement.IsReady(interstitialID))
     //   {
        //   Advertisement.Show(interstitialID);
     //  }
   // }

    public void ShowRewardedVideo()
    {
        Advertisement.Show(rewardedVideoID);
    }

    //public void HideBanner()
   // {
    //    Advertisement.Banner.Hide();
  //  }

    public void OnUnityAdsReady(string placementID)
    {
        if (placementID == rewardedVideoID)
        {
            watchRewardAd.interactable = true;
        }

       // if (placementID == interstitialID)
      //  {
      //     showInterstitial.interactable = true;
     //   }

       // if (placementID == bannerID)
     //   {
       //     Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
         //   Advertisement.Banner.Show(bannerID);
       // }
    }

    public void OnUnityAdsDidFinish(string placementID, ShowResult showResult)
    {
        if (placementID == rewardedVideoID)
        {
            if (showResult == ShowResult.Finished)
            {
                GetReward();
            }
            else if (showResult == ShowResult.Skipped)
            {
                //Do nothing
            }
            else if (showResult == ShowResult.Failed)
            {
                //tell player ads failed
            }
        }
    }


    public void OnUnityAdsDidError(string message)
    {
        //Show or log the error here
    }

    public void OnUnityAdsDidStart(string placementID)
    {
        //Do this if ads starts
    }

    public void GetReward()
    {
      //  if (PlayerPrefs.HasKey("gems"))
     //   {
           // int gemAmount = PlayerPrefs.GetInt("gems");
           // PlayerPrefs.SetInt("gems", gemAmount + 50);
       Time.timeScale = 1f;
       //gameoverRestart.gameObject.SetActive(false);
       //settingsbutton.gameObject.SetActive(true);
      // archivementbutton.gameObject.SetActive(true);
      // facebookbutton.gameObject.SetActive(true);
      // pauseButton.gameObject.SetActive(true);
      // exitbutton2.gameObject.SetActive(false);
      // connonGirl.gameObject.SetActive(false);
      // CannonGirlButton.gameObject.SetActive(true);  
      // joystick.gameObject.SetActive(true); 
      // Gameoverpanel.gameObject.SetActive(false);
       checkrewarded = 1;
     // Gameover.backgroundsound =0;

     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        
    //    } 
     //   else
      //  {
            //PlayerPrefs.SetInt("gems", 50);
     //   }

      //  gemsAmt.text = "Gems: " + PlayerPrefs.GetInt("gems").ToString();
    }
}
