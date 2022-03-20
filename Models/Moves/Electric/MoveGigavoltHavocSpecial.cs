using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveGigavoltHavocSpecial : Move
	{
#nullable enable
		private static MoveGigavoltHavocSpecial? _instance = null;
#nullable restore
        public static MoveGigavoltHavocSpecial Instance => _instance ?? (_instance = new MoveGigavoltHavocSpecial());

		public MoveGigavoltHavocSpecial() : base(
			"Gigavolt-Havoc--Special",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}