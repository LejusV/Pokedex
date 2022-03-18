using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Primeape Species to store common natural stats of all Primeapes
	#region SpeciesPrimeape
	public class SpeciesPrimeape : PokemonSpecies
	{
#nullable enable
		private static SpeciesPrimeape? _instance = null;
#nullable restore
        public static SpeciesPrimeape Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPrimeape();
                }
                return _instance;
            }
        }

		#region SpeciesPrimeape Constructor
		public SpeciesPrimeape() : base(
			57,
			"Primeape",
			1.0,
			32.0,
			65, // HPs
			105, 60, // Attack & Defense
			60, 70, // Special Attack & Defense
			95		
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

	//Primeape PokemonInstance Class
	#region Primeape
	public class PrimeapeInstance : PokemonInstance
	{
		#region Primeape Constructors
		/// <summary>
		/// Primeape Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PrimeapeInstance(string nickname, int level)
		: base(
				SpeciesPrimeape.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Primeape Builder only waiting for a Level
		/// </summary>
		public PrimeapeInstance(int level)
		: base(
				SpeciesPrimeape.Instance, // PokemonInstance Species
				"Primeape", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Primeape Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PrimeapeInstance() : base(
			SpeciesPrimeape.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}