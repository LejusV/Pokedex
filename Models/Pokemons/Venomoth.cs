using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Venomoth Species to store common natural stats of all Venomoths
	#region SpeciesVenomoth
	public class SpeciesVenomoth : PokemonSpecies
	{
#nullable enable
		private static SpeciesVenomoth? _instance = null;
#nullable restore
        public static SpeciesVenomoth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVenomoth();
                }
                return _instance;
            }
        }

		#region SpeciesVenomoth Constructor
		public SpeciesVenomoth() : base(
			"Venomoth",
			1.5,
			12.5,
			70, // HPs
			65, 60, // Attack & Defense
			90, 75, // Special Attack & Defense
			90		
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
				"Razor-Wind",
				"Gust",
				"Whirlwind",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Supersonic",
				"Disable",
				"Psybeam",
				"Hyper-Beam",
				"Mega-Drain",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"String-Shot",
				"Toxic",
				"Confusion",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Swift",
				"Leech-Life",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Foresight",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Facade",
				"Skill-Swap",
				"Secret-Power",
				"Poison-Fang",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Venoshock",
				"Quiver-Dance",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Venomoth PokemonInstance Class
	#region Venomoth
	public class VenomothInstance : PokemonInstance
	{
		#region Venomoth Constructors
		/// <summary>
		/// Venomoth Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VenomothInstance(string nickname, int level)
		: base(
				49,
				SpeciesVenomoth.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venomoth Builder only waiting for a Level
		/// </summary>
		public VenomothInstance(int level)
		: base(
				49,
				SpeciesVenomoth.Instance, // PokemonInstance Species
				"Venomoth", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venomoth Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Venomoth() : base(
			49,
			SpeciesVenomoth.Instance, // PokemonInstance Species
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}