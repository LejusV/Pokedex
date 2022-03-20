using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User receives 1/4 the damage it inflicts in recoil.
	public class MoveSubmission : Move
	{
#nullable enable
		private static MoveSubmission? _instance = null;
#nullable restore
        public static MoveSubmission Instance => _instance ?? (_instance = new MoveSubmission());

		public MoveSubmission() : base(
			"Submission",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 80,// PP & Pow
			80, 0 // Acc & Priority
		) {}
	}
}