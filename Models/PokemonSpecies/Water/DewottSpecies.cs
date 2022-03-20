using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dewott Species to store common natural stats of all Dewotts
	#region DewottSpecies
	public class DewottSpecies : PokemonSpecies
	{
#nullable enable
		private static DewottSpecies? _instance = null;
#nullable restore
        public static DewottSpecies Instance => _instance ?? (_instance = new DewottSpecies());

		#region DewottSpecies Constructor
		public DewottSpecies() : base(
			502,
			"Dewott",
			Water.Instance,
			0.8,
			24.5,
			new PokemonStats(
				75, // HPs
				75, 60, // Attack & Defense
				83, 60, // Spacial Attack & Defense
				60 // Speed
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
				"Double-Team",
				"Focus-Energy",
				"Waterfall",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
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
				"Fling",
				"Aqua-Tail",
				"X-Scissor",
				"Grass-Knot",
				"Aqua-Jet",
				"Round",
				"Scald",
				"Retaliate",
				"Water-Pledge",
				"Work-Up",
				"Razor-Shell",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}