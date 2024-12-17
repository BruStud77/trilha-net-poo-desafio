namespace DesafioPOO.Models
{
    // DONE: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone() { }
        public Iphone(string numero, string modelo, string imei, int memoriaPrincipal, int memoriaRAM) 
        : base(numero, modelo, imei, memoriaPrincipal, memoriaRAM) 
        { 
            Numero = numero; 
            Modelo = modelo; 
            IMEI = imei;
            MemoriaPrincipal = memoriaPrincipal; 
            MemoriaRAM = memoriaRAM;   
        }

        // DONE: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            nomeApp = "WhatsApp";
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no aparelho iPhone de número: {Numero}, modelo: {Modelo} "+
            $"IMEI: {IMEI}, Memoria Principal: {MemoriaPrincipal}, Memoria RAM: {MemoriaRAM} ...");
        }
    }
}