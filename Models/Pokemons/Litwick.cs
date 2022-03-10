using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Litwick Species to store common natural stats of all Litwicks
	#region SpeciesLitwick
	public class SpeciesLitwick : PokemonSpecies
	{
#nullable enable
		private static SpeciesLitwick? _instance = null;
#nullable restore
        public static SpeciesLitwick Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLitwick();
                }
                return _instance;
            }
        }

		#region SpeciesLitwick Constructor
		public SpeciesLitwick() : base(
			"Litwick",
			0.3,
			3.1,
			50, // HPs
			30, 55, // Attack & Defense
			65, 55, // Special Attack & Defense
			20		
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
				"Acid",
				"Ember",
				"Flamethrower",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Minimize",
				"Confuse-Ray",
				"Haze",
				"Smog",
				"Fire-Blast",
				"Dream-Eater",
				"Flash",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Heat-Wave",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Trick",
				"Imprison",
				"Secret-Power",
				"Astonish",
				"Overheat",
				"Calm-Mind",
				"Shock-Wave",
				"Payback",
				"Embargo",
				"Dark-Pulse",
				"Energy-Ball",
				"Trick-Room",
				"Captivate",
				"Power-Split",
				"Telekinesis",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Clear-Smog",
				"Hex",
				"Incinerate",
				"Inferno",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Litwick PokemonInstance Class
	#region Litwick
	public class LitwickInstance : PokemonInstance
	{
		#region Litwick Constructors
		/// <summary>
		/// Litwick Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LitwickInstance(string nickname, int level)
		: base(
				607,
				SpeciesLitwick.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litwick Builder only waiting for a Level
		/// </summary>
		public LitwickInstance(int level)
		: base(
				607,
				SpeciesLitwick.Instance, // PokemonInstance Species
				"Litwick", level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litwick Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Litwick() : base(
			607,
			SpeciesLitwick.Instance, // PokemonInstance Species
			Ghost.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}