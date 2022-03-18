using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Virizion Species to store common natural stats of all Virizions
	#region SpeciesVirizion
	public class SpeciesVirizion : PokemonSpecies
	{
#nullable enable
		private static SpeciesVirizion? _instance = null;
#nullable restore
        public static SpeciesVirizion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVirizion();
                }
                return _instance;
            }
        }

		#region SpeciesVirizion Constructor
		public SpeciesVirizion() : base(
			640,
			"Virizion",
			2.0,
			200.0,
			91, // HPs
			90, 72, // Attack & Defense
			90, 129, // Special Attack & Defense
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
				"Solar-Beam",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"False-Swipe",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Rock-Smash",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Secret-Power",
				"Aerial-Ace",
				"Block",
				"Bounce",
				"Magical-Leaf",
				"Calm-Mind",
				"Leaf-Blade",
				"Close-Combat",
				"Worry-Seed",
				"Seed-Bomb",
				"X-Scissor",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Stone-Edge",
				"Grass-Knot",
				"Round",
				"Quick-Guard",
				"Retaliate",
				"Work-Up",
				"Sacred-Sword",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Virizion PokemonInstance Class
	#region Virizion
	public class VirizionInstance : PokemonInstance
	{
		#region Virizion Constructors
		/// <summary>
		/// Virizion Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VirizionInstance(string nickname, int level)
		: base(
				SpeciesVirizion.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Virizion Builder only waiting for a Level
		/// </summary>
		public VirizionInstance(int level)
		: base(
				SpeciesVirizion.Instance, // PokemonInstance Species
				"Virizion", level,
				Grass.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Virizion Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public VirizionInstance() : base(
			SpeciesVirizion.Instance, // PokemonInstance Species
			Grass.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}