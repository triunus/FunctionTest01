1. Create ScriptableObject

# 참고자료
 - https://www.youtube.com/watch?v=_IqTeruf3-s&list=PLJWSdH2kAe_Ij7d7ZFR2NIW8QCJE74CyT
 - https://docs.unity3d.com/2019.4/Documentation/ScriptReference/ScriptableObject.html



2. Convert Json to Object
 - 2019.4.0f1 버전에서 'Nuget 패키지 관리'를 사용하여 Newtonsoft.Json을 사용하면 Unity가 패키지를 인식하지 못하는 버그가 존재합니다.

 - 따라서, 'Nuget 패키지 관리'가 아닌 다음과 같은 방법으로 Newtonsoft.Json 기능을 사용하도록 하였습니다.
 - "Assets/link.xml"과 "Assets/Plugins/Newtonsoft.Json.dll"을 두어, Unity가 Newtonsoft.Json.dll을 인식하도록 하였습니다.

# 참고자료
 - https://learn.microsoft.com/ko-kr/visualstudio/gamedev/unity/unity-scripting-upgrade
   -> '.NET 호환성 활용' - 'NuGet에서 Unity 프로젝트에 패키지 추가' 부분.



3. Convert Object to ScriptableObject
 - 



4.

