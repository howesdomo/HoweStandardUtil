﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN
{
    public interface IAudioPlayer
    {
        /// <summary>
        /// 默认音效 扫描成功
        /// </summary>
        void PlayBeep();

        /// <summary>
        /// 默认音效 异常
        /// </summary>
        void PlayError();

        /// <summary>
        /// 默认音效 警告
        /// </summary>
        void PlayWarn();

        /// <summary>
        /// 默认音效 拍照声
        /// </summary>
        void PlayTakePhoto();

        /// <summary>
        /// 默认音效 截图声
        /// </summary>
        void PlayScreenshot();



        /// <summary>
        /// 播放背景音乐 (BGM)
        /// </summary>
        void PlayBackgroundMusic(string fileName);

        /// <summary>
        /// 停止播放背景音乐 (BGM)
        /// </summary>
        void StopBackgroundMusic();

        /// <summary>
        /// 播放音效 (SoundEffect)
        /// </summary>
        void PlaySoundEffect(string fileName);


        bool GetIsBackgroundMusicOn();
        float GetBackgroundMusicVolume();
        bool GetIsEffectsOn();
        float GetEffectsVolume();


        bool SetIsBackgroundMusicOn(bool a);
        float SetBackgroundMusicVolume(float a);
        bool SetIsEffectsOn(bool a);
        float SetEffectsVolume(float a);



        /// <summary>
        /// 安卓的 播放 Assets 文件夹内的文件
        /// </summary>
        void PlayAssetsFile(string fileName);
    }
}
