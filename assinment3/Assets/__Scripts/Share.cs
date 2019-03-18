using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Share : MonoBehaviour
{
    const string TWITTER_URL = "http://twitter.com/intent/tweet";
    const string TWITTER_LANG = "en";
    private string _tweet = "HIGHEST SCORE";
    private void Start()
    {
        _tweet += ScoreManager.HIGH_SCORE.ToString();
    }
    public void ShareOnTwitter()
    {

#pragma warning disable CS0618 
        Application.OpenURL(TWITTER_URL + "?text=" + WWW.EscapeURL(_tweet) + "&amp;lang=" + WWW.EscapeURL(TWITTER_LANG));
#pragma warning restore CS0618 

    }

}