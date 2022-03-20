using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSappySeed : Move
	{
#nullable enable
		private static MoveSappySeed? _instance = null;
#nullable restore
        public static MoveSappySeed Instance => _instance ?? (_instance = new MoveSappySeed());

		public MoveSappySeed() : base(
			"Sappy-Seed",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}