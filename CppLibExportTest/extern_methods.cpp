#include "extern_methods.h"

#include <iostream>
#include <exception>

using std::cout;
using std::endl;
using std::exception;

ERROR_CODE useStruct(int normalInput, const RecordA* structInput, int* normalOutput, RecordA* structOutput)
{
    // out �Ķ���ͷ� �����Ǿ� �ֱ⶧���� nullptr�� ���� ������, �ϴ� üũ�Ѵ�.
    // �����δ� �ܼ��� FAIL�� �ƴ� ��ü���� �����ڵ带 ��ȯ�Ѵ�.
    if (normalOutput == NULL) return FAIL;
    if (structOutput == NULL) return FAIL;

    try
    {
        // ���ο��� ������ ��ü�� �����Ű�� ���� �ƹ� ȿ���� ������,
        // �Ǽ��� �����ϱ� ���ؼ� ��� �����ͷ� ������ �� �ִ�.
        // (int* const normalOutput, RecordA* const structOutput ���)
        *normalOutput = normalInput + 100;
        structOutput->intValue = structInput->intValue * 2;
        structOutput->floatValue = structInput->floatValue * 3;
        structOutput->doubleValue = structInput->doubleValue * 4;

        return OK;
    }
    catch (const exception& exc)
    {
        // std::exception�� C �Լ��� ������ ����� �����Ƿ� �����ڵ带 �̿��Ѵ�.
        // �����δ� �ܼ��� �ƴ� logger ��⿡ �α��Ѵ�.
        cout << exc.what() << endl;
        // �����δ� �Ϲ� exception�� �ƴ� ��ü���� ���ܸ� ĳġ�ϰ� �ùٸ� �����ڵ带 ��ȯ�Ѵ�.
        return FAIL;
    }
}