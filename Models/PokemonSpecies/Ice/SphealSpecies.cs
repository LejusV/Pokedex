using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Spheal Species to store common natural stats of all Spheals
	#region SphealSpecies
	public class SphealSpecies : PokemonSpecies
	{
#nullable enable
		private static SphealSpecies? _instance = null;
#nullable restore
        public static SphealSpecies Instance => _instance ?? (_instance = new SphealSpecies());

		#region SphealSpecies Constructor
		public SphealSpecies() : base(
			363,
			"Spheal",
			Ice.Instance, Water.Instance,
			0.8,
			39.5,
			new PokemonStats(
				70, // HPs
				40, 50, // Attack & Defense
				55, 50, // Spacial Attack & Defense
				25 // Speed
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
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Aurora-Beam",
				"Strength",
				"Earthquake",
				"Fissure",
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
				"Curse",
				"Powder-Snow",
				"Protect",
				"Belly-Drum",
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
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Hail",
				"Facade",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Ice-Ball",
				"Rock-Tomb",
				"Signal-Beam",
				"Sheer-Cold",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Ring",
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