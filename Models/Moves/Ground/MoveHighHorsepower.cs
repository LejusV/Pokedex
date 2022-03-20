using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveHighHorsepower : Move
	{
#nullable enable
		private static MoveHighHorsepower? _instance = null;
#nullable restore
        public static MoveHighHorsepower Instance => _instance ?? (_instance = new MoveHighHorsepower());

		public MoveHighHorsepower() : base(
			"High-Horsepower",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 95,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}