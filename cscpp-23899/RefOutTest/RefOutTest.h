#pragma once

namespace RefOutTest
{
    class RefOutTestExe
    {
        public: RefOutTestExe();
        private: void RefAdd(int& a, int& b);
        private: void OutAdd(int a, int b, int& z);
        public: int RefOutTestExecute();
    };
}

