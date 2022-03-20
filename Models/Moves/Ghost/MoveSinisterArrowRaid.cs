using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSinisterArrowRaid : Move
	{
#nullable enable
		private static MoveSinisterArrowRaid? _instance = null;
#nullable restore
        public static MoveSinisterArrowRaid Instance => _instance ?? (_instance = new MoveSinisterArrowRaid());

		public MoveSinisterArrowRaid() : base(
			"Sinister-Arrow-Raid",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 180,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}