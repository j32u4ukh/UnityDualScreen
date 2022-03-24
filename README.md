# UnityDualScreen
Unity 雙螢幕所需最少程式碼 + 一個範例雙螢幕場景

只需 DualScreenSetting.cs 當中的內容，便可將遊戲設置成 雙螢幕 & 全螢幕。

相機本身需要做些設定(下一版希望將這些設定也寫進 DualScreenSetting.cs 當中)：
1. 左邊相機維持在 (0, 0, -10) 即可，右邊相機則往右移，直到兩個相機視野剛好不重疊。右移幅度會跟相機位置、視野設定等有關，需要使用者自行測試一下。
2. 不同相機要呈現的螢幕(Target Display)也要做設定，例如分別設為 Display1, Display2。

若兩個螢幕解析度不同的情況下，寬度一樣是累加，而高度目前則是取較大的那一個。取較大的好還是取較小的好，目前尚未試驗過。
