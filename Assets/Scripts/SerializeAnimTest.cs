using UnityEngine;

public class SerializeAnimTest : MonoBehaviour
{
    Animator mAnimator;
    private void Awake()
    {
        mAnimator = GetComponent<Animator>();
    }
    void OnGUI()
    {
        if(GUI.Button(new Rect(10,10, 150, 30), "in"))
        {
            mAnimator.SetTrigger("in");
        }
        if (GUI.Button(new Rect(10, 40, 150, 30), "out"))
        {
            mAnimator.SetTrigger("out");
        }
    }
}
