namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Livro livro1 = new Livro("Flores para Algernon", "Daniel Keyes", 1966, 288);
            biblioteca.AdicionarItem(livro1);

            Livro livro2 = new Livro("Talvez você deva conversar com alguém", "Lori Gottlieb", 2022, 448);
            biblioteca.AdicionarItem(livro2);

            Revista revista1 = new Revista("Veja ed. 2854", "Veja", 2023, 85);
            biblioteca.AdicionarItem(revista1);

            Revista revista2 = new Revista("Saúde ed. 445", "Veja", 2019, 90);
            biblioteca.AdicionarItem(revista2);

            MidiaDigital midiaDigital1 = new MidiaDigital("E-book: Um estranho sonhador", "Laini Taylor", 2019, 544);
            biblioteca.AdicionarItem(midiaDigital1);

            MidiaDigital midiaDigital2 = new MidiaDigital("E-book: Daisy Jones & The Six", "Taylor Jenkins Reid", 2019, 360);
            biblioteca.AdicionarItem(midiaDigital2);

            biblioteca.EmprestarItem(livro1);
            biblioteca.DevolverItem(livro1);
          
            biblioteca.DevolverItem(livro2);

            biblioteca.EmprestarItem(revista2);

            biblioteca.DevolverItem(midiaDigital2);
        }
    }
}


