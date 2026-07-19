using EasyGTA.Core.ModuleSystem;

namespace EasyGTA.Plugins;

/// <summary>
/// 鍋烽€熸彃浠?鈥?鎸変綇鎸佺画鍒囨崲姝﹀櫒銆?///
/// 鍔熻兘璇存槑锛?///   鎸変綇鎵€缁戝畾鐑敭鏃讹紝浠ュ浐瀹氶棿闅旇嚜鍔ㄦ寜涓嬫鍣ㄥ垏鎹㈤敭锛圱ab锛夈€?///   鏉惧紑鐑敭绔嬪嵆鍋滄銆傛敮鎸侀敭鐩樺拰鎵嬫焺涓ょ妯″紡銆?///
/// 瀹夎鍚庯細
///   1. 鍦ㄦ悳绱㈡爮鎵惧埌銆屽伔閫熴€?///   2. 鍕鹃€夊惎鐢?///   3. 缁戝畾鐑敭锛堝 Ctrl+F8锛?///   4. 鎸変綇鐑敭鍗冲彲鍒囨崲姝﹀櫒
/// </summary>
[Module("turbo", "鍋烽€?,
    Emoji = "馃殌",
    Category = "combat",
    Tier = FeatureTier.Extra,
    Description = "鎸変綇鎸佺画鍒囨崲姝﹀櫒锛堟墜鏌?閿洏锛夛紝鏉惧紑鍋滄",
    SortOrder = 10)]
public class TurboPlugin : IModule
{
    private IModuleContext? _ctx;
    private CancellationTokenSource? _cts;

    public void Initialize(IModuleContext context)
    {
        _ctx = context;
        _ctx.LogInfo("鍋烽€熸彃浠跺凡鍒濆鍖?);
    }

    public void Cleanup()
    {
        StopLoop();
    }

    /// <summary>鎸変笅鐑敭鏃惰皟鐢紙鐢辨鏋剁殑鎸変綇鍨嬬儹閿Е鍙戯級</summary>
    public void OnPress()
    {
        if (_cts != null) return; // 宸茬粡鍦ㄨ繍琛?
        _cts = new CancellationTokenSource();
        var token = _cts.Token;

        ThreadPool.QueueUserWorkItem(_ =>
        {
            try
            {
                // 浠庨厤缃鍙栨寜閿棿闅旓紙榛樿 80ms锛?                int interval = _ctx?.Config.Get<int>("interval_ms", 80) ?? 80;

                while (!token.IsCancellationRequested)
                {
                    // 妯℃嫙鎸変笅姝﹀櫒鍒囨崲閿?                    InputSimulator.TapKey("tab", 0.05);
                    token.WaitHandle.WaitOne(interval);
                }
            }
            catch (OperationCanceledException) { }
            catch (Exception ex)
            {
                _ctx?.LogError($"鍋烽€熷紓甯? {ex.Message}");
            }
        });
    }

    /// <summary>鏉惧紑鐑敭鏃惰皟鐢紙鐢辨鏋剁殑鎸変綇鍨嬬儹閿Е鍙戯級</summary>
    public void OnRelease()
    {
        StopLoop();
    }

    private void StopLoop()
    {
        _cts?.Cancel();
        _cts?.Dispose();
        _cts = null;
    }
}
