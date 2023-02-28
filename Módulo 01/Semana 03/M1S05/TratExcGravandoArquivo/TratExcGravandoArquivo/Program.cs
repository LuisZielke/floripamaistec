
	
        FileInfo arquivo = null;

		try
		{


			Console.WriteLine("digite o nome do arquivo que você vai criar:");
			string nomeArquivo = Console.ReadLine();

			arquivo = new FileInfo(nomeArquivo);

			using (StreamWriter gravadorFluxo = File.AppendText(nomeArquivo))
			{
				gravadorFluxo.WriteLine("Texte de dentro do arquivo");
			}
		}
		catch(ArgumentException ex)
		{
		Console.WriteLine($"Tratando o erro especificamente:{ex}");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Ocorreu um erro:{ex}");
		}
		finally
		{
			Console.WriteLine($"Encerrando programa..\n");
			/*arquivo = null;
			Console.Clear();*/
		}
	
