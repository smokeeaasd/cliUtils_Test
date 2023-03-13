using Lukinha.cliUtils.Menus;
using Lukinha.cliUtils.Options;

namespace CLI.Test
{
	class Program
	{
		enum Time
		{
			RealMadrid,
			Barcelona,
			PSG,
			ManchesterCity,
			ManchesterUnited,
			Liverpool,
			Arsenal,
		}

		static void Main(string[] args)
		{
			OptionList options = new OptionList() {
				new Option("Vinícius Junior", Time.RealMadrid),
				new Option("Raphinha", Time.Barcelona),
				new Option("Neymar Jr", Time.PSG),
				new Option("Ederson", Time.ManchesterCity),
				new Option("Casemiro", Time.ManchesterUnited),
				new Option("Alisson", Time.Liverpool),
				new Option("Gabriel Martinelli", Time.Arsenal),
			};

			MenuConfiguration config = new MenuConfiguration(
				ConsoleColor.Green,
				ConsoleColor.Gray
			);

			SelectMenu menu = new SelectMenu(options, config);

			Option opt = menu.Show();

			Console.WriteLine();

			Console.Write("Você escolheu o jogador ");

			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.Write(opt.Text);
			Console.ResetColor();

			Console.Write(", que joga no ");

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(opt.Value);
			Console.ResetColor();
		}
	}
}