using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mamoswine Species to store common natural stats of all Mamoswines
	#region MamoswineSpecies
	public class MamoswineSpecies : PokemonSpecies
	{
#nullable enable
		private static MamoswineSpecies? _instance = null;
#nullable restore
        public static MamoswineSpecies Instance => _instance ?? (_instance = new MamoswineSpecies());

		#region MamoswineSpecies Constructor
		public MamoswineSpecies() : base(
			473,
			"Mamoswine",
			Ice.Instance, Ground.Instance,
			2.5,
			291.0,
			new PokemonStats(
				110, // HPs
				130, 80, // Attack & Defense
				70, 60, // Spacial Attack & Defense
				80 // Speed
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
				"Headbutt",
				"Fury-Attack",
				"Take-Down",
				"Thrash",
				"Roar",
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Peck",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Powder-Snow",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Superpower",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Mud-Sport",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Block",
				"Natural-Gift",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Ice-Fang",
				"Mud-Bomb",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Double-Hit",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}