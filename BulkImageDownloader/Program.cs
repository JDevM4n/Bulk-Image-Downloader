namespace BulkImageDownloader;

class Program
{
    static async Task Main(string[] args)
    {
        //URL container
        string[] urls = new string[5]
        {
            "https://picsum.photos/id/10/2000/2000", // Imagen HD 1
            "https://picsum.photos/id/20/2000/2000", // Imagen HD 2
            "https://picsum.photos/id/30/2000/2000", // Imagen HD 3
            "https://picsum.photos/id/40/2000/2000", // Imagen HD 4
            "https://picsum.photos/id/50/2000/2000"  // Imagen HD 5
        };

        //We create internet client (herramienta de descarga)
        using HttpClient client = new HttpClient();

        Console.WriteLine("Starting secuencial download of images \n)");

        //flujo de control
        for(int i = 0; i < urls.Length; i++)
        {
            int numberImage = i + 1;
            Console.WriteLine($"[Start] Downloading image {numberImage} de 5...");

            try
            {
    
                byte[] dataImage = await client.GetByteArrayAsync(urls[i]);

                //Nombre del archivo final
                string fileName = $"image_{numberImage}.jpg";

                await File.WriteAllBytesAsync(fileName, dataImage);

                Console.WriteLine($"[Hecho] Imagen {numberImage} descargada y guardada como {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] No se pudo descargar la imagen {numberImage}");
            }
        }
        Console.WriteLine("\nProceso terminado. Revisa la carpeta de tu proyecto");
    }
}
