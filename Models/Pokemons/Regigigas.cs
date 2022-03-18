using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Regigigas Species to store common natural stats of all Regigigass
	#region SpeciesRegigigas
	public class SpeciesRegigigas : PokemonSpecies
	{
#nullable enable
		private static SpeciesRegigigas? _instance = null;
#nullable restore
        public static SpeciesRegigigas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRegigigas();
                }
                return _instance;
            }
        }

		#region SpeciesRegigigas Constructor
		public SpeciesRegigigas() : base(
			486,
			"Regigigas",
			3.7,
			420.0,
			110, // HPs
			160, 110, // Attack & Defense
			80, 110, // Special Attack & Defense
			100		
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
				"Stomp",
				"Headbutt",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Confuse-Ray",
				"Dizzy-Punch",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Block",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Rock-Polish",
				"Drain-Punch",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Crush-Grip",
				"Wide-Guard",
				"Smack-Down",
				"Heavy-Slam",
				"Round",
				"Retaliate",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Regigigas PokemonInstance Class
	#region Regigigas
	public class RegigigasInstance : PokemonInstance
	{
		#region Regigigas Constructors
		/// <summary>
		/// Regigigas Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RegigigasInstance(string nickname, int level)
		: base(
				SpeciesRegigigas.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regigigas Builder only waiting for a Level
		/// </summary>
		public RegigigasInstance(int level)
		: base(
				SpeciesRegigigas.Instance, // PokemonInstance Species
				"Regigigas", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regigigas Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RegigigasInstance() : base(
			SpeciesRegigigas.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}