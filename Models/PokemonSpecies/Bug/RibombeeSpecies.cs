using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ribombee Species to store common natural stats of all Ribombees
	#region RibombeeSpecies
	public class RibombeeSpecies : PokemonSpecies
	{
#nullable enable
		private static RibombeeSpecies? _instance = null;
#nullable restore
        public static RibombeeSpecies Instance => _instance ?? (_instance = new RibombeeSpecies());

		#region RibombeeSpecies Constructor
		public RibombeeSpecies() : base(
			743,
			"Ribombee",
			Bug.Instance, Fairy.Instance,
			0.2,
			0.5,
			new PokemonStats(
				60, // HPs
				55, 60, // Attack & Defense
				95, 70, // Spacial Attack & Defense
				124 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Absorb",
				"Solar-Beam",
				"Stun-Spore",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Facade",
				"Nature-Power",
				"Aromatherapy",
				"Silver-Wind",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"U-Turn",
				"Bug-Buzz",
				"Energy-Ball",
				"Quiver-Dance",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Draining-Kiss",
				"Fairy-Wind",
				"Confide",
				"Dazzling-Gleam",
				"Infestation",
				"Pollen-Puff"
			};
		}
		#endregion
	}
	#endregion
}