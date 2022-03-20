using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bastiodon Species to store common natural stats of all Bastiodons
	#region BastiodonSpecies
	public class BastiodonSpecies : PokemonSpecies
	{
#nullable enable
		private static BastiodonSpecies? _instance = null;
#nullable restore
        public static BastiodonSpecies Instance => _instance ?? (_instance = new BastiodonSpecies());

		#region BastiodonSpecies Constructor
		public BastiodonSpecies() : base(
			411,
			"Bastiodon",
			Rock.Instance, Steel.Instance,
			1.3,
			149.5,
			new PokemonStats(
				60, // HPs
				52, 168, // Attack & Defense
				47, 138, // Spacial Attack & Defense
				30 // Speed
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
				"Tackle",
				"Take-Down",
				"Roar",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Magic-Coat",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Iron-Defense",
				"Block",
				"Shock-Wave",
				"Natural-Gift",
				"Metal-Burst",
				"Magnet-Rise",
				"Rock-Polish",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Flash-Cannon",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Heavy-Slam",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}