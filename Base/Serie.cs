using System;
namespace dio_dotnet_poo
{
    public class Serie : BaseEntity
    {
        // Atributos
		private Genre genre { get; set; }
		private string title { get; set; }
		private string description { get; set; }
		private int year { get; set; }
        private bool erased {get; set;}

        // Métodos
		public Serie(int id, Genre genre, string title, string description, int year)
		{
			this.Id = id;
			this.genre = genre;
			this.title = title;
			this.description = description;
			this.year = year;
            this.erased = false;
		}

        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.genre + Environment.NewLine;
            retorno += "Titulo: " + this.title + Environment.NewLine;
            retorno += "Descrição: " + this.description + Environment.NewLine;
            retorno += "ano de Início: " + this.year + Environment.NewLine;
            retorno += "Excluido: " + this.erased;
			return retorno;
		}

        public string getTitle()
		{
			return this.title;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool returnErased()
		{
			return this.erased;
		}
        public void Excluir() {
            this.erased = true;
        }
    }
}