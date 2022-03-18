using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Terrakion Species to store common natural stats of all Terrakions
	#region SpeciesTerrakion
	public class SpeciesTerrakion : PokemonSpecies
	{
#nullable enable
		private static SpeciesTerrakion? _instance = null;
#nullable restore
        public static SpeciesTerrakion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTerrakion();
                }
                return _instance;
            }
        }

		#region SpeciesTerrakion Constructor
		public SpeciesTerrakion() : base(
			639,
			"Terrakion",
			1.9,
			260.0,
			91, // HPs
			129, 90, // Attack & Defense
			72, 90, // Special Attack & Defense
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
				"Earthquake",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Reflect",
				"Rest",
				"Rock-Slide",
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
				"Hidden-Power",
				"Psych-Up",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Block",
				"Calm-Mind",
				"Close-Combat",
				"Rock-Polish",
				"Poison-Jab",
				"X-Scissor",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Quick-Guard",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Sacred-Sword",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Terrakion PokemonInstance Class
	#region Terrakion
	public class TerrakionInstance : PokemonInstance
	{
		#region Terrakion Constructors
		/// <summary>
		/// Terrakion Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TerrakionInstance(string nickname, int level)
		: base(
				SpeciesTerrakion.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Terrakion Builder only waiting for a Level
		/// </summary>
		public TerrakionInstance(int level)
		: base(
				SpeciesTerrakion.Instance, // PokemonInstance Species
				"Terrakion", level,
				Rock.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Terrakion Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TerrakionInstance() : base(
			SpeciesTerrakion.Instance, // PokemonInstance Species
			Rock.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}