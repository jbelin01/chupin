// classe cliente
// Autor: João Gabriel
// Finalidade: implementa os dados do cliente

public class cliente{
        public string nome{set;get;}

        public string cpf{set;get;}

        public int idade{set;get;}

        public void salvar(){
            if (idade >= 18)
            {
                 Console.WriteLine("salvando...");
            }
           else
           {
                 Console.WriteLine("vá dormir praga!");
           }
            
        }

}

