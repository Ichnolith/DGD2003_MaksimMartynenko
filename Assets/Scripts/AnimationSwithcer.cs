using UnityEngine;

public class AnimationSwithcer : MonoBehaviour
{
    private Animator animator;

    public string[] animations;
    public float changeTime = 10f;

    private float timer;
    private int lastAnimation = -1;

    void Start()
    {
        animator = GetComponent<Animator>();
        PlayRandomAnimation();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeTime)
        {
            PlayRandomAnimation();
            timer = 0f;
        }
    }

    void PlayRandomAnimation()
    {
        int randomIndex;

        do
        {
            randomIndex = Random.Range(0, animations.Length);
        }
        while (randomIndex == lastAnimation);

        animator.Play(animations[randomIndex]);
        lastAnimation = randomIndex;
    }
}