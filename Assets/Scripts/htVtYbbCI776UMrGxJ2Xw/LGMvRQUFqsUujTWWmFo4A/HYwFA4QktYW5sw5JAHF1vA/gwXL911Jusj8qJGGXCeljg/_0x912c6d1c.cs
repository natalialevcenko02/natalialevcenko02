using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x912c6d1c : MonoBehaviour
{
    public float SecondPassSliderValue = 0.5f;
    public static _0x912c6d1c Instance;
    public void _0x60de26c6()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x28a30398?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xffafd4c6 = false;
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x68897f3a._0x35276d64.SCENE_0 && !_0xffafd4c6)
        {
            this._0x25dfcc96();
        }
        else
        {
            this._0x5c408f5b();
        }
    }

    public GameObject Content;
    public GameObject Background;
    public void _0x0fd3d3de()
    {
        this._0x28a30398?.Kill();
        this.AnimationSlider.value = _0xffafd4c6 ? this.SecondPassSliderValue : 0.05f;
    }

    public void _0x5c408f5b()
    {
        this._0x0fd3d3de();
        bool _0x8364a363 = _0xffafd4c6;
        this._0x28a30398 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xd91cd937 => this.AnimationSlider.value = _0xd91cd937, _0x8364a363 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xffafd4c6 = !_0xffafd4c6;
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x912c6d1c>();
    }

    public float DefaultAnimationTime = 0.4f;
    private Sequence _0x28a30398;
    public void _0xd6497274()
    {
        this._0x28a30398?.Play();
    }

    public float FirstAnimationTime = 10.0f;
    private static bool _0xffafd4c6 = false;
    private void _0x25dfcc96()
    {
        this.AnimationSlider.value = 0.05f;
        _0xffafd4c6 = !_0xffafd4c6;
        this._0x28a30398 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xd91cd937 => this.AnimationSlider.value = _0xd91cd937, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xcc9b37a5._0xbea121df?._0xf25eb715();
        });
    }

    public Slider AnimationSlider;
    public GameObject Error;
    public void _0x70a5bbcc()
    {
        this._0x28a30398?.Pause();
    }
}