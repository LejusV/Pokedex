using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Volcarona Species to store common natural stats of all Volcaronas
	#region SpeciesVolcarona
	public class SpeciesVolcarona : PokemonSpecies
	{
#nullable enable
		private static SpeciesVolcarona? _instance = null;
#nullable restore
        public static SpeciesVolcarona Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVolcarona();
                }
                return _instance;
            }
        }

		#region SpeciesVolcarona Constructor
		public SpeciesVolcarona() : base(
			"Volcarona",
			1.6,
			46.0,
			85, // HPs
			60, 65, // Attack & Defense
			135, 105, // Special Attack & Defense
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
				"Gust",
				"Whirlwind",
				"Fly",
				"Thrash",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Absorb",
				"Solar-Beam",
				"String-Shot",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Fire-Blast",
				"Amnesia",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Sunny-Day",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Secret-Power",
				"Overheat",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"Tailwind",
				"U-Turn",
				"Magnet-Rise",
				"Flare-Blitz",
				"Poison-Jab",
				"Bug-Buzz",
				"Giga-Impact",
				"Zen-Headbutt",
				"Bug-Bite",
				"Rage-Powder",
				"Quiver-Dance",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Struggle-Bug",
				"Wild-Charge",
				"Hurricane",
				"Fiery-Dance",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Volcarona PokemonInstance Class
	#region Volcarona
	public class VolcaronaInstance : PokemonInstance
	{
		#region Volcarona Constructors
		/// <summary>
		/// Volcarona Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VolcaronaInstance(string nickname, int level)
		: base(
				637,
				SpeciesVolcarona.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volcarona Builder only waiting for a Level
		/// </summary>
		public VolcaronaInstance(int level)
		: base(
				637,
				SpeciesVolcarona.Instance, // PokemonInstance Species
				"Volcarona", level,
				Bug.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Volcarona Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Volcarona() : base(
			637,
			SpeciesVolcarona.Instance, // PokemonInstance Species
			Bug.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}