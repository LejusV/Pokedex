using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Rhyhorn Species to store common natural stats of all Rhyhorns
	#region RhyhornSpecies
	public class RhyhornSpecies : PokemonSpecies
	{
#nullable enable
		private static RhyhornSpecies? _instance = null;
#nullable restore
        public static RhyhornSpecies Instance => _instance ?? (_instance = new RhyhornSpecies());

		#region RhyhornSpecies Constructor
		public RhyhornSpecies() : base(
			111,
			"Rhyhorn",
			Ground.Instance, Rock.Instance,
			1.0,
			115.0,
			new PokemonStats(
				80, // HPs
				85, 95, // Attack & Defense
				30, 30, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Stomp",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Horn-Drill",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Tail-Whip",
				"Leer",
				"Roar",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Fire-Blast",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Reversal",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Megahorn",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Crush-Claw",
				"Rock-Tomb",
				"Rock-Blast",
				"Shock-Wave",
				"Natural-Gift",
				"Metal-Burst",
				"Payback",
				"Rock-Polish",
				"Poison-Jab",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Earth-Power",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Guard-Split",
				"Smack-Down",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Bulldoze",
				"Drill-Run",
				"Rototiller",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}