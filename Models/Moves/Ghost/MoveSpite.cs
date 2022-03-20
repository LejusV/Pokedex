using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the PP of the target's last used move by 4.
	public class MoveSpite : Move
	{
#nullable enable
		private static MoveSpite? _instance = null;
#nullable restore
        public static MoveSpite Instance => _instance ?? (_instance = new MoveSpite());

		public MoveSpite() : base(
			"Spite",
			Ghost.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}