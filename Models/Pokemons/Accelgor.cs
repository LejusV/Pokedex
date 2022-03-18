using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Accelgor Species to store common natural stats of all Accelgors
	#region SpeciesAccelgor
	public class SpeciesAccelgor : PokemonSpecies
	{
#nullable enable
		private static SpeciesAccelgor? _instance = null;
#nullable restore
        public static SpeciesAccelgor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAccelgor();
                }
                return _instance;
            }
        }

		#region SpeciesAccelgor Constructor
		public SpeciesAccelgor() : base(
			617,
			"Accelgor",
			0.8,
			25.3,
			80, // HPs
			70, 40, // Attack & Defense
			100, 60, // Special Attack & Defense
			145		
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
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Recover",
				"Swift",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Sandstorm",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"U-Turn",
				"Gastro-Acid",
				"Me-First",
				"Power-Swap",
				"Bug-Buzz",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Bug-Bite",
				"Venoshock",
				"Acid-Spray",
				"Round",
				"Final-Gambit",
				"Struggle-Bug",
				"Confide",
				"Water-Shuriken",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Accelgor PokemonInstance Class
	#region Accelgor
	public class AccelgorInstance : PokemonInstance
	{
		#region Accelgor Constructors
		/// <summary>
		/// Accelgor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AccelgorInstance(string nickname, int level)
		: base(
				SpeciesAccelgor.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Accelgor Builder only waiting for a Level
		/// </summary>
		public AccelgorInstance(int level)
		: base(
				SpeciesAccelgor.Instance, // PokemonInstance Species
				"Accelgor", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Accelgor Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AccelgorInstance() : base(
			SpeciesAccelgor.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}