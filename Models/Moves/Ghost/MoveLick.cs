using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to paralyze the target.
	public class MoveLick : Move
	{
#nullable enable
		private static MoveLick? _instance = null;
#nullable restore
        public static MoveLick Instance => _instance ?? (_instance = new MoveLick());

		public MoveLick() : base(
			"Lick",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			30, 30,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}