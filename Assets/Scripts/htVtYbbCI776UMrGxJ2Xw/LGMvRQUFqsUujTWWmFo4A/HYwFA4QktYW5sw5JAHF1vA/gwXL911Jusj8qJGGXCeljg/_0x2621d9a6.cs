using UnityEngine;
using UnityEngine.UI;

public class _0x2621d9a6 : MonoBehaviour
{
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xb01be533.Instance._0x00a24a4a(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x6da5105f.Instance._0xa5b781ae());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xb01be533.Instance._0x00a24a4a(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0xb01be533.Instance._0x00a24a4a(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x6da5105f.Instance._0xa5b781ae());
        }
    }

    public bool IsTutorialEndPanel;
    public Button NextTutorialButton;
    public Button TutorialEndButton;
    public int EndTutorialPanelIndex = 1;
    public int NextTutorialPanelIndex;
}