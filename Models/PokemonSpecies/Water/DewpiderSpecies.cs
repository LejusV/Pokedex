using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dewpider Species to store common natural stats of all Dewpiders
	#region DewpiderSpecies
	public class DewpiderSpecies : PokemonSpecies
	{
#nullable enable
		private static DewpiderSpecies? _instance = null;
#nullable restore
        public static DewpiderSpecies Instance => _instance ?? (_instance = new DewpiderSpecies());

		#region DewpiderSpecies Constructor
		public DewpiderSpecies() : base(
			751,
			"Dewpider",
			Water.Instance, Bug.Instance,
			0.3,
			4.0,
			new PokemonStats(
				38, // HPs
				40, 52, // Attack & Defense
				40, 72, // Spacial Attack & Defense
				27 // Speed
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
				"Aurora-Beam",
				"Toxic",
				"Double-Team",
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
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Mirror-Coat",
				"Stockpile",
				"Spit-Up",
				"Facade",
				"Water-Sport",
				"Aqua-Ring",
				"Poison-Jab",
				"X-Scissor",
				"Bug-Bite",
				"Power-Split",
				"Entrainment",
				"Round",
				"Scald",
				"Frost-Breath",
				"Sticky-Web",
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