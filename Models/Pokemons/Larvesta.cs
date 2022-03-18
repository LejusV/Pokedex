using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Larvesta Species to store common natural stats of all Larvestas
	#region SpeciesLarvesta
	public class SpeciesLarvesta : PokemonSpecies
	{
#nullable enable
		private static SpeciesLarvesta? _instance = null;
#nullable restore
        public static SpeciesLarvesta Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLarvesta();
                }
                return _instance;
            }
        }

		#region SpeciesLarvesta Constructor
		public SpeciesLarvesta() : base(
			636,
			"Larvesta",
			1.1,
			28.8,
			55, // HPs
			85, 55, // Attack & Defense
			50, 55, // Special Attack & Defense
			60		
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
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Ember",
				"Flamethrower",
				"Absorb",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Harden",
				"Light-Screen",
				"Fire-Blast",
				"Amnesia",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Protect",
				"Foresight",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Morning-Sun",
				"Hidden-Power",
				"Sunny-Day",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Secret-Power",
				"Overheat",
				"Signal-Beam",
				"Calm-Mind",
				"U-Turn",
				"Magnet-Rise",
				"Flare-Blitz",
				"Bug-Buzz",
				"Zen-Headbutt",
				"Bug-Bite",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Struggle-Bug",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Larvesta PokemonInstance Class
	#region Larvesta
	public class LarvestaInstance : PokemonInstance
	{
		#region Larvesta Constructors
		/// <summary>
		/// Larvesta Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LarvestaInstance(string nickname, int level)
		: base(
				SpeciesLarvesta.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Larvesta Builder only waiting for a Level
		/// </summary>
		public LarvestaInstance(int level)
		: base(
				SpeciesLarvesta.Instance, // PokemonInstance Species
				"Larvesta", level,
				Bug.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Larvesta Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LarvestaInstance() : base(
			SpeciesLarvesta.Instance, // PokemonInstance Species
			Bug.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}