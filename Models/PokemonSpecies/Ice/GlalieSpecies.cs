using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Glalie Species to store common natural stats of all Glalies
	#region GlalieSpecies
	public class GlalieSpecies : PokemonSpecies
	{
#nullable enable
		private static GlalieSpecies? _instance = null;
#nullable restore
        public static GlalieSpecies Instance => _instance ?? (_instance = new GlalieSpecies());

		#region GlalieSpecies Constructor
		public GlalieSpecies() : base(
			362,
			"Glalie",
			Ice.Instance,
			1.5,
			256.5,
			new PokemonStats(
				80, // HPs
				80, 80, // Attack & Defense
				80, 80, // Spacial Attack & Defense
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
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Self-Destruct",
				"Flash",
				"Explosion",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Spite",
				"Powder-Snow",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Shadow-Ball",
				"Hail",
				"Torment",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Signal-Beam",
				"Sheer-Cold",
				"Block",
				"Water-Pulse",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Dark-Pulse",
				"Giga-Impact",
				"Avalanche",
				"Ice-Shard",
				"Ice-Fang",
				"Iron-Head",
				"Captivate",
				"Round",
				"Bulldoze",
				"Frost-Breath",
				"Freeze-Dry",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}