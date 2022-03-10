using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cobalion Species to store common natural stats of all Cobalions
	#region SpeciesCobalion
	public class SpeciesCobalion : PokemonSpecies
	{
#nullable enable
		private static SpeciesCobalion? _instance = null;
#nullable restore
        public static SpeciesCobalion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCobalion();
                }
                return _instance;
            }
        }

		#region SpeciesCobalion Constructor
		public SpeciesCobalion() : base(
			"Cobalion",
			2.1,
			250.0,
			91, // HPs
			90, 129, // Attack & Defense
			90, 72, // Special Attack & Defense
			108		
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
				"Cut",
				"Double-Kick",
				"Take-Down",
				"Leer",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Thunder-Wave",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Reflect",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sandstorm",
				"False-Swipe",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Metal-Claw",
				"Hidden-Power",
				"Psych-Up",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Secret-Power",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Bounce",
				"Calm-Mind",
				"Metal-Burst",
				"Close-Combat",
				"Magnet-Rise",
				"Rock-Polish",
				"Poison-Jab",
				"X-Scissor",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Quick-Guard",
				"Retaliate",
				"Volt-Switch",
				"Work-Up",
				"Sacred-Sword",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Cobalion PokemonInstance Class
	#region Cobalion
	public class CobalionInstance : PokemonInstance
	{
		#region Cobalion Constructors
		/// <summary>
		/// Cobalion Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CobalionInstance(string nickname, int level)
		: base(
				638,
				SpeciesCobalion.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cobalion Builder only waiting for a Level
		/// </summary>
		public CobalionInstance(int level)
		: base(
				638,
				SpeciesCobalion.Instance, // PokemonInstance Species
				"Cobalion", level,
				Steel.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cobalion Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Cobalion() : base(
			638,
			SpeciesCobalion.Instance, // PokemonInstance Species
			Steel.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}