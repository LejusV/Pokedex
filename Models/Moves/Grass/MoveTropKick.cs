using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack by one stage after inflicting damage.
	public class MoveTropKick : Move
	{
#nullable enable
		private static MoveTropKick? _instance = null;
#nullable restore
        public static MoveTropKick Instance => _instance ?? (_instance = new MoveTropKick());

		public MoveTropKick() : base(
			"Trop-Kick",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}