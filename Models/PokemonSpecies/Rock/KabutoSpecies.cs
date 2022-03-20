using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kabuto Species to store common natural stats of all Kabutos
	#region KabutoSpecies
	public class KabutoSpecies : PokemonSpecies
	{
#nullable enable
		private static KabutoSpecies? _instance = null;
#nullable restore
        public static KabutoSpecies Instance => _instance ?? (_instance = new KabutoSpecies());

		#region KabutoSpecies Constructor
		public KabutoSpecies() : base(
			140,
			"Kabuto",
			Rock.Instance, Water.Instance,
			0.5,
			11.5,
			new PokemonStats(
				30, // HPs
				80, 90, // Attack & Defense
				55, 45, // Spacial Attack & Defense
				55 // Speed
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
				"Sand-Attack",
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
				"Aurora-Beam",
				"Absorb",
				"Mega-Drain",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Confuse-Ray",
				"Reflect",
				"Bide",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Mud-Shot",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Wring-Out",
				"Rock-Polish",
				"Earth-Power",
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