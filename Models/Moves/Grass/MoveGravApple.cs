using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Defense by one stage after inflicting damage.
	public class MoveGravApple : Move
	{
#nullable enable
		private static MoveGravApple? _instance = null;
#nullable restore
        public static MoveGravApple Instance => _instance ?? (_instance = new MoveGravApple());

		public MoveGravApple() : base(
			"Grav-Apple",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}