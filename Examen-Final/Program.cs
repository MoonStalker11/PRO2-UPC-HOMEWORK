namespace ProgramacionDos{
    public class Program{
        public static void Main(string[] args)
        {
            

            
            //Genra una serie iterativa
            Console.WriteLine("Examen Final");

            int cant = 10;
            ClaseArrayCadenas AC1 = new ClaseArrayCadenas(cant);

            // Llamada al método GenerarSerieExamenIterativo
            AC1.GenerarSerieExamenIterativo(true, 5, 10, cant);
        
            // Mostrar el array después de generar la serie
            AC1.MostrarArray();

            /*
            //Crea el fichero donde estara la serie
            string path = "E:/USis/ProgramII/PRO2-UPC/ronald/ficheros/for/ficheroArray.txt";
            FicheroRonald fd = new FicheroRonald(path);
            fd.EscribirArray(resultadoSerie);
            //Console.WriteLine();
            */

        }
    }
}