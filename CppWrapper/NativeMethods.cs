using System.Runtime.InteropServices;

namespace CppWrapper
{
    // 네이티브 메서드를 직접 보여주는 것은 사용자의 혼란을 유발시키므로 internal로 설정한다.
    internal static class NativeMethods
    {
        [DllImport("CppLibExportTest.dll", EntryPoint = "useStruct")]
        // C# 네이밍 컨벤션을 사용한다. 이때 EntryPoint를 올바르게 지정해야 한다.
        internal static extern int CUseStruct(int normalInput, RecordA structInput, out int normalOutput, out RecordA structOutput);
    }
}