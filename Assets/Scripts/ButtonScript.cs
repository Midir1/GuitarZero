using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private bool isRed, isYellow, isGreen, isBlue;

    [SerializeField] private GameObject bubbleChannel;
    [SerializeField] private ParticleSystem effect;
    
    [SerializeField] private ScoreManager _scoreManager;
    
    private GameObject _bubble;
    
    private const string RedInput = "RedInput", YellowInput = "YellowInput", GreenInput = "GreenInput", BlueInput = "BlueInput";
    

    private void Update()
    {
        if (!GameTo.IsPlaying) return;
        
        if(isRed) _scoreManager.RedScore += ChangeScoreForColorButton(RedInput);
        else if(isYellow) _scoreManager.YellowScore += ChangeScoreForColorButton(YellowInput);
        else if(isGreen) _scoreManager.GreenScore += ChangeScoreForColorButton(GreenInput);
        else if(isBlue) _scoreManager.BlueScore += ChangeScoreForColorButton(BlueInput);
    }

    private int ChangeScoreForColorButton(string colorInput)
    {
        if (Input.GetButtonDown(colorInput))
        {
            if (_bubble != null)
            {
                effect.Play();
                Destroy(_bubble.gameObject);

                return 10;
            }

            if(bubbleChannel.transform.childCount != 0)
                Destroy(bubbleChannel.transform.GetChild(0).gameObject);

            return -10;
        }

        return 0;
    }

    private void OnTriggerEnter(Collider other) => _bubble = other.gameObject;
    private void OnTriggerExit(Collider other)
    {
        if(isRed) _scoreManager.RedScore -= 10;
        else if(isYellow) _scoreManager.YellowScore -= 10;
        else if(isGreen) _scoreManager.GreenScore -= 10;
        else if(isBlue) _scoreManager.BlueScore -= 10;
        
        
        _bubble = null;
        
        Destroy(other.gameObject);
    }
}