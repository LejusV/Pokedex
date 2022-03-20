using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSavageSpinOutPhysical : Move
	{
#nullable enable
		private static MoveSavageSpinOutPhysical? _instance = null;
#nullable restore
        public static MoveSavageSpinOutPhysical Instance => _instance ?? (_instance = new MoveSavageSpinOutPhysical());

		public MoveSavageSpinOutPhysical() : base(
			"Savage-Spin-Out--Physical",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}