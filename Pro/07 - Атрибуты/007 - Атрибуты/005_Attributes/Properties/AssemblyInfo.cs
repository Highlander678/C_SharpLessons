using System.Reflection;
using System.Runtime.InteropServices;
using System.Configuration.Assemblies;

// Предназначен для чтения хэш-алгоритма для чтения хэш-значений из манифеста сборки.
[assembly: AssemblyAlgorithmId(AssemblyHashAlgorithm.MD5)]

// Определяет компанию-разработчика сборки. 
// С его помощью компилятор помещает название компании в заголовок исполняемого файла.
[assembly: AssemblyCompany("CyberBionic Systematics, Inc.")]

// Задает тип сборки, например DEBUG (отладочная версия) или RELEASE (окончательный выпуск).
// В Visual Studio данный тип обычно назначает пользователь, при необходимости его можно переопределить.
[assembly: AssemblyConfiguration("")]

// Задает сведения об авторских правах.
[assembly: AssemblyCopyright("Copyright © CyberBionic Systematics 2012")]

// Задает культуру сборки. Например: Немецкая культура - [assembly: AssemblyCulture("de")]
// Обычно сборкам назначается нейтральная культура.
[assembly: AssemblyCulture("")]

// Упрощает имя сборки, если имя слишком витиевато.
[assembly: AssemblyDefaultAlias("DataLayer")]

// Определяет, получит ли сборка после компиляции строгое имя (цифровую подпись).
// При работе с данным атрибутом нужно предоставить атрибут AssemblyKeyFile, определяющий временный ключ.
[assembly: AssemblyDelaySign(true)]

// Позволяет снабдить сборку комментариями.
[assembly: AssemblyDescription("This is Data Access Layer")]

// Предназначен для определения версии файла сборки. Версию сборки можно прочитать из файла версий.
// Если файл версий недоступен, используется значении версии из атрибута.
[assembly: AssemblyFileVersion("1.0.0.1")]

// Определяет значения AssemblyNameFlags для сборки:
//      EnableJITcompileOptimizer -  Активизирует оптимизацию JIT-компилятора
//      EnableJITcompileTracking  -  Активизирует мониторинг JIT-компилятора
//      None                      -  Отменяет действия флагов
//      PublicKey                 -  Генерирует новый открытый ключ сборки
//      Retargetable              -  Позволяет связать сборку с другим издателем
[assembly: AssemblyFlags(AssemblyNameFlags.EnableJITcompileOptimizer | AssemblyNameFlags.EnableJITcompileTracking)]

// Определяет версию только для ознакомительных целей. 
// Исполняющая среда не использует это значение для управления версиями сборки во время выполнения или развертывания.
[assembly: AssemblyInformationalVersion("1.0.0.1")]

// Задает путь к файлу ключа для цифровой подписи (создания строгого имени) для данной сборки.
// Например:
//[assembly: AssemblyKeyFile("../key.snk")]

// Определяет заголовок сборки в манифесте.
[assembly: AssemblyTitle("DataLayer")]

// Задает сведения о торговой марке для данной сборки.
[assembly: AssemblyTrademark("CyberBionic Systematics")]

// Задает версию сборки.
// Информация о версии для сборки содержит четыре следующих атрибута:
//      Major Version  -  Старший номер версии
//      Minor Version  -  Младший номер версии
//      Build Number   -  Номер сборки
//      Revision       -  Ревизия
// Вы можете указать значения или оставить значения по умолчанию для  Build Numbers и Revision  используя '*' как показано ниже:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]

// Определяет пользовательский атрибут имени продукта для манифеста сборки.
[assembly: AssemblyProduct("MyProgram")]

// Управляет доступностью отдельного управляемого типа или члена или всех типов в сборки для COM.
[assembly: ComVisible(false)]

// Предоставляет явный идентификатор System.Guid в случае, когда использование автоматического идентификатора GUID нежелательно.
[assembly: Guid("c01e36ba-4940-4f74-8e1b-a65e4b7c3c5c")]