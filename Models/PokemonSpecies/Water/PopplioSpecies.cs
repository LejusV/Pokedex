using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Popplio Species to store common natural stats of all Popplios
	#region PopplioSpecies
	public class PopplioSpecies : PokemonSpecies
	{
#nullable enable
		private static PopplioSpecies? _instance = null;
#nullable restore
        public static PopplioSpecies Instance => _instance ?? (_instance = new PopplioSpecies());

		#region PopplioSpecies Constructor
		public PopplioSpecies() : base(
			728,
			"Popplio",
			Water.Instance,
			0.4,
			7.5,
			new PokemonStats(
				50, // HPs
				54, 54, // Attack & Defense
				66, 56, // Spacial Attack & Defense
				40 // Speed
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
				"Double-Team",
				"Waterfall",
				"Amnesia",
				"Rest",
				"Substitute",
				"Protect",
				"Perish-Song",
				"Icy-Wind",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Hail",
				"Facade",
				"Hyper-Voice",
				"Aqua-Ring",
				"Captivate",
				"Aqua-Jet",
				"Wonder-Room",
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
				"Aromatic-Mist",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}