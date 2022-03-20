using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sealeo Species to store common natural stats of all Sealeos
	#region SealeoSpecies
	public class SealeoSpecies : PokemonSpecies
	{
#nullable enable
		private static SealeoSpecies? _instance = null;
#nullable restore
        public static SealeoSpecies Instance => _instance ?? (_instance = new SealeoSpecies());

		#region SealeoSpecies Constructor
		public SealeoSpecies() : base(
			364,
			"Sealeo",
			Ice.Instance, Water.Instance,
			1.1,
			87.6,
			new PokemonStats(
				90, // HPs
				60, 70, // Attack & Defense
				75, 70, // Spacial Attack & Defense
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Roar",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Aurora-Beam",
				"Strength",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Ice-Ball",
				"Rock-Tomb",
				"Signal-Beam",
				"Sheer-Cold",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Tail",
				"Captivate",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}