# 馃З EasyGTA-Plugins

EasyGTA 鍔熻兘鍟嗗簵 鈥?鎻掍欢甯傚満銆?
鐢ㄦ埛閫氳繃 EasyGTA 瀹㈡埛绔唴鐨勩€岎煣?鍔熻兘鍟嗗簵銆嶆祻瑙堛€佸畨瑁呫€佺鐞嗚繖浜涙彃浠躲€?
---

## 濡備綍鎻愪氦鎻掍欢

### 鍓嶇疆鏉′欢

- 浣犵殑鎻掍欢鏄竴涓?.NET Framework 4.8 绫诲簱锛圖LL锛?- 寮曠敤 EasyGTA.Core锛堟帴鍙ｅ畾涔夊湪 SDK 涓級
- 瀹炵幇 `IModule` 鎺ュ彛骞剁敤 `[Module]` 灞炴€ф爣璁?
### 姝ラ

1. **涓嬭浇 SDK**锛氫粠 [EasyGTA-Releases](https://github.com/QuoVadis86/EasyGTA-Releases/releases) 涓嬭浇 `EasyGTA-SDK.zip`
2. **鍒涘缓椤圭洰**锛氬熀浜?`PluginTemplate.csproj` 鍒涘缓浣犵殑鎻掍欢椤圭洰
3. **缂栧啓鎻掍欢**锛氬疄鐜?`IModule` 鎺ュ彛

```csharp
using EasyGTA.Core.ModuleSystem;

[Module("my_plugin", "鎴戠殑鎻掍欢",
    Emoji = "馃攲",
    Category = "tools",
    Description = "鎴戠殑绗竴涓彃浠?,
    Tier = FeatureTier.Extra)]
public class MyPlugin : IModule
{
    public void Initialize(IModuleContext ctx)
    {
        ctx.LogInfo("鎻掍欢宸插姞杞斤紒");
    }
    public void Cleanup() { }
}
```

4. **缂栬瘧**锛歚dotnet build -c Release`
5. **鎻愪氦 PR**锛?   - 灏嗙紪璇戝ソ鐨?`.dll` 鏀惧叆 `plugins/{浣犵殑鎻掍欢ID}/` 鐩綍
   - 鏇存柊 `manifest.json` 娣诲姞浣犵殑鎻掍欢鏉＄洰
   - 鎻愪氦 Pull Request

### 瀹℃牳鏍囧噯

- 鉁?浠ｇ爜瀹夊叏锛堜笉璇诲彇鐢ㄦ埛鏁忔劅淇℃伅銆佷笉鑱旂綉涓婁紶鏁版嵁锛?- 鉁?鍔熻兘瀹屾暣锛圛nitialize/Cleanup 姝ｇ‘瀹炵幇锛?- 鉁?manifest 淇℃伅瀹屾暣锛堝悕绉般€佹弿杩扮殑澶氳瑷€缈昏瘧锛?- 鉂?鏃犳伓鎰忎唬鐮侊紙娉ㄥ叆銆丷ootkit銆佹寲鐭跨瓑锛?
---

## manifest.json 鏍煎紡

```json
{
  "plugins": [
    {
      "id": "unique_plugin_id",
      "name": "鏄剧ず鍚?,
      "name_i18n": {
        "zh-CN": "涓枃鍚?,
        "en": "English Name",
        "ja": "鏃ユ湰瑾炲悕",
        "ko": "頃滉淡鞏?鞚措"
      },
      "version": "1.0.0",
      "author": "浣犵殑鍚嶅瓧",
      "description": "鍔熻兘璇存槑",
      "desc_i18n": {
        "zh-CN": "涓枃璇存槑",
        "en": "English description"
      },
      "category": "combat|network|session|vehicle|ui|heist|social|tools",
      "size_kb": 42,
      "emoji": "馃殌",
      "download_url": "https://github.com/QuoVadis86/EasyGTA-Plugins/releases/download/v1.0.0/your_plugin.dll"
    }
  ]
}
```

### 鍒嗙被锛坈ategory锛?
| 鍊?| 鏄剧ず鍚?| 璇存槑 |
|----|--------|------|
| `combat` | 鎴樻枟杈呭姪 | 鍋烽€熴€佽嚜鍔ㄧ瀯鍑嗐€佸揩閫熸崲寮?|
| `network` | 缃戠粶宸ュ叿 | 缃戠粶闄愬埗銆佺綉缁滈攣 |
| `session` | 鎴樺眬宸ュ叿 | 鎴樺眬閿併€佹寕鏈洪槻韪?|
| `vehicle` | 杞藉叿 | 涓€閿偣鐏€佽浇鍏烽攣瀹?|
| `ui` | 鐣岄潰瑕嗙洊 | 璁℃椂鍣ㄣ€佸噯鏄?|
| `heist` | 鎶㈠姭杈呭姪 | 鎸囩汗鐮磋В銆丆ayo Perico |
| `social` | 绀句氦 | 濂藉弸绠＄悊銆佹秷鎭?|
| `tools` | 宸ュ叿 | 閫氱敤宸ュ叿绫?|

---

## 鎻掍欢鍙戝竷娴佺▼

鎻愪氦 PR 鍚庯細

1. GitHub Actions 鑷姩缂栬瘧楠岃瘉
2. 缁存姢鑰呭鏍镐唬鐮?3. 鍚堝苟鍚庤嚜鍔ㄦ瀯寤?Release
4. 鐢ㄦ埛鎵撳紑 EasyGTA 鈫?馃З 鍟嗗簵 鈫?鐪嬪埌鏂版彃浠?
---

## 鐩稿叧浠撳簱

- [EasyGTA-CS](https://github.com/QuoVadis86/EasyGTA-CS) 鈥?EasyGTA 涓荤▼搴忔簮鐮?- [EasyGTA-Releases](https://github.com/QuoVadis86/EasyGTA-Releases) 鈥?鍙戝竷鐗堟湰涓嬭浇
