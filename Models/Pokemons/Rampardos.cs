using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Rampardos Species to store common natural stats of all Rampardoss
	#region SpeciesRampardos
	public class SpeciesRampardos : PokemonSpecies
	{
#nullable enable
		private static SpeciesRampardos? _instance = null;
#nullable restore
        public static SpeciesRampardos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRampardos();
                }
                return _instance;
            }
        }

		#region SpeciesRampardos Constructor
		public SpeciesRampardos() : base(
			409,
			"Rampardos",
			1.6,
			102.5,
			97, // HPs
			165, 60, // Attack & Defense
			65, 50, // Special Attack & Defense
			58		
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
				"Fire-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Take-Down",
				"Leer",
				"Roar",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Fling",
				"Rock-Polish",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Head-Smash",
				"Smack-Down",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Rampardos PokemonInstance Class
	#region Rampardos
	public class RampardosInstance : PokemonInstance
	{
		#region Rampardos Constructors
		/// <summary>
		/// Rampardos Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RampardosInstance(string nickname, int level)
		: base(
				SpeciesRampardos.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rampardos Builder only waiting for a Level
		/// </summary>
		public RampardosInstance(int level)
		: base(
				SpeciesRampardos.Instance, // PokemonInstance Species
				"Rampardos", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rampardos Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RampardosInstance() : base(
			SpeciesRampardos.Instance, // PokemonInstance Species
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}