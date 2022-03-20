using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Samurott Species to store common natural stats of all Samurotts
	#region SamurottSpecies
	public class SamurottSpecies : PokemonSpecies
	{
#nullable enable
		private static SamurottSpecies? _instance = null;
#nullable restore
        public static SamurottSpecies Instance => _instance ?? (_instance = new SamurottSpecies());

		#region SamurottSpecies Constructor
		public SamurottSpecies() : base(
			503,
			"Samurott",
			Water.Instance,
			1.5,
			94.6,
			new PokemonStats(
				95, // HPs
				100, 85, // Attack & Defense
				108, 70, // Spacial Attack & Defense
				70 // Speed
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
				"Hyper-Beam",
				"Strength",
				"Dig",
				"Toxic",
				"Double-Team",
				"Focus-Energy",
				"Waterfall",
				"Rest",
				"Slash",
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
				"Megahorn",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Revenge",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Hydro-Cannon",
				"Aerial-Ace",
				"Block",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Fling",
				"Aqua-Tail",
				"X-Scissor",
				"Giga-Impact",
				"Grass-Knot",
				"Aqua-Jet",
				"Round",
				"Scald",
				"Retaliate",
				"Water-Pledge",
				"Dragon-Tail",
				"Work-Up",
				"Razor-Shell",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}