using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Primarina Species to store common natural stats of all Primarinas
	#region PrimarinaSpecies
	public class PrimarinaSpecies : PokemonSpecies
	{
#nullable enable
		private static PrimarinaSpecies? _instance = null;
#nullable restore
        public static PrimarinaSpecies Instance => _instance ?? (_instance = new PrimarinaSpecies());

		#region PrimarinaSpecies Constructor
		public PrimarinaSpecies() : base(
			730,
			"Primarina",
			Water.Instance, Fairy.Instance,
			1.8,
			44.0,
			new PokemonStats(
				80, // HPs
				74, 74, // Attack & Defense
				126, 116, // Spacial Attack & Defense
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
				"Pound",
				"Double-Slap",
				"Growl",
				"Sing",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Waterfall",
				"Rest",
				"Substitute",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Hail",
				"Facade",
				"Hyper-Voice",
				"Hydro-Cannon",
				"Energy-Ball",
				"Giga-Impact",
				"Captivate",
				"Aqua-Jet",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Acrobatics",
				"Water-Pledge",
				"Work-Up",
				"Disarming-Voice",
				"Misty-Terrain",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Baby-Doll-Eyes",
				"Sparkling-Aria"
			};
		}
		#endregion
	}
	#endregion
}