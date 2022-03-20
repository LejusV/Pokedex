using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kyogre Species to store common natural stats of all Kyogres
	#region KyogreSpecies
	public class KyogreSpecies : PokemonSpecies
	{
#nullable enable
		private static KyogreSpecies? _instance = null;
#nullable restore
        public static KyogreSpecies Instance => _instance ?? (_instance = new KyogreSpecies());

		#region KyogreSpecies Constructor
		public KyogreSpecies() : base(
			382,
			"Kyogre",
			Water.Instance,
			4.5,
			352.0,
			new PokemonStats(
				100, // HPs
				100, 90, // Attack & Defense
				150, 140, // Spacial Attack & Defense
				90 // Speed
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
				"Roar",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Waterfall",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Water-Spout",
				"Signal-Beam",
				"Sheer-Cold",
				"Muddy-Water",
				"Block",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Ring",
				"Aqua-Tail",
				"Giga-Impact",
				"Avalanche",
				"Iron-Head",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide",
				"Origin-Pulse"
			};
		}
		#endregion
	}
	#endregion
}