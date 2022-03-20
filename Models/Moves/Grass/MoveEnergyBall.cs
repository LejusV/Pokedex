using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Special Defense by one stage.
	public class MoveEnergyBall : Move
	{
#nullable enable
		private static MoveEnergyBall? _instance = null;
#nullable restore
        public static MoveEnergyBall Instance => _instance ?? (_instance = new MoveEnergyBall());

		public MoveEnergyBall() : base(
			"Energy-Ball",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}