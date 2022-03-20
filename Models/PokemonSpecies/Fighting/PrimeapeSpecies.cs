using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Primeape Species to store common natural stats of all Primeapes
	#region PrimeapeSpecies
	public class PrimeapeSpecies : PokemonSpecies
	{
#nullable enable
		private static PrimeapeSpecies? _instance = null;
#nullable restore
        public static PrimeapeSpecies Instance => _instance ?? (_instance = new PrimeapeSpecies());

		#region PrimeapeSpecies Constructor
		public PrimeapeSpecies() : base(
			57,
			"Primeape",
			Fighting.Instance,
			1.0,
			32.0,
			new PokemonStats(
				65, // HPs
				105, 60, // Attack & Defense
				60, 70, // Spacial Attack & Defense
				95 // Speed
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
				"Karate-Chop",
				"Mega-Punch",
				"Pay-Day",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Hyper-Beam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Bide",
				"Metronome",
				"Swift",
				"Skull-Bash",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Natural-Gift",
				"U-Turn",
				"Close-Combat",
				"Payback",
				"Assurance",
				"Fling",
				"Punishment",
				"Poison-Jab",
				"Seed-Bomb",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Gunk-Shot",
				"Stone-Edge",
				"Captivate",
				"Hone-Claws",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Acrobatics",
				"Retaliate",
				"Final-Gambit",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch",
				"Stomping-Tantrum"
			};
		}
		#endregion
	}
	#endregion
}