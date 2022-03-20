using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Adds grass to the target's types.
	public class MoveForestsCurse : Move
	{
#nullable enable
		private static MoveForestsCurse? _instance = null;
#nullable restore
        public static MoveForestsCurse Instance => _instance ?? (_instance = new MoveForestsCurse());

		public MoveForestsCurse() : base(
			"Forests-Curse",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}