using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Cures the entire party of major status effects.
	public class MoveAromatherapy : Move
	{
#nullable enable
		private static MoveAromatherapy? _instance = null;
#nullable restore
        public static MoveAromatherapy Instance => _instance ?? (_instance = new MoveAromatherapy());

		public MoveAromatherapy() : base(
			"Aromatherapy",
			Grass.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}