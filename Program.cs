using System.Text;
namespace Archivos
{
    class Program
    {
            static void Main(string[] args)
        {
            
            int id = 0 ; 
            StringBuilder sbOutput = new StringBuilder();
            List<string> archivos = new List<string>();
            Console.WriteLine("Ingrese la ruta");
            string path = Console.ReadLine();
            if (Directory.Exists(path))
            {
                archivos = Directory.GetFiles(path).ToList();
                
            }else
            {
                Console.WriteLine("No existe esta ruta");
                Directory.CreateDirectory(path);
            }
            foreach (string  item in archivos)
                {
                    Console.WriteLine(item);
                    string ext = (Path.GetExtension(item));
                    id++;
                    string name = Path.GetFileNameWithoutExtension(item);
                    string linea = id + ";" + name + ";" + ext + "\n";
                    File.AppendAllText(path + @"\index.csv", linea );
                    
                    
                    
                }
                
             
            
            

            

            
        }
        
    }
    
}