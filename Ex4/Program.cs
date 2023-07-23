namespace Ex4
{
	public class Program
	{
		static bool done = false;

		static void Main(string[] args)
		{

			DownloadAndProcessFile();
			while (!done)
			{
				Console.Write("*");
				Thread.Sleep(50);
			}
			Console.WriteLine();
            Console.WriteLine("Bitti");

            ////////////////////////////////////////////

           
		}

		static async void DownloadAndProcessFile()
		{
			string url = "deneme.log";
			string filePath = "deneme.log";
			byte[] orginalFileBytes;
			try
			{
				orginalFileBytes= await DowloandFile(url);
			}
			catch (Exception ex)
			{

                Console.Out.WriteLineAsync(ex.Message);
            } 
			var processedFileBytes=await ProcossFile(filePath);
			var processedFileName= "deneme_processed.log";
			await SaveFile(processedFileBytes, processedFileName);
			done = true;
			//string[] arr = { "kk" };
			//await Main(arr);
			//Task.Run(() =>
			//{
			//	for(int i=0;i<10;i++)
			//	{
			//                 Console.WriteLine(i);
			//		Thread.Sleep(50);
			//             }
			//});  // geriye Task dönmeyen bir metod da çağrılabilir.

			Task.Run(Don);
		}

		static void Don()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
				Thread.Sleep(50);
			}
		}

		//static void DownloadAndProcessFile()
		//{
		//	string url = "deneme.log";
		//	string filePath = "deneme.log";



		//	DowloandFile(url).ContinueWith(task1 =>
		//	{
		//		var orginalFileBytes = task1.Result;
		//		// Dosyaya yazıldı
		//		ProcossFile(filePath).ContinueWith(task2 =>
		//		{
		//			var processedFileBytes = task2.Result;
		//			var processedFileName = "deneme_processed.log";
		//			SaveFile(processedFileBytes, processedFileName).ContinueWith(task3 =>
		//			{
		//				//while (!task3.IsCompleted)
		//				//	continue;

		//				done = true;
		//			});
		//		});
		//	});


		//}

		static Task<byte[]> DowloandFile(string url)
		{
			Thread.Sleep(3000);
			// Bir adres gelsin. Ben o adresteki dosyayı okuyayım.Burdan Byte array olarak geriye döneyim
			return File.ReadAllBytesAsync(url);
		}

		static Task<byte[]> ProcossFile(string path)
		{
			Thread.Sleep(3000);

			return File.ReadAllBytesAsync(path);
		}

		static Task SaveFile(byte[] bytes, string path)
		{
			Thread.Sleep(2000);
			File.WriteAllBytesAsync(path, bytes);
			return Task.CompletedTask;
		}

	}
}