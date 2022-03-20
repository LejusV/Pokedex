using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveFloatyFall : Move
	{
#nullable enable
		private static MoveFloatyFall? _instance = null;
#nullable restore
        public static MoveFloatyFall Instance => _instance ?? (_instance = new MoveFloatyFall());

		public MoveFloatyFall() : base(
			"Floaty-Fall",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 90,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}