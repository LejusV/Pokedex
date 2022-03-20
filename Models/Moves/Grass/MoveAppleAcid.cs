using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//
	public class MoveAppleAcid : Move
	{
#nullable enable
		private static MoveAppleAcid? _instance = null;
#nullable restore
        public static MoveAppleAcid Instance => _instance ?? (_instance = new MoveAppleAcid());

		public MoveAppleAcid() : base(
			"Apple-Acid",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}