using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sudowoodo Species to store common natural stats of all Sudowoodos
	#region SpeciesSudowoodo
	public class SpeciesSudowoodo : PokemonSpecies
	{
#nullable enable
		private static SpeciesSudowoodo? _instance = null;
#nullable restore
        public static SpeciesSudowoodo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSudowoodo();
                }
                return _instance;
            }
        }

		#region SpeciesSudowoodo Constructor
		public SpeciesSudowoodo() : base(
			"Sudowoodo",
			1.2,
			38.0,
			70, // HPs
			100, 115, // Attack & Defense
			30, 65, // Special Attack & Defense
			30		
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Slam",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Self-Destruct",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Block",
				"Covet",
				"Calm-Mind",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Copycat",
				"Sucker-Punch",
				"Rock-Polish",
				"Earth-Power",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Wood-Hammer",
				"Head-Smash",
				"Smack-Down",
				"Foul-Play",
				"After-You",
				"Round",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion

	//Sudowoodo PokemonInstance Class
	#region Sudowoodo
	public class SudowoodoInstance : PokemonInstance
	{
		#region Sudowoodo Constructors
		/// <summary>
		/// Sudowoodo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SudowoodoInstance(string nickname, int level)
		: base(
				185,
				SpeciesSudowoodo.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sudowoodo Builder only waiting for a Level
		/// </summary>
		public SudowoodoInstance(int level)
		: base(
				185,
				SpeciesSudowoodo.Instance, // PokemonInstance Species
				"Sudowoodo", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sudowoodo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Sudowoodo() : base(
			185,
			SpeciesSudowoodo.Instance, // PokemonInstance Species
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}