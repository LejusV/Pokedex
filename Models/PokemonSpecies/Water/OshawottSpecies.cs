using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Oshawott Species to store common natural stats of all Oshawotts
	#region OshawottSpecies
	public class OshawottSpecies : PokemonSpecies
	{
#nullable enable
		private static OshawottSpecies? _instance = null;
#nullable restore
        public static OshawottSpecies Instance => _instance ?? (_instance = new OshawottSpecies());

		#region OshawottSpecies Constructor
		public OshawottSpecies() : base(
			501,
			"Oshawott",
			Water.Instance,
			0.5,
			5.9,
			new PokemonStats(
				55, // HPs
				55, 45, // Attack & Defense
				63, 45, // Spacial Attack & Defense
				45 // Speed
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
				"Swords-Dance",
				"Cut",
				"Tackle",
				"Tail-Whip",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Dig",
				"Toxic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Waterfall",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Detect",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Revenge",
				"Secret-Power",
				"Dive",
				"Aerial-Ace",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Assurance",
				"Fling",
				"Trump-Card",
				"Copycat",
				"Night-Slash",
				"Aqua-Tail",
				"Air-Slash",
				"X-Scissor",
				"Grass-Knot",
				"Aqua-Jet",
				"Round",
				"Scald",
				"Retaliate",
				"Water-Pledge",
				"Work-Up",
				"Sacred-Sword",
				"Razor-Shell",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}