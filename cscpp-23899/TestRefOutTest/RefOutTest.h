#pragma once

namespace RefOutTest
{
    ref class RefOutTest
    {
        public: RefOutTest();
        private: void RefAdd(int& a, int& b);
        private: void OutAdd(int a, int b, int& z);
        public: int RefOutTestExecute();
    };
}

