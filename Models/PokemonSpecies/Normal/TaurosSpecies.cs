using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tauros Species to store common natural stats of all Tauross
	#region TaurosSpecies
	public class TaurosSpecies : PokemonSpecies
	{
#nullable enable
		private static TaurosSpecies? _instance = null;
#nullable restore
        public static TaurosSpecies Instance => _instance ?? (_instance = new TaurosSpecies());

		#region TaurosSpecies Constructor
		public TaurosSpecies() : base(
			128,
			"Tauros",
			Normal.Instance,
			1.4,
			88.4,
			new PokemonStats(
				75, // HPs
				100, 95, // Attack & Defense
				40, 70, // Spacial Attack & Defense
				110 // Speed
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
				"Stomp",
				"Headbutt",
				"Horn-Attack",
				"Horn-Drill",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Tail-Whip",
				"Leer",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Fissure",
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
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Scary-Face",
				"Zap-Cannon",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Role-Play",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Giga-Impact",
				"Zen-Headbutt",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Round",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}