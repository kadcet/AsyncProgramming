namespace Ex1
{
	public class Program
	{
		static void Main(string[] args)
		{
			
			// Burda her Task işlemini birbirine zincirleme ContinueWith ile bağladık
			bool done =false;
			string url = "deneme.log";
			string filePath = "deneme.log";

			DowloandFile(url).ContinueWith(task1 =>
			{
				var orginalFileBytes = task1.Result;
				// Dosyaya yazıldı
				ProcossFile(filePath).ContinueWith(task2 =>
				{
					var processedFileBytes = task2.Result;
					var processedFileName = "deneme_processed.log";
					SaveFile(processedFileBytes, processedFileName).ContinueWith(task3 =>
					{
						//while (!task3.IsCompleted)
						//	continue;

						done = true;
					});
				});
			});

			while (!done)
			{
                Console.Write("*");
				Thread.Sleep(50);
            }
			Console.ReadLine();
		}

		static Task<byte[]> DowloandFile(string url)
		{
			Thread.Sleep(3000);
			// Bir adres gelsin. Ben o adresteki dosyayı okuyayım.Burdan Byte array olarak geriye  döneyim
			return File.ReadAllBytesAsync(url);
		}

		static Task<byte[]> ProcossFile(string path)
		{
			Thread.Sleep(5000);
			return File.ReadAllBytesAsync(path);
		}

		static Task SaveFile(byte[] bytes,string path)
		{
			Thread.Sleep(2000);
			File.WriteAllBytesAsync(path, bytes);
			return Task.CompletedTask;
		}
	}
}