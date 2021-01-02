namespace CppWrapper
{
    public struct RecordA
    {
        // 프로퍼티를 사용하지 않고 직접 필드를 사용한다.
        public int intValue;

        public float floatValue;
        public double doubleValue;

        public RecordA(int iv, float fv, double dv)
        {
            intValue = iv;
            floatValue = fv;
            doubleValue = dv;
        }

        // 다른 메서드는 C/C++에서는 사용할 수 없기 때문에, 가능하면 만들지 않는다.
    }
}