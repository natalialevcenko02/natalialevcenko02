using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x68897f3a;

public class _0x6da5105f : MonoBehaviour
{
    private void Start()
    {
        if (this._0x3d1ed677 != _0x35276d64.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0x35276d64.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x0a396108._0x61bf0f96 = false;
            _0xad9ed8e9.Instance._0xad2ed0f3();
            _0xb01be533.Instance._0x00a24a4a(_0x215fc08c.TUTORIAL0);
        });
    }

    public Transform EnvironmentWithTweensToToggle;
    public Button ShowResetTutorialButton;
    [HideInInspector]
    public List<_0xe1ded7fc> MoneyCountContainers = new();
    public Transform Environment;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x6da5105f>();
        this.RootGameObject = GameObject.FindWithTag(_0xb34d945b._0xaad78a0d(new byte[4] { 175, 146, 146, 137 }, 253));
        if (this._0x3d1ed677 == _0x35276d64.SCENE_0)
            this._0x1d3787ef(true);
        else
            this._0x1d3787ef(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0xe1ded7fc>(true).ToList();
    }

    public void _0x6424c01d()
    {
        foreach (_0xe1ded7fc _0xd11994df in this.MoneyCountContainers)
            _0xd11994df._0x574764d2();
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private static _0xccbb8e40 GAME_INDEX_SETTINGS(int _0x25366397)
    {
        return _0xccbb8e40.ALL_SCENES_SETTING_SINGLETONS[_0x25366397];
    }

    public Button DeleteProgressDataButton;
    private void _0x7164c0db()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0x35276d64.SCENE_0);
    }

    private IEnumerator _0xda175df5(string _0xba7cf08b)
    {
        _0xb01be533.Instance._0x00a24a4a(_0x215fc08c.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x9c132ce6 = SceneManager.LoadSceneAsync(_0xba7cf08b);
        while (!_0x9c132ce6.isDone)
            yield return null;
    }

    public static _0x6da5105f Instance;
    public int _0x3d1ed677 => SceneManager.GetActiveScene().buildIndex;

    private IEnumerator _0xdbb9e750(int _0x5f1e6494)
    {
        _0xb01be533.Instance._0x00a24a4a(_0x215fc08c.SPLASH);
        AsyncOperation _0xe06e67eb = SceneManager.LoadSceneAsync(_0x5f1e6494);
        while (!_0xe06e67eb.isDone)
            yield return null;
    }

    public void LoadSceneByIndex(int _0x93b8d4a2)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xdbb9e750(_0x93b8d4a2));
    }

    private static void MakeGrid(List<RectTransform> _0xc6fc0aa0, AspectRatioFitter _0x8ab5abdf, float _0xbf1bbf17, int _0x818f0ece, int _0xe01fac55)
    {
        _0x8ab5abdf.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x8ab5abdf.aspectRatio = _0xbf1bbf17;
        foreach (RectTransform _0x4b6cd6ee in _0xc6fc0aa0)
        {
            int _0xeb83ccd7 = _0x4b6cd6ee.transform.GetSiblingIndex();
            _0x4b6cd6ee.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xeb83ccd7 % _0x818f0ece) * (1f / _0x818f0ece), (_0xe01fac55 - (Mathf.FloorToInt((float)_0xeb83ccd7 / _0x818f0ece) % _0xe01fac55 + 1f)) * (1f / _0xe01fac55));
            _0x4b6cd6ee.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xeb83ccd7 % _0x818f0ece + 1f) * (1f / _0x818f0ece), (_0xe01fac55 - Mathf.FloorToInt((float)_0xeb83ccd7 / _0x818f0ece) % _0xe01fac55) * (1f / _0xe01fac55));
            _0x4b6cd6ee.offsetMin = Vector2.zero;
            _0x4b6cd6ee.offsetMax = Vector2.zero;
        }
    }

    public bool _0x8f648b25 { get; private set; }

    public void _0xa5b781ae()
    {
        _0x0a396108._0x61bf0f96 = true;
    }

    private static _0xccbb8e40 _0x66eb723a => _0xccbb8e40.ALL_SCENES_SETTING_SINGLETONS[0];

    private void _0xf9d4f157(Transform _0xda84c6e4)
    {
        Transform[] _0xb8334729 = _0xda84c6e4.GetComponentsInChildren<Transform>();
        foreach (Transform _0xb578e5ae in _0xb8334729)
            if (_0xb578e5ae != null && DOTween.IsTweening(_0xb578e5ae))
            {
                if (this._0x8f648b25)
                    DOTween.Play(_0xb578e5ae);
                else
                    DOTween.Pause(_0xb578e5ae);
            }
    }

    public void _0x1d3787ef(bool _0x83c9d6d5)
    {
        this._0x8f648b25 = _0x83c9d6d5;
        this._0x1f29ef8a(!this._0x8f648b25);
        Physics2D.simulationMode = this._0x8f648b25 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xf9d4f157(this.EnvironmentWithTweensToToggle);
    }

    public static bool IsAfterLevelComplete;
    private void _0x1f29ef8a(bool _0x253782ec)
    {
        Rigidbody2D[] _0xf180e4b2 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x1f334632 in _0xf180e4b2)
            if (_0x253782ec)
                _0x1f334632.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x1f334632.constraints = RigidbodyConstraints2D.None;
    }

    public static bool IsAfterLevelFailed = false;
    public void _0xa5e6ed15()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    public Canvas MainCanvas;
    public static _0xccbb8e40 _0x0a396108 => _0xccbb8e40.ALL_SCENES_SETTING_SINGLETONS[Instance._0x3d1ed677];
}

internal static class _0xb34d945b
{
    internal static string _0xaad78a0d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}