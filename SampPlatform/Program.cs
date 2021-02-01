using SampSharp.Core;

namespace SampPlatform {
    public class Program {
		public static void Main(string[] args) {
			new GameModeBuilder()
				.Use<GameMode>()
				.UseStartBehaviour(GameModeStartBehaviour.FakeGmx)
				.Run();
		}
	}
}
