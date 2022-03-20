using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveAllOutPummelingSpecial : Move
	{
#nullable enable
		private static MoveAllOutPummelingSpecial? _instance = null;
#nullable restore
        public static MoveAllOutPummelingSpecial Instance => _instance ?? (_instance = new MoveAllOutPummelingSpecial());

		public MoveAllOutPummelingSpecial() : base(
			"All-Out-Pummeling--Special",
			Fighting.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}