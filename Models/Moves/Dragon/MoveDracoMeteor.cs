using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Special Attack by two stages after inflicting damage.
	public class MoveDracoMeteor : Move
	{
#nullable enable
		private static MoveDracoMeteor? _instance = null;
#nullable restore
        public static MoveDracoMeteor Instance => _instance ?? (_instance = new MoveDracoMeteor());

		public MoveDracoMeteor() : base(
			"Draco-Meteor",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 130,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}