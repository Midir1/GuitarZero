using System;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private GameTo gameTo;
    
    [SerializeField] private AudioSource bass;
    [SerializeField] private AudioSource drum;
    [SerializeField] private AudioSource guitar;
    [SerializeField] private AudioSource organ;
    [SerializeField] private AudioSource lead;
    
    [Header("Bass")] 
    [SerializeField] private AudioClip hellBass;
    [SerializeField] private AudioClip badBass;
    [SerializeField] private AudioClip okayBass;
    [SerializeField] private AudioClip goodBass;
    
    [Header("Drum")] 
    [SerializeField] private AudioClip hellDrum;
    [SerializeField] private AudioClip badDrum;
    [SerializeField] private AudioClip okayDrum;
    [SerializeField] private AudioClip goodDrum;
    
    [Header("Guitar")] 
    [SerializeField] private AudioClip hellGuitar;
    [SerializeField] private AudioClip badGuitar;
    [SerializeField] private AudioClip okayGuitar;
    [SerializeField] private AudioClip goodGuitar;
    
    [Header("Organ")] 
    [SerializeField] private AudioClip hellOrgan;
    [SerializeField] private AudioClip badOrgan;
    [SerializeField] private AudioClip okayOrgan;
    [SerializeField] private AudioClip goodOrgan;

    public enum Channel
    {
        Bass,
        Drum,
        Guitar,
        Organ
    }

    private float timer;
    
    private void Update()
    {
        if (GameTo.IsPlaying)
        {
            timer += Time.deltaTime;
            
            if(timer >= 96f)
                gameTo.FinishGame();
        }
    }

    public void ChangeAudio(int channelScore, Channel channel)
    {
        if (channel == Channel.Bass)
        {
            if(channelScore < 250)
            {
                if (bass.clip == hellBass) return;
                
                float time = bass.time;
                
                bass.clip = hellBass;
                bass.time = time;
                
                bass.Play();
            }
            else if (channelScore < 500)
            {
                if (bass.clip == badBass) return;
                
                float time = bass.time;
                
                bass.clip = badBass;
                bass.time = time;
                
                bass.Play();
            }
            else if (channelScore < 750)
            {
                if (bass.clip == okayBass) return;
                
                float time = bass.time;
                
                bass.clip = okayBass;
                bass.time = time;
                
                bass.Play();
            }
            else
            {
                if (bass.clip == goodBass) return;
                
                float time = bass.time;
                
                bass.clip = goodBass;
                bass.time = time;
                
                bass.Play();
            }
        }
        else if (channel == Channel.Drum)
        {
            if(channelScore < 250)
            {
                if (drum.clip == hellDrum) return;
                
                float time = drum.time;
                
                drum.clip = hellDrum;
                drum.time = time;
                
                drum.Play();
            }
            else if (channelScore < 500)
            {
                if (drum.clip == badDrum) return;
                
                float time = drum.time;
                
                drum.clip = badDrum;
                drum.time = time;
                
                drum.Play();
            }
            else if (channelScore < 750)
            {
                if (drum.clip == okayDrum) return;
                
                float time = drum.time;
                
                drum.clip = okayDrum;
                drum.time = time;
                
                drum.Play();
            }
            else
            {
                if (drum.clip == goodDrum) return;
                
                float time = drum.time;
                
                drum.clip = goodDrum;
                drum.time = time;
                
                drum.Play();
            }
        }
        else if (channel == Channel.Guitar)
        {
            if(channelScore < 250)
            {
                if (guitar.clip == hellGuitar) return;
                
                float time = guitar.time;
                
                guitar.clip = hellGuitar;
                guitar.time = time;
                
                guitar.Play();
            }
            else if (channelScore < 500)
            {
                if (guitar.clip == badGuitar) return;
                
                float time = guitar.time;
                
                guitar.clip = badGuitar;
                guitar.time = time;
                
                guitar.Play();
            }
            else if (channelScore < 750)
            {
                if (guitar.clip == okayGuitar) return;
                
                float time = guitar.time;
                
                guitar.clip = okayGuitar;
                guitar.time = time;
                
                guitar.Play();
            }
            else
            {
                if (guitar.clip == goodGuitar) return;
                
                float time = guitar.time;
                
                guitar.clip = goodGuitar;
                guitar.time = time;
                
                guitar.Play();
            }
        }
        else if (channel == Channel.Organ)
        {
            if(channelScore < 250)
            {
                if (organ.clip == hellOrgan) return;
                
                float time = organ.time;
                
                organ.clip = hellOrgan;
                organ.time = time;
                
                organ.Play();
            }
            else if (channelScore < 500)
            {
                if (organ.clip == badOrgan) return;
                
                float time = organ.time;
                
                organ.clip = badOrgan;
                organ.time = time;
                
                organ.Play();
            }
            else if (channelScore < 750)
            {
                if (organ.clip == okayOrgan) return;
                
                float time = organ.time;
                
                organ.clip = okayOrgan;
                organ.time = time;
                
                organ.Play();
            }
            else
            {
                if (organ.clip == goodOrgan) return;
                
                float time = organ.time;
                
                organ.clip = goodOrgan;
                organ.time = time;
                
                organ.Play();
            }
        }
    }

    public void LeadSongCheck(int globalScore)
    {
        if (globalScore == 4000)
        {
            lead.volume = 1f;
        }
        else
            lead.volume = 0f;
    }
}