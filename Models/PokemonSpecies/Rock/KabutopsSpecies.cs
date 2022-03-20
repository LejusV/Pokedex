using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kabutops Species to store common natural stats of all Kabutopss
	#region KabutopsSpecies
	public class KabutopsSpecies : PokemonSpecies
	{
#nullable enable
		private static KabutopsSpecies? _instance = null;
#nullable restore
        public static KabutopsSpecies Instance => _instance ?? (_instance = new KabutopsSpecies());

		#region KabutopsSpecies Constructor
		public KabutopsSpecies() : base(
			141,
			"Kabutops",
			Rock.Instance, Water.Instance,
			1.3,
			40.5,
			new PokemonStats(
				60, // HPs
				115, 105, // Attack & Defense
				65, 70, // Spacial Attack & Defense
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
				"Scratch",
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Low-Kick",
				"Seismic-Toss",
				"Absorb",
				"Mega-Drain",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Harden",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Rollout",
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
				"Whirlpool",
				"Hail",
				"Facade",
				"Nature-Power",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Mud-Shot",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Feint",
				"Wring-Out",
				"Rock-Polish",
				"Night-Slash",
				"Aqua-Tail",
				"X-Scissor",
				"Earth-Power",
				"Giga-Impact",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Aqua-Jet",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}