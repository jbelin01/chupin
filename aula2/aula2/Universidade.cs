// ./Universidade.cs
public class Universidade {
    public string Nome {get; set;}

    public string Localizacao {get; set;}

    public int AnoFundacao {get; set;}
// esta propriedade requer refatoração. 
    public  List<Curso> Cursos = new List<Curso>();

    public string ExibirInformacoes (){
        return "";
    }

    public void AdiconarCurso(Curso Curso){
        this.Cursos.Add(Curso);
    }

    //Método que retorna a lista Cursos

     public  List<Curso> GetCursos(){
        return this.Cursos;
     }

}