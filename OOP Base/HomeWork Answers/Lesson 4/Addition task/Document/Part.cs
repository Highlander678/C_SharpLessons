
namespace Lessons_4
{
    abstract class Part //ключевое слово abstract указывает, что класс предназначен только 
    {                   //для использования в качестве базового класса для других классов

        protected string content; //доступ к этому полю можно получить только из кода в том же классе, либо в производном классе
        abstract public string Content { get; set; } //абстрактное свойство
        abstract public void Show(); //абстрактный метод
    }
}
