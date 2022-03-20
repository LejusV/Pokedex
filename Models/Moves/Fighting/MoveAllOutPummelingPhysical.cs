using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveAllOutPummelingPhysical : Move
	{
#nullable enable
		private static MoveAllOutPummelingPhysical? _instance = null;
#nullable restore
        public static MoveAllOutPummelingPhysical Instance => _instance ?? (_instance = new MoveAllOutPummelingPhysical());

		public MoveAllOutPummelingPhysical() : base(
			"All-Out-Pummeling--Physical",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}