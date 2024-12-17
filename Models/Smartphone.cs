using System.Data;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone()
        {
          
        }

        public Smartphone(string numero, string modelo, string imei, int memoriaPrincipal, int memoriaRAM)
        {
            // DONE: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            MemoriaPrincipal = memoriaPrincipal;
            MemoriaRAM = memoriaRAM;
            
        }
        public string Numero { get; set; }
        // DONE: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int MemoriaPrincipal { get; set; }
        protected int MemoriaRAM { get; set; }


        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}