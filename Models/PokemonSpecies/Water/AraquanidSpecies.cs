using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Araquanid Species to store common natural stats of all Araquanids
	#region AraquanidSpecies
	public class AraquanidSpecies : PokemonSpecies
	{
#nullable enable
		private static AraquanidSpecies? _instance = null;
#nullable restore
        public static AraquanidSpecies Instance => _instance ?? (_instance = new AraquanidSpecies());

		#region AraquanidSpecies Constructor
		public AraquanidSpecies() : base(
			752,
			"Araquanid",
			Water.Instance, Bug.Instance,
			1.8,
			82.0,
			new PokemonStats(
				68, // HPs
				70, 92, // Attack & Defense
				50, 132, // Spacial Attack & Defense
				42 // Speed
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
				"Bite",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Toxic",
				"Double-Team",
				"Reflect",
				"Waterfall",
				"Leech-Life",
				"Bubble",
				"Rest",
				"Substitute",
				"Spider-Web",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Mirror-Coat",
				"Facade",
				"Aqua-Ring",
				"Poison-Jab",
				"X-Scissor",
				"Bug-Bite",
				"Wide-Guard",
				"Soak",
				"Entrainment",
				"Round",
				"Scald",
				"Frost-Breath",
				"Confide",
				"Infestation",
				"Lunge",
				"Liquidation"
			};
		}
		#endregion
	}
	#endregion
}