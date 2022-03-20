using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Walrein Species to store common natural stats of all Walreins
	#region WalreinSpecies
	public class WalreinSpecies : PokemonSpecies
	{
#nullable enable
		private static WalreinSpecies? _instance = null;
#nullable restore
        public static WalreinSpecies Instance => _instance ?? (_instance = new WalreinSpecies());

		#region WalreinSpecies Constructor
		public WalreinSpecies() : base(
			365,
			"Walrein",
			Ice.Instance, Water.Instance,
			1.4,
			150.6,
			new PokemonStats(
				110, // HPs
				80, 90, // Attack & Defense
				95, 90, // Spacial Attack & Defense
				65 // Speed
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
				"Hyper-Beam",
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
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
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
				"Block",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Tail",
				"Giga-Impact",
				"Avalanche",
				"Ice-Fang",
				"Iron-Head",
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