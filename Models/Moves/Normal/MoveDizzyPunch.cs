using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to confuse the target.
	public class MoveDizzyPunch : Move
	{
#nullable enable
		private static MoveDizzyPunch? _instance = null;
#nullable restore
        public static MoveDizzyPunch Instance => _instance ?? (_instance = new MoveDizzyPunch());

		public MoveDizzyPunch() : base(
			"Dizzy-Punch",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}