using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveScaleShot : Move
	{
#nullable enable
		private static MoveScaleShot? _instance = null;
#nullable restore
        public static MoveScaleShot Instance => _instance ?? (_instance = new MoveScaleShot());

		public MoveScaleShot() : base(
			"Scale-Shot",
			Dragon.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 25,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}