using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power raises when the user has lower Speed, up to a maximum of 150.
	public class MoveGyroBall : Move
	{
#nullable enable
		private static MoveGyroBall? _instance = null;
#nullable restore
        public static MoveGyroBall Instance => _instance ?? (_instance = new MoveGyroBall());

		public MoveGyroBall() : base(
			"Gyro-Ball",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}