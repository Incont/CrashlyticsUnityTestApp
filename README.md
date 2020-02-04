# CrashlyticsUnityTestApp

Steps
1. Prepare project:
 - add test crashlytics app from https://github.com/firebase/quickstart-unity/tree/master/crashlytics/testapp
 - added firebase crashlytics 6.10 (without Assets\Firebase\Plugins\x86_64\*, because files size are too big)
 - added google-services.json, and run play service resolver
 - added NetworkSecurityConfig for debuging android requests via proxy (see charles documentation https://www.charlesproxy.com/documentation/using-charles/ssl-certificates/)
 - add game object to main scene with script where crashlytics will be disabled on awake (Crashlytics.IsCrashlyticsCollectionEnabled = false https://firebase.google.com/docs/crashlytics/customize-crash-reports?platform=unity#enable_opt-in_reporting)
 
2. Install Charles and setup android device https://community.tealiumiq.com/t5/Tealium-for-Android/Setting-up-Charles-to-Proxy-your-Android-Device/ta-p/5121
 
 3. Build apk and install on android device
 4. Watch events in Charles
 
 Result: 
 https://github.com/Incont/CrashlyticsUnityTestApp/blob/master/requests_1.jpg
 https://github.com/Incont/CrashlyticsUnityTestApp/blob/master/requests_2.jpg
