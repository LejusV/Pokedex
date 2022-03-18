using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Beautifly Species to store common natural stats of all Beautiflys
	#region SpeciesBeautifly
	public class SpeciesBeautifly : PokemonSpecies
	{
#nullable enable
		private static SpeciesBeautifly? _instance = null;
#nullable restore
        public static SpeciesBeautifly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBeautifly();
                }
                return _instance;
            }
        }

		#region SpeciesBeautifly Constructor
		public SpeciesBeautifly() : base(
			267,
			"Beautifly",
			1.0,
			28.4,
			60, // HPs
			70, 50, // Attack & Defense
			100, 50, // Special Attack & Defense
			65		
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
				"Double-Edge",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Solar-Beam",
				"Stun-Spore",
				"String-Shot",
				"Toxic",
				"Psychic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Morning-Sun",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Shadow-Ball",
				"Facade",
				"Secret-Power",
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
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Venoshock",
				"Quiver-Dance",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Electroweb",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Beautifly PokemonInstance Class
	#region Beautifly
	public class BeautiflyInstance : PokemonInstance
	{
		#region Beautifly Constructors
		/// <summary>
		/// Beautifly Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BeautiflyInstance(string nickname, int level)
		: base(
				SpeciesBeautifly.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beautifly Builder only waiting for a Level
		/// </summary>
		public BeautiflyInstance(int level)
		: base(
				SpeciesBeautifly.Instance, // PokemonInstance Species
				"Beautifly", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beautifly Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BeautiflyInstance() : base(
			SpeciesBeautifly.Instance, // PokemonInstance Species
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}