#pragma once

namespace SharpTpCppConverterTests
{
    []
    public ref class ConvertTests
    {
        public: void ConvertFile(Platform::String^ code);
        public: SharpToCppInterpreter GetInterpreter(Platform::String^ code);
        public: void ConvertHeaderToCsDummay(Platform::String^ code);
        public: void ConvertAppXaml();
        public: void BindableBase();
        public: void BooleanNegationConverter();
        public: void BooleanToVisibilityConverter();
        public: void GroupDetailPage();
        public: void ItemDetailPage();
        public: void RichTextColumns();
        public: void SuspensionManager();
        public: void ConvertClassDeclaration();
        public: void ConvertCppHeaderFileSuspensionManager();
        public: void ConvertCppHeaderFileGroupDetailPageGenHeader();
        public: void ConvertCppHeaderFileLayoutAwarePage();
        public: void ConvertCppHeaderFileSampleDataSource();
        public: void PropertyFounderRegex1();
        public: void PropertyFounderRegex2();
        public: void MethodFounderRegex1();
        public: void MethodFounderRegex2();
        public: void MethodFounderRegex3();
        public: void MethodParametersFounderRegex1();
        public: void MethodParametersFounderRegex2();
        public: void TypeResolverTest();
    };
}

