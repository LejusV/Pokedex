using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveTectonicRageSpecial : Move
	{
#nullable enable
		private static MoveTectonicRageSpecial? _instance = null;
#nullable restore
        public static MoveTectonicRageSpecial Instance => _instance ?? (_instance = new MoveTectonicRageSpecial());

		public MoveTectonicRageSpecial() : base(
			"Tectonic-Rage--Special",
			Ground.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}