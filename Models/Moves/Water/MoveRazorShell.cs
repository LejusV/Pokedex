using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to lower the target's Defense by one stage.
	public class MoveRazorShell : Move
	{
#nullable enable
		private static MoveRazorShell? _instance = null;
#nullable restore
        public static MoveRazorShell Instance => _instance ?? (_instance = new MoveRazorShell());

		public MoveRazorShell() : base(
			"Razor-Shell",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 75,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}