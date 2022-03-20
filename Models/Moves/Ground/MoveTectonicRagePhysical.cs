using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveTectonicRagePhysical : Move
	{
#nullable enable
		private static MoveTectonicRagePhysical? _instance = null;
#nullable restore
        public static MoveTectonicRagePhysical Instance => _instance ?? (_instance = new MoveTectonicRagePhysical());

		public MoveTectonicRagePhysical() : base(
			"Tectonic-Rage--Physical",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}