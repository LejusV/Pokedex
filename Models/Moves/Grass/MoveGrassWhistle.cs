using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Puts the target to sleep.
	public class MoveGrassWhistle : Move
	{
#nullable enable
		private static MoveGrassWhistle? _instance = null;
#nullable restore
        public static MoveGrassWhistle Instance => _instance ?? (_instance = new MoveGrassWhistle());

		public MoveGrassWhistle() : base(
			"Grass-Whistle",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			55, 0 // Acc & Priority
		) {}
	}
}