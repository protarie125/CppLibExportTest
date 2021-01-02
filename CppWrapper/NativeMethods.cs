using System.Runtime.InteropServices;

namespace CppWrapper
{
    // 네이티브 메서드를 직접 보여주는 것은 사용자의 혼란을 유발시키므로 internal로 설정한다.
    internal static class NativeMethods
    {
        [DllImport("CppLibExportTest.dll", EntryPoint = "useStruct")]
        // 커다란 구조체를 전달할 때, 값 복사가 발생하는 것은 비효율적이므로 in으로 지정한다.
        // (in 한정자는 C# 7.2(.NET Framework 4.7.2가 아니다) 이상에서만 사용할 수 있다. 버전이 낮으면 ref를 사용해야 한다.)
        // 작은 구조체(대략 128비트보다 작은 정도)라면 굳이 참조로 전달하지 않고 내용물을 전부 복사해도 된다.
        // 네이티브 함수에서는 const pointer로 설정하여 인풋의 오염을 방지한다.
        // 네이밍 컨벤션을 C#과 일치시킨다. 이때 EntryPoint를 올바르게 지정해야 한다.
        internal static extern int CUseStruct(int normalInput, in RecordA structInput, out int normalOutput, out RecordA structOutput);
    }
}