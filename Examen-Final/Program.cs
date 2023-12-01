namespace ProgramacionDos{
    public class Program{
        public static void Main(string[] args)
        {
            /*
            //Genra una serie iterativa
            Console.WriteLine("Examen Final");

            int cant = 10;
            ClaseArrayCadenas AC1 = new ClaseArrayCadenas(cant);

            // Llamada al método GenerarSerieExamenIterativo
            AC1.GenerarSerieExamenIterativo(true, 5, 10, cant);
        
            // Mostrar el array después de generar la serie
            AC1.MostrarArray();

            
            //Crea el fichero donde estara la serie
            string path = "D:/UPC/Github/PRO2-UPC-HOMEWORK/Examen-Final/for/ficheroArray.txt";
            FicheroRonald fd = new FicheroRonald(path);
            fd.EscribirArray(AC1.ArrayCadenas);
            //Console.WriteLine();
            */

            for(int a = 1; a<=10;a++){
            //Genra una serie iterativa
            Console.WriteLine("Examen Final");

            int cant = 10;
            ClaseArrayCadenas AC1 = new ClaseArrayCadenas(cant);

            // Llamada al método GenerarSerieExamenIterativo
            AC1.GenerarSerieExamenIterativo(true, 5, 10, cant);
        
            // Mostrar el array después de generar la serie
            AC1.MostrarArray();
            
            string path = "D:/UPC/Github/PRO2-UPC-HOMEWORK/Examen-Final/for/IterativoArchivo" + a + ".txt";
            FicheroRonald fd = new FicheroRonald(path);
            fd.EscribirArray(AC1.ArrayCadenas);
                
            }
            

        }
    }
}