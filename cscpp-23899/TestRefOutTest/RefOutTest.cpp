#include "pch.h"
#include "RefOutTest.h"

using namespace System;
using namespace System::Collections::Generic;
using namespace System::Linq;
using namespace System::Text;
using namespace System::Threading::Tasks;
using namespace RefOutTest;

RefOutTest::RefOutTest()
{
}

void RefOutTest::RefAdd(int& a, int& b)
{
    a = a + 2;
    b = b + 3;
}

void RefOutTest::OutAdd(int a, int b, int& z)
{
    z = a + b + 3;
}

int RefOutTest::RefOutTestExecute()
{
    int x = 0;
    int y = 0;
    RefAdd( x,  y);
    int z = 0;
    OutAdd(x, y,  z);
    
    if (z == 8)
    {
        return 0;
    }
    else
    {
        return -1;
    }
}


