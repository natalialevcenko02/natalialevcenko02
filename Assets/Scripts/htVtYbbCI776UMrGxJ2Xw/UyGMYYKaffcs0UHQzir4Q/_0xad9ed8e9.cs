using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x68897f3a;

public class _0xad9ed8e9 : MonoBehaviour
{
    public List<_0x04fe9665> Pops;
    public float ScaleDuration = 0.4f;
    public void _0xad2ed0f3()
    {
        this.LastPopIndexes.Clear();
        this._0x82d7983b();
        foreach (GameObject _0x0c7da953 in this.GameObjectsToHide)
            if (_0x0c7da953 != null)
                _0x0c7da953.SetActive(true);
        this._0x673597e9();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xad9ed8e9>();
    }

    public _0x04fe9665 _0xd483b1a8(int _0x8db0ff4e)
    {
        return this.Pops[_0x8db0ff4e];
    }

    public int CurrentPopIndex;
    private void _0x82d7983b(bool _0x873f9031 = false)
    {
        for (int _0xd881abe3 = 0; _0xd881abe3 < this.Pops.Count; ++_0xd881abe3)
            if (this.Pops[_0xd881abe3] != null && !(_0xd881abe3 == this.CurrentPopIndex && _0x873f9031))
                this.Pops[_0xd881abe3]._0xb6f850fa();
    }

    public List<GameObject> GameObjectsToHide;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public static _0xad9ed8e9 Instance;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x04fe9665 _0xd8b97b85 in this.Pops)
            if (_0xd8b97b85 != null)
                _0xd8b97b85.gameObject.SetActive(true);
    }

    private void _0xe5636678()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public GameObject BlurBackground;
    public void _0x2f9bbe27()
    {
        this.LastPopIndexes.RemoveAll(_0xfacea7c4 => _0xfacea7c4 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xad2ed0f3();
        else
            this._0x8f7cb98f(this.LastPopIndexes.Last());
    }

    private void _0x673597e9()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public void _0x8f7cb98f(int _0xe2bd7b5c)
    {
        this.CurrentPopIndex = _0xe2bd7b5c;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x82d7983b(true);
        this._0xe5636678();
        this.Pops[_0xe2bd7b5c].Show();
        foreach (GameObject _0x41d16a39 in this.GameObjectsToHide)
            _0x41d16a39.SetActive(false);
    }

    public List<int> LastPopIndexes = new();
}