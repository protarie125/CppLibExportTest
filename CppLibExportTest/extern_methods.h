#pragma once
#include "framework.h"
// C ��Ÿ�Ϸ� �ۼ��Ѵ�.
#include "records.h"

#define ERROR_CODE int
#define OK 0
#define FAIL -1

EXTERN_C_START

// ����Ƽ�� �Լ������� const pointer�� �����Ͽ� ��ǲ�� ������ �����Ѵ�.
ERROR_CODE CPPLIBEXPORTTEST_API useStruct(int normalInput, const RecordA* structInput, int* normalOutput, RecordA* structOutput);

EXTERN_C_END
