namespace Task_3
{
    class Book
    {
        //Создание объектов класса
        readonly Title title;
        readonly Author author;
        readonly Content content;

        //Пользовательский конструктор
        public Book(string title, string author, string content)
        {
            //Инициализация свойств для каждого объекта
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }

        public void Show()
        {
            //Отображение значений которые хранятся в классах Title, Author, Content. 
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
