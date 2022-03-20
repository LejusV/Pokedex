using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mantine Species to store common natural stats of all Mantines
	#region MantineSpecies
	public class MantineSpecies : PokemonSpecies
	{
#nullable enable
		private static MantineSpecies? _instance = null;
#nullable restore
        public static MantineSpecies Instance => _instance ?? (_instance = new MantineSpecies());

		#region MantineSpecies Constructor
		public MantineSpecies() : base(
			226,
			"Mantine",
			Water.Instance, Flying.Instance,
			2.1,
			220.0,
			new PokemonStats(
				85, // HPs
				40, 70, // Attack & Defense
				80, 140, // Spacial Attack & Defense
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
				"Wing-Attack",
				"Slam",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Supersonic",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Bubble-Beam",
				"Hyper-Beam",
				"String-Shot",
				"Earthquake",
				"Toxic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Haze",
				"Waterfall",
				"Swift",
				"Amnesia",
				"Bubble",
				"Splash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Mirror-Coat",
				"Whirlpool",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Air-Cutter",
				"Rock-Tomb",
				"Signal-Beam",
				"Bullet-Seed",
				"Aerial-Ace",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"Roost",
				"Brine",
				"Natural-Gift",
				"Tailwind",
				"Aqua-Ring",
				"Aqua-Tail",
				"Seed-Bomb",
				"Air-Slash",
				"Giga-Impact",
				"Defog",
				"Gunk-Shot",
				"Iron-Head",
				"Captivate",
				"Wide-Guard",
				"Round",
				"Scald",
				"Acrobatics",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}