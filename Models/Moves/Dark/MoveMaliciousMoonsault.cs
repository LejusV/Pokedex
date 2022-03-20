using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMaliciousMoonsault : Move
	{
#nullable enable
		private static MoveMaliciousMoonsault? _instance = null;
#nullable restore
        public static MoveMaliciousMoonsault Instance => _instance ?? (_instance = new MoveMaliciousMoonsault());

		public MoveMaliciousMoonsault() : base(
			"Malicious-Moonsault",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, 180,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}