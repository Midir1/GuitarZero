using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class GameTo : MonoBehaviour
{
    public static bool IsPlaying;

    public GameObject PausePanel, ScorePanel, FinishPanel;

    public List<AudioSource> AudioSources;

    public VideoPlayer VideoPlayer;

    public AudioSource AudioSource;

    public AudioClip applause, boo;

    public ScoreManager ScoreManager;


    private void Update()
    {
        PauseGame();
        
        if(IsPlaying && !VideoPlayer.isPlaying) VideoPlayer.Play();
        if(!IsPlaying && VideoPlayer.isPlaying) VideoPlayer.Pause();
    }

    public void PlayGame()
    {
        Cursor.visible = false;

        IsPlaying = true;
        
        foreach (var audioSource in AudioSources)
        {
            audioSource.UnPause();
        }
    }

    public void FinishGame()
    {
        Cursor.visible = true;

        IsPlaying = false;
        
        FinishPanel.SetActive(true);

        if (ScoreManager.RedScore < 500 && ScoreManager.BlueScore < 500 && ScoreManager.YellowScore < 500 &&
            ScoreManager.GreenScore < 500)
        {
            AudioSource.clip = boo;
            AudioSource.Play();
        }
        else
        {
            AudioSource.clip = applause;
            AudioSource.Play();
        }
    }

    private void PauseGame()
    {
        if (IsPlaying && Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            IsPlaying = false;
            PausePanel.SetActive(true);
            ScorePanel.SetActive(false);

            foreach (var audioSource in AudioSources)
            {
                audioSource.Pause();
            }
        }
    }

    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}