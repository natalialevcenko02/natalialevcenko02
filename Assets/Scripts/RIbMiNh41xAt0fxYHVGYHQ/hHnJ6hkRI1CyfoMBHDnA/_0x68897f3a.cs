using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x68897f3a
{
    public static class _0xe9080e3c
    {
        public static int _0x12295ddc
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x766c0ede._0x529b5936(new byte[5] { 36, 8, 14, 9, 20 }, 103)))
                    PlayerPrefs.SetInt(_0x766c0ede._0x529b5936(new byte[5] { 203, 231, 225, 230, 251 }, 136), 0);
                return PlayerPrefs.GetInt(_0x766c0ede._0x529b5936(new byte[5] { 10, 38, 32, 39, 58 }, 73));
            }

            set
            {
                PlayerPrefs.SetInt(_0x766c0ede._0x529b5936(new byte[5] { 137, 165, 163, 164, 185 }, 202), value);
                _0x6da5105f.Instance._0x6424c01d();
            }
        }
    }

    public class _0xccbb8e40
    {
        private static readonly _0xccbb8e40 _0x6840751c = new();
        public static readonly _0xccbb8e40[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x6840751c,
            _0x6840751c,
            _0x6840751c,
        };
        private int _0x7e01398d => 0;
        private int _0x8ca575ed => 10;
        private string _0x55cb9108 => _0x766c0ede._0x529b5936(new byte[4] { 53, 29, 22, 13 }, 120);
        private string _0x0d32fc25 => _0x766c0ede._0x529b5936(new byte[8] { 28, 21, 6, 21, 28, 43, 96, 45 }, 80);

        private int _0xd3001766
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x766c0ede._0x529b5936(new byte[25] { 62, 8, 15, 15, 24, 19, 9, 58, 17, 18, 31, 28, 17, 62, 21, 28, 13, 9, 24, 15, 52, 19, 25, 24, 5 }, 125)))
                    PlayerPrefs.SetInt(_0x766c0ede._0x529b5936(new byte[25] { 12, 58, 61, 61, 42, 33, 59, 8, 35, 32, 45, 46, 35, 12, 39, 46, 63, 59, 42, 61, 6, 33, 43, 42, 55 }, 79), 0);
                return PlayerPrefs.GetInt(_0x766c0ede._0x529b5936(new byte[25] { 240, 198, 193, 193, 214, 221, 199, 244, 223, 220, 209, 210, 223, 240, 219, 210, 195, 199, 214, 193, 250, 221, 215, 214, 203 }, 179));
            }

            set => PlayerPrefs.SetInt(_0x766c0ede._0x529b5936(new byte[25] { 5, 51, 52, 52, 35, 40, 50, 1, 42, 41, 36, 39, 42, 5, 46, 39, 54, 50, 35, 52, 15, 40, 34, 35, 62 }, 70), value);
        }

        public int _0xdd3ff426
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x55cb9108}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x55cb9108}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x55cb9108}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x55cb9108}CurrentLevelIndex", value);
        }

        public int _0xdedacee0
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x55cb9108}BestScore"))
                    this._0xdedacee0 = 0;
                return PlayerPrefs.GetInt($"{this._0x55cb9108}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x55cb9108}BestScore", value);
        }

        public bool _0x61bf0f96
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x55cb9108}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x55cb9108}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x55cb9108}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x55cb9108}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x215fc08c
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0x890b9fee
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x35276d64
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }
}

internal static class _0x766c0ede
{
    internal static string _0x529b5936(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}