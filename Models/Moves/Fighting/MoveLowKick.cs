using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts more damage to heavier targets, with a maximum of 120 power.
	public class MoveLowKick : Move
	{
#nullable enable
		private static MoveLowKick? _instance = null;
#nullable restore
        public static MoveLowKick Instance => _instance ?? (_instance = new MoveLowKick());

		public MoveLowKick() : base(
			"Low-Kick",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}