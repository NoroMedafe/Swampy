using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
public class LocalizationLanguage : MonoBehaviour
{
    
    public void LoadRussian()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[2];

    }
    public void LoadEnglish()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];

    }
    public void LoadJapanise()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];

    }
    public void LoadTurkish()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[3];

    }
}
